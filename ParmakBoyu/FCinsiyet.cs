using ParmakBoyu.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParmakBoyu
{
    public partial class FCinsiyet : Form
    {
        public FCinsiyet()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtDosya.Text = openFileDialog1.FileName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtDosya.Text = openFileDialog1.FileName;
        }

        private void btnSonuc_Click_1(object sender, EventArgs e)
        {
            double sonuc = Classification.GroupTest(txtDosya.Text,Convert.ToInt32(txtEgitim.Text));
            MessageBox.Show("Sistem degerlendirme sonucu " + sonuc + "kadar başarı saglamıştır...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grup_Secimi grp = new Grup_Secimi();
            grp.Show();
            this.Hide();
        }



    }
}

