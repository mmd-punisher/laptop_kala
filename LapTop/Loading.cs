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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            pbar.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 1;
            pbar.Text = pbar.Value.ToString();
            if (pbar.Value == 100)
            {
                timer1.Enabled = false;
                new HomeForm().Show();
                this.Hide();
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
