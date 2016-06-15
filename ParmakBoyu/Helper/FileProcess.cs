using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;

namespace ParmakBoyu.Helper
{
    class FileProcess
    {

        #region generalValues
        private string path;
        List<KanGrubu> lstKangrubu;
        KanGrubu kanGrubu;
        const Int32 BufferSize = 128;
        #endregion 

        private void init(string path)
        {
            lstKangrubu = new List<KanGrubu>();
            kanGrubu = new KanGrubu();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
        }

        public FileProcess(string path)
        {
            init(path);
        }

        public void createFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
        }

        public List<KanGrubu> txtReader(string path)
        {
            lstKangrubu = new List<KanGrubu>();
            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (!line.Contains("@"))
                    {
                        try
                        {
                            kanGrubu = new KanGrubu();
                            Object[] data = line.Split(',');
                            kanGrubu.ridgeCount = Convert.ToInt32(data[0]);
                            kanGrubu.valleyCount = Convert.ToInt32(data[1]);
                            kanGrubu.valleyThickness = Convert.ToInt32(data[2]);
                            kanGrubu.ridgeThickness = Convert.ToInt32(data[3]);
                            kanGrubu.ratioRidgeCountToValleyCount = Convert.ToDouble(data[4]);
                            kanGrubu.ratioOfValleyThicknessValleyCount = Convert.ToDouble(data[5]);
                            kanGrubu.ratioRidgeThicknesstoValleyThickness = Convert.ToDouble(data[6]);
                            kanGrubu.result=Convert.ToInt32(data[7]);

                            lstKangrubu.Add(kanGrubu);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                return lstKangrubu;
            }
        }
         

        public void txtWriter(KanGrubu kanGrubu,string path)
        {
            string writerLetter = "" + kanGrubu.valleyCount + "," + kanGrubu.ridgeCount + "," + kanGrubu.valleyThickness +
                "," + kanGrubu.ridgeThickness + "," + kanGrubu.ratioRidgeThicknesstoValleyThickness + "," 
                +kanGrubu.ratioRidgeCountToValleyCount+","
                + kanGrubu.ratioOfValleyThicknessValleyCount+"," + kanGrubu.result;
            createFile(path);
            using (StreamWriter stream = new FileInfo(path).AppendText())
            {
                stream.WriteLine( writerLetter, Environment.NewLine);
            }
        }

        public string randomFillBloomGroup(int count,string path)
        {
            Random rnd = new Random();
            KanGrubu kan;
            for (int i = 0; i < count; i++)
            {
                try
                {
                    kan = new KanGrubu();
                    kan.valleyCount = rnd.Next(1, 80);
                    kan.valleyThickness = rnd.Next(1, 80);
                    kan.ridgeCount = 80 - kan.valleyCount;
                    kan.ridgeThickness = 80 - kan.valleyThickness;
                    kan.ratioOfValleyThicknessValleyCount = Convert.ToDouble( Math.Round(Convert.ToDouble(kan.valleyThickness) /
                        Convert.ToDouble(kan.valleyCount), 2).ToString().Replace(",","."), CultureInfo.InvariantCulture);
                    kan.ratioRidgeCountToValleyCount = Convert.ToDouble(Math.Round(Convert.ToDouble(kan.ridgeCount) /
                        Convert.ToDouble(kan.valleyCount), 2).ToString().Replace(",", "."), CultureInfo.InvariantCulture);
                    kan.ratioRidgeThicknesstoValleyThickness = Convert.ToDouble(Math.Round(Convert.ToDouble(kan.ridgeThickness) /
                        Convert.ToDouble(kan.valleyThickness), 2).ToString().Replace(",", "."), CultureInfo.InvariantCulture);
                    kan.result = rnd.Next(1, 4);
                    txtWriter(kan, path);
                }
                catch(Exception ex)
                {
                    return ex.Message;
                }
            }
            return "işlem başarı ile tamamlandı";
        }


    }
}