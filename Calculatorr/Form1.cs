namespace Calculatorr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '7';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '6';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '9';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '0';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ',';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '/';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '*';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '-';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                textBox1.Clear();

            }
            textBox1.Text += '+';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.ClearUndo();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Operations ops = new Operations();

            string result = ops.Calculate(textBox1.Text).ToString();
            textBox1.Text = result; ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}