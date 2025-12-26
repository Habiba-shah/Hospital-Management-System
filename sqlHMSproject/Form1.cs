namespace sqlHMSproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text=="1234")
            {
                Main mn=new Main();
                mn.Show();
            }
            else if(txtUsername.Text !="admin"|| txtPassword.Text != "1234")
            {
                MessageBox.Show("Invalid Username & Password");
            }
        }
    }
}
