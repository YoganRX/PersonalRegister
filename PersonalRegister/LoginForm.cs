namespace PersonalRegister
{
    public partial class LoginForm : Form
    {
        /*
        class User
        {
            string username = "admin";
            string password = "password";

            public Boolean checkLogin(string uName, string pw)
            {
                if (uName == username && pw == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        User user = new User();
        */
        User1 usr = new User1();    

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textUsername.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /*
            if (user.checkLogin(textUsername.Text, textPassword.Text))
            {
                new IndexForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Användarnamnet eller Lösenordet är felaktigt.");
                textUsername.Clear();
                textPassword.Clear();
                textUsername.Focus();
            }
            */
            if (usr.checkLogin(textUsername.Text, textPassword.Text))
            {
                new IndexForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Användarnamnet eller Lösenordet är felaktigt.");
                textUsername.Clear();
                textPassword.Clear();
                textUsername.Focus();
            }
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
