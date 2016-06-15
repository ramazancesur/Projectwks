using ParmakBoyu.Helper;
using System;
using System.Windows.Forms;

namespace ParmakBoyu
{
    public partial class CrossValidation : Form
    {
        public CrossValidation()
        {
            InitializeComponent();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtDosya.Text = openFileDialog1.FileName;
        }

        private void BtnSonuc_Click(object sender, EventArgs e)
        {
            double sonuc = Classification.CrossValidation(txtDosya.Text, Convert.ToInt32(txtFolds.Text));
            MessageBox.Show("Sistem degerlendirme sonucu " + sonuc + "kadar başarı saglamıştır...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grup_Secimi grp = new Grup_Secimi();
            grp.Show();
            this.Hide();
        }
    }
}
