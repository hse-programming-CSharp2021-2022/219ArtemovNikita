namespace WinForm_01
{
    public partial class IloveCsharp : Form
    {
        public IloveCsharp()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Yeaa, i love c#, and btw i hate python :)";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Hello, this is ILoveC# program! To continue click any button...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Visible = false;
            this.button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Visible = false;
            this.button2.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.label2.Text = "Я просто хочу сказать, что питон после C# - это боль, а матпраки тем более :(";
        }
    }
}