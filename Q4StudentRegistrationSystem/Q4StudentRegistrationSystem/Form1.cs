namespace Q4StudentRegistrationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text;
            string email = textBox2.Text;
            string phoneNumber = textBox3.Text;
            string gender = comboBox1.SelectedItem.ToString();
            string course = comboBox2.SelectedItem.ToString();
            string dateOfBirth = dateTimePicker1.Value.ToShortDateString();

            // Display registration details
            string message = $"Registration Successful!\n\nFull Name: {fullName}\nEmail: {email}\nPhone Number: {phoneNumber}\nGender: {gender}\nDate of Birth: {dateOfBirth}\nCourse: {course}";
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
