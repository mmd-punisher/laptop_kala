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
    public partial class FAQForm : Form
    {
        public FAQForm()
        {
            InitializeComponent();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(116, 100, 188);
            label2.ForeColor = Color.Black;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
            label7.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.FromArgb(116, 100, 188);
            label7.ForeColor = Color.Black;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
            label5.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(116, 100, 188);
            label5.ForeColor = Color.Black;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
            label4.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(116, 100, 188);
            label4.ForeColor = Color.Black;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
        }
    }
}
