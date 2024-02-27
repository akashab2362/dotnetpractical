namespace Q5Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool IsPasswordValid(string password)
        {
            // Check if password is at least 8 characters long
            if (password.Length < 8)
            {
                return false;
            }

            // Check if password contains at least one capital letter or special character
            if (!password.Any(char.IsUpper) && !password.Any(char.IsSymbol))
            {
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(IsPasswordValid(password) )
            {
                MessageBox.Show("Please Enter a valid password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
