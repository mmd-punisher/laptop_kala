using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTop
{
    public partial class All_LPForm : Form
    {
        All_LP_Class cls = new All_LP_Class();//shey sakhtim
        public All_LPForm()
        {
            InitializeComponent();
        }
        private void All_LP_Load(object sender, EventArgs e)
        {
            cls.frm11 = this;
            cls.LaptopShow();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cls.frm11 = this;
            cls.DeleteLaptop();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cls.frm11 = this;
            cls.LaptopShow();
            textBoxSearch.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cls.frm11 = this;
            cls.SearchLaptop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls.frm11 = this;
            cls.SaveLaptop();
            MessageBox.Show("Saved Successfully.", "Info", MessageBoxButtons.OK , MessageBoxIcon.Information);
        }
    }
}
