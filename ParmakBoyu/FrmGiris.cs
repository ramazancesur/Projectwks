using ParmakBoyu.Helper;
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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnlik frm = new FrmAnlik();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grup_Secimi frm1 = new Grup_Secimi();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAnlik frm = new FrmAnlik();
            frm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Grup_Secimi frm1 = new Grup_Secimi();
            frm1.Show();
            this.Hide();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FileProcess file = new FileProcess("aaa");
           MessageBox.Show( file.randomFillBloomGroup(120,@"F:\test.txt"));
        }
    }
}
