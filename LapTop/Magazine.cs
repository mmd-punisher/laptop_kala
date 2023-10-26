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
    public partial class MagazineForm : Form
    {
        public MagazineForm()
        {
            InitializeComponent();
        }

        private void lblTech_Click(object sender, EventArgs e)
        {
            lbl1tech.Visible = true; lbl2tech.Visible = true; pictureBoxtech.Visible = true;
            lbl1Cinema.Visible = false; lbl2Cinema.Visible = false; pictureBoxCinema.Visible = false;
            lbl1Sport.Visible = false; lbl2sport.Visible = false; pictureBoxsport.Visible = false;
            lbl1game.Visible = false; lbl2game.Visible = false; pictureBoxgame.Visible = false;
            lblchoose.Visible = false; pictureBoxchoose.Visible = false;
        }

        private void lblCinema_Click(object sender, EventArgs e)
        {
            lbl1Cinema.Visible = true; lbl2Cinema.Visible = true; pictureBoxCinema.Visible = true;
            lbl1Sport.Visible = false; lbl2sport.Visible = false; pictureBoxsport.Visible = false;
            lbl1game.Visible = false; lbl2game.Visible = false; pictureBoxgame.Visible = false;
            lbl1tech.Visible = false; lbl2tech.Visible = false; pictureBoxtech.Visible = false;
            lblchoose.Visible = false; pictureBoxchoose.Visible = false;
        }

        private void lblSport_Click(object sender, EventArgs e)
        {
            lbl1Sport.Visible = true; lbl2sport.Visible = true; pictureBoxsport.Visible = true;
            lbl1game.Visible = false; lbl2game.Visible = false; pictureBoxgame.Visible = false;
            lbl1Cinema.Visible = false; lbl2Cinema.Visible = false; pictureBoxCinema.Visible = false;
            lbl1tech.Visible = false; lbl2tech.Visible = false; pictureBoxtech.Visible = false;
            lblchoose.Visible = false; pictureBoxchoose.Visible = false;
        }

        private void lblgame_Click(object sender, EventArgs e)
        {
            lbl1game.Visible = true; lbl2game.Visible = true; pictureBoxgame.Visible = true;
            lbl1Cinema.Visible = false; lbl2Cinema.Visible = false; pictureBoxCinema.Visible = false;
            lbl1tech.Visible = false; lbl2tech.Visible = false; pictureBoxtech.Visible = false;
            lbl1Sport.Visible = false; lbl2sport.Visible = false; pictureBoxsport.Visible = false;
            lblchoose.Visible = false; pictureBoxchoose.Visible = false;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
        }
    }
}
