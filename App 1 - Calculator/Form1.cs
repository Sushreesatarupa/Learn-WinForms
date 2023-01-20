namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {   if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 + num2;
                label3.Text = result.ToString();
                label3.Visible = true;

            }
            else MessageBox.Show("PLEASE ENTER BOTH FIELDS");
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 - num2;
                label3.Text = result.ToString();
                label3.Visible = true;

            }
            else MessageBox.Show("PLEASE ENTER BOTH FIELDS");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 * num2;
                label3.Text = result.ToString();
                label3.Visible = true;

            }
            else MessageBox.Show("PLEASE ENTER BOTH FIELDS");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                if (num2 == 0)
                {
                    label3.Text = "INFINITE";
                    label3.Visible = true;
                }
                else
                {
                    double result = num1 * 1.0 / num2;
                    label3.Text = result.ToString();
                    label3.Visible = true;

                }

            }
            else MessageBox.Show("PLEASE ENTER BOTH FIELDS");


            
            
        }
    }
}