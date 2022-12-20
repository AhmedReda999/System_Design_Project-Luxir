namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        Form5 f5 = new Form5();
        Form3 f3 = new Form3();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Username or Password are not filled", "Incomplete Data", MessageBoxButtons.OK);
            }
            else
            {
                if (username == "admin")
                {
                    if (password == "admin")
                    {
                        this.Hide();
                        f5.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("InCorrect Password");
                    }

                }
                else
                {
                    this.Hide();
                    f3.ShowDialog();
                }
            }
        }
    }
}