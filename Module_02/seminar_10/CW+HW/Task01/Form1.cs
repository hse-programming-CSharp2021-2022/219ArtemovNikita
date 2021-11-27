namespace Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> p = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (p.Count == 0)
            {
                label1.Text = "Член ряда Пелла: " + $"{1}";
                p.Add(1);
            }
            else if (p.Count == 1)
            {
                label1.Text = "Член ряда Пелла: " + $"{2}";
                p.Add(2);
            }
            else
            {
                checked
                {
                    try
                    {
                        p.Add(2 * p[p.Count - 1] * p[p.Count - 2]);
                        label1.Text = "Член ряда Пелла: " + $"{p[p.Count - 1]}";
                    }
                    catch
                    {
                        MessageBox.Show("Переполнение! Начнем с начала");
                        label1.Text = "Член ряда Пелла: ";
                        p.Clear();
                        p.Add(1);
                        p.Add(2);
                    }
                }
            }
        }
    }
}