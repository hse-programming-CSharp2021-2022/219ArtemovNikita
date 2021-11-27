namespace Task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] str = { "one", "two", "three" };

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Lines = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var str = string.Join(" ", textBox1.Lines);
            MessageBox.Show(str);
        }
    }
}