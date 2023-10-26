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
    public partial class SEC_Register : Form
    {
        public SEC_Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "1997")
            {
                new RegisterForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password is Incorrect." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                textBox1.Text = "";
            }
        }
    }
}
