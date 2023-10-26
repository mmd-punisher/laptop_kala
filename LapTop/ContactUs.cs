using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LapTop
{
    public partial class ContactUsForm : Form
    {
        public ContactUsForm()
        {
            InitializeComponent();
        }

        private void lbladdress_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://brooklynboulders.com/locations");
            //var prs = new ProcessStartInfo("Chrome.exe");
            //prs.Arguments = "https://brooklynboulderingproject.com";
            //Process.Start(prs);
        }

        private void lblemail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.yahoo.com/");
        }

        private void lblloc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com/search?q=brooklyn+boulders+locations&oq=&aqs=chrome.4.35i39i362j46i39i199i291i362j35i39i362l6.45694816j0j15&sourceid=chrome&ie=UTF-8");
        }

        private void lblinstagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/mmd_ce/");
        }

        private void lblinstagramkhodm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/ksrakarimy/");
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            
        }
    }
}
