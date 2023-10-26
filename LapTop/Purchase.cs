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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string RegisterData = textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text + "-" + textBox4.Text + "-" + textBox5.Text + "-" + textBox6.Text + "-" + textBox7.Text + "-" + textBox8.Text + "-" + textBox9.Text + "\n";
            File.AppendAllText(@"C:\Users\Parto\Desktop\files final\Purchase.txt", RegisterData);
            //*******************************************************************************************
            notifyIcon1.BalloonTipText = "Purchased Successfully.";
            notifyIcon1.Icon = notifyIcon1.Icon;
            notifyIcon1.ShowBalloonTip(5);
            //*******************************************************************************************
            new HomeForm().Show();
            this.Hide();
        }
    }
}
