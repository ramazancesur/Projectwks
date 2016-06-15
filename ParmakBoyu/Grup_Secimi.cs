using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParmakBoyu
{
    public partial class Grup_Secimi : Form
    {
        public Grup_Secimi()
        {
            InitializeComponent();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            CrossValidation frm = new CrossValidation();
            frm.Show();
            this.Hide();
        }

        private void BtnYuzde_Click(object sender, EventArgs e)
        {
            FCinsiyet frm = new FCinsiyet();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris grs = new FrmGiris();
            grs.Show();
            this.Hide();
        }
    }
}
