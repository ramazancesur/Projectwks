using ParmakBoyu.Helper;
using System;
using System.Windows.Forms;

namespace ParmakBoyu
{
    public partial class FrmAnlik : Form
    {
        public FrmAnlik()
        {
            InitializeComponent();
        }

        Classification classification;
        FileProcess fileProcess;
        string path;
        private void init(string path)
        {
            classification = new Classification();
            fileProcess = new FileProcess(path);
            this.path = path;
        }
        private void BtnSonuc_Click(object sender, EventArgs e)
        {
            KanGrubu kanGrubu = new KanGrubu();
            kanGrubu.ridgeCount = Convert.ToInt32(txtRidgeCount.Text);
            kanGrubu.valleyCount = Convert.ToInt32(txtValleyCount.Text);
            kanGrubu.ridgeThickness = Convert.ToInt32(txtRidgeThickness.Text);
            kanGrubu.valleyThickness = Convert.ToInt32(txtValleyThickness.Text);
            kanGrubu.ratioOfValleyThicknessValleyCount =
                Convert.ToDouble(kanGrubu.valleyThickness) / Convert.ToDouble(kanGrubu.valleyCount);
            kanGrubu.ratioRidgeCountToValleyCount = Convert.ToDouble(kanGrubu.ridgeCount)
                    / Convert.ToInt32(kanGrubu.valleyCount);
            kanGrubu.ratioRidgeThicknesstoValleyThickness =
                Convert.ToInt32(kanGrubu.ridgeThickness) / Convert.ToInt32(kanGrubu.valleyThickness);
            kanGrubu.result = 2;
            fileProcess.txtWriter(kanGrubu,this.path);
            string tahmin = Classification.PredictBlood(path);
            MessageBox.Show(tahmin);
            fileProcess.deleteLastLine(path);
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris grs = new FrmGiris();
            grs.Show();
            this.Hide();
        }

        private void FrmAnlik_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen Dosya Seçiniz";
            openFileDialog1.Filter = "(*.arff)|*.arff|(*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            path = (openFileDialog1.FileName);
            init(path);
        }

    }
}
