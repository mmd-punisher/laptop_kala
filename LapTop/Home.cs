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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel2.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                panel2.Visible = true;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new MSIForm().Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            HomeCLS hcls = new HomeCLS();
            hcls.khaneh = this;
            hcls.Tarikh();
            //***************************************************************
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
           
        }
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(336, 380);
            pictureBox6.Location = new Point(328, 367);
            pictureBox4.SendToBack();
            pictureBox5.SendToBack();
            label8.Visible = true;
            label3.ForeColor = Color.Red;
        }

        private void pictureBox5_DragLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(316, 360);
            pictureBox6.Location = new Point(338, 377);
            label8.Visible = false;
            label3.ForeColor = Color.FromArgb(116, 100, 188);
        }
        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(336, 380);
            pictureBox5.Location = new Point(650, 367);
            pictureBox4.SendToBack();
            pictureBox6.SendToBack();
            label9.Visible = true;
            label4.ForeColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(316, 360);
            pictureBox5.Location = new Point(660, 377);
            label9.Visible = false;
            label4.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(336, 380);
            pictureBox4.Location = new Point(6, 367);
            pictureBox6.SendToBack();
            pictureBox5.SendToBack();
            label7.Visible = true;
            label1.ForeColor = Color.Red;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(316, 360);
            pictureBox4.Location = new Point(16, 377);
            label7.Visible = false;
            label1.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void lblMagazine_Click(object sender, EventArgs e)
        {
            new MagazineForm().Show();
            this.Hide();
        }

        private void lblContactus_Click(object sender, EventArgs e)
        {
            new ContactUsForm().Show();
            this.Hide();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 4)
            {
                pictureBox1.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }
        int count2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (count2 < 5)
            {
                pictureBox7.Image = imageList2.Images[count2];
                count2++;
            }
            else
            {
                count2 = 0;
            }
        }

        private void lblCertification_Click(object sender, EventArgs e)
        {
            new CertificationsForm().Show();
            this.Hide();
        }

        private void lblClub_Click(object sender, EventArgs e)
        {
            new ClubForm().Show();
            this.Hide();
        }

        private void lblAlllaptop_MouseEnter(object sender, EventArgs e)
        {
            lblAlllaptop.ForeColor = Color.Red;
        }

        private void lblAlllaptop_MouseLeave(object sender, EventArgs e)
        {
            lblAlllaptop.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void lblRegister_MouseEnter(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.Red;
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void lblDiscount_MouseEnter(object sender, EventArgs e)
        {
            lblDiscount.ForeColor = Color.Red;
        }

        private void lblDiscount_MouseLeave(object sender, EventArgs e)
        {
            lblDiscount.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void lblMagazine_MouseEnter(object sender, EventArgs e)
        {
            lblMagazine.ForeColor = Color.Red;
        }

        private void lblMagazine_MouseLeave(object sender, EventArgs e)
        {
            lblMagazine.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void lblCertification_MouseEnter(object sender, EventArgs e)
        {
            lblCertification.ForeColor = Color.Red;
        }

        private void lblCertification_MouseLeave(object sender, EventArgs e)
        {
            lblCertification.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void lblFAQ_MouseEnter(object sender, EventArgs e)
        {
            lblFAQ.ForeColor = Color.Red;
        }

        private void lblFAQ_MouseLeave(object sender, EventArgs e)
        {
            lblFAQ.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void lblClub_MouseEnter(object sender, EventArgs e)
        {
            lblClub.ForeColor = Color.Red;
        }

        private void lblClub_MouseLeave(object sender, EventArgs e)
        {
            lblClub.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void lblContactus_MouseEnter(object sender, EventArgs e)
        {
            lblContactus.ForeColor = Color.Red;
        }

        private void lblContactus_MouseLeave(object sender, EventArgs e)
        {
            lblContactus.ForeColor = Color.FromArgb(116, 100, 188);
        }

        private void lblFAQ_Click(object sender, EventArgs e)
        {
            new FAQForm().Show();
            this.Hide();
        }

        private void lblDiscount_Click(object sender, EventArgs e)
        {
            new DiscountForm().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new MacBForm().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new AsusForm().Show();
            this.Hide();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            new SEC_Register().Show();
            this.Hide();
        }

        private void lblAlllaptop_Click(object sender, EventArgs e)
        {
            new SEC_ALL().Show();
            this.Hide();
        }
    }
}
