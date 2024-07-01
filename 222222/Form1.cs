namespace _222222
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random sayýsalloto = new Random();

            textBox1.Text = Convert.ToString(sayýsalloto.Next(49));
            textBox2.Text = Convert.ToString(sayýsalloto.Next(49));
            textBox3.Text = Convert.ToString(sayýsalloto.Next(49));
            textBox4.Text = Convert.ToString(sayýsalloto.Next(49));
            textBox5.Text = Convert.ToString(sayýsalloto.Next(49));
            textBox6.Text = Convert.ToString(sayýsalloto.Next(49));
        }
    }
}