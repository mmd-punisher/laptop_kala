namespace LapTop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (RadioAdmin.Checked)
            {
                
                if (txtUsername.Text == "Laptop" && txtPass.Text == "1997")
                {
                    //lf1 = new LoadingForm();
                    //lf1.frm = this;
                    //lf1.ShowDialog();
                    new LoadingForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtUsername.Clear();
                    txtUsername.Focus();
                }
            }
           if (RadioMember.Checked)
            {
                
                if (txtUsername.Text == "Ali" && txtPass.Text == "1234" || txtUsername.Text == "Naser" && txtPass.Text == "5678" || txtUsername.Text == "Shadi" && txtPass.Text == "2022" || txtUsername.Text == "Atena" && txtPass.Text == "1401" || txtUsername.Text == "Sabah" && txtPass.Text == "S012")
                {
                    //lf1 = new LoadingForm();
                    //lf1.frm = this;
                    //lf1.ShowDialog();
                    new LoadingForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtUsername.Clear();
                    txtUsername.Focus();
                }
            }
            if (RadioAdmin.Checked == false && RadioMember.Checked == false)
            {
                MessageBox.Show("Choose one of these: Member/Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPass.Clear();
            txtUsername.Focus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}