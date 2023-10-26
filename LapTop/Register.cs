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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            textBoxB.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBoxB.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //StreamWriter aq = new StreamWriter(@"C:\Users\Parto\Desktop\files final\All-LP.txt");
            //*************************************************************************
            string RegisterData = textBoxB.Text + "-" + textBoxM.Text 
                + "-" + textBoxC.Text + "-" + textBoxG.Text + "-" 
                + textBoxD.Text + "-" + textBoxME.Text + "-" + textBoxS.Text + "\n";
            //aq.Close();
            //*************************************************************************
            File.AppendAllText(@"C:\Users\Parto\Desktop\files final\All-LP.txt", RegisterData);
            MessageBox.Show("Laptop Added Successfully." , "Info" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            new HomeForm().Show();
            this.Hide();
        }

        private void textBoxM_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "";
        }

        private void textBoxC_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
        }

        private void textBoxG_Click(object sender, EventArgs e)
        {
            textBoxG.Text = "";
        }

        private void textBoxD_Click(object sender, EventArgs e)
        {
            textBoxD.Text = "";
        }

        private void textBoxME_Click(object sender, EventArgs e)
        {
            textBoxME.Text = "";
        }

        private void textBoxS_Click(object sender, EventArgs e)
        {
            textBoxS.Text = "";
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
           
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
