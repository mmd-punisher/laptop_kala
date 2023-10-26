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
    public partial class AsusForm : Form
    {
        public AsusForm()
        {
            InitializeComponent();
        }

        private void Asus_Load(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            textBox1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = true;
            pictureBox12.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = true;
        }

        private void label29_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
        }

        private void pictureBox1logoapple_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1logoapple.Size = new Size(301, 56);
            pictureBox1logoapple.Location = new Point(9, 9);
        }

        private void pictureBox1logoapple_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1logoapple.Size = new Size(295, 50);
            pictureBox1logoapple.Location = new Point(12, 12);
        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.Size = new Size(67, 51);
            pictureBox13.Location = new Point(10, 146);
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Size = new Size(63, 47);
            pictureBox13.Location = new Point(12, 148);
        }

        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(52, 52);
            pictureBox14.Location = new Point(11, 187);
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(50, 50);
            pictureBox14.Location = new Point(12, 188);
        }

        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.Size = new Size(52, 52);
            pictureBox15.Location = new Point(72, 187);
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Size = new Size(50, 50);
            pictureBox15.Location = new Point(73, 188);
        }

        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox16.Size = new Size(52, 52);
            pictureBox16.Location = new Point(134, 187);
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Size = new Size(50, 50);
            pictureBox16.Location = new Point(135, 188);
        }

        private void pictureBox17_MouseEnter(object sender, EventArgs e)
        {
            pictureBox17.Size = new Size(52, 52);
            pictureBox17.Location = new Point(195, 187);
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Size = new Size(50, 50);
            pictureBox17.Location = new Point(196, 188);
        }

        private void textboxtakhfif_MouseEnter(object sender, EventArgs e)
        {
            pictureBox20.Size = new Size(48, 33);
            pictureBox20.Location = new Point(13, 248);
        }

        private void textboxtakhfif_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.Size = new Size(50, 35);
            pictureBox20.Location = new Point(12, 247);
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = Color.Red;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label19.ForeColor = Color.Red;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label19.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void label22_MouseEnter(object sender, EventArgs e)
        {
            label26.ForeColor = Color.Red;
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            label26.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Red;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label20.ForeColor = Color.Red;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label20.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            label28.ForeColor = Color.Red;
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            label28.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void btnemaletakhfif_Click(object sender, EventArgs e)
        {
            if (textboxtakhfif.Text == "CH341BG98JM32")
            {
                btnPMSI.Text = "   1919$";
                MessageBox.Show("20% Discount have been done.", "Info");
                textboxtakhfif.Enabled = false;
            }
            if (textboxtakhfif.Text == "BN345WS21ZX88")
            {
                btnPMSI.Text = "  1439$";
                MessageBox.Show("40% Discount have been done.", "Info");
                textboxtakhfif.Enabled = false;
            }
            if (textboxtakhfif.Text == "32XCV22FT678M")
            {
                btnPMSI.Text = "  959$";
                MessageBox.Show("60% Discount have been done.", "Info");
                textboxtakhfif.Enabled = false;
            }
            if (textboxtakhfif.Text == "DS334ZAQ1223Y")
            {
                btnPMSI.Text = "  479$";
                MessageBox.Show("80% Discount have been done.", "Info");
                textboxtakhfif.Enabled = false;
            }
        }

        private void pictureBox18_MouseEnter(object sender, EventArgs e)
        {
            Asusv.Size = new Size(56, 56);
            Asusv.Location = new Point(311,288);
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            Asusv.Size = new Size(50, 50);
            Asusv.Location = new Point(314, 291);
        }

        private void Asusv_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Text = "https://www.youtube.com/watch?v=FhSDCigJ3xc";
        }

        private void btnPMSI_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are YOU Sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                new PurchaseForm().Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
    }
}
