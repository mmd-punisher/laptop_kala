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
    public partial class CertificationsForm : Form
    {
        public CertificationsForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(230, 230);
            pictureBox1.Location = new Point(2, 2);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(210, 210);
            pictureBox1.Location = new Point(12, 12);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(230, 230);
            pictureBox2.Location = new Point(2, 218);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(210, 210);
            pictureBox2.Location = new Point(12, 228);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(230, 230);
            pictureBox3.Location = new Point(2, 434);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(210, 210);
            pictureBox3.Location = new Point(12, 444);
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
            
        }
    }
}
