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
    public partial class DiscountForm : Form
    {
        public DiscountForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(116, 100, 188);
            pictureBox1.Size = new Size(230, 171);
            pictureBox1.Location = new Point(14, 15);
            textBox1.BringToFront();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            pictureBox1.Size = new Size(210, 151);
            pictureBox1.Location = new Point(24, 25);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(116, 100, 188);
            pictureBox2.Size = new Size(230, 171);
            pictureBox2.Location = new Point(487, 15);
            textBox2.BringToFront();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            pictureBox2.Size = new Size(210, 151);
            pictureBox2.Location = new Point(497, 25);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(116, 100, 188);
            pictureBox3.Size = new Size(230, 171);
            pictureBox3.Location = new Point(14, 245);
            textBox3.BringToFront();
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
            pictureBox3.Size = new Size(210, 151);
            pictureBox3.Location = new Point(24, 255);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(116, 100, 188);
            pictureBox4.Size = new Size(230, 171);
            pictureBox4.Location = new Point(487, 245);
            textBox4.BringToFront();
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
            pictureBox4.Size = new Size(210, 151);
            pictureBox4.Location = new Point(497, 255);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "CH341BG98JM32";//20%
            textBox1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "BN345WS21ZX88";//40%
            textBox2.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "32XCV22FT678M";//60%
            textBox4.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "DS334ZAQ1223Y";//80%
            textBox3.Enabled = true;
        }
    }
}
