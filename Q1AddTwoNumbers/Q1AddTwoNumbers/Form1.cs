namespace Q1AddTwoNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int num1) && (int.TryParse(textBox2.Text, out int num2)))
            {
                int sum = num1 + num2;

                label3.Text = "Result: " + sum.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a valid numbers in both the fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
