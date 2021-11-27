using System.Linq;

namespace Task02
{
    public partial class Form1 : Form
    {
        string[] lines = { "один", "два", "три", "четыре", "пять", "шесть", "семь" };
        string[] newLines;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(lines);
            newLines = lines;
            buttonDelete.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectionMode == SelectionMode.One)
            {
                int n = listBox1.SelectedIndex;
                if (n == -1)
                {
                    MessageBox.Show("Список пуст или \r\nнет выделенного элемента!");
                    return;
                }
                listBox1.Items.RemoveAt(n);
            }
            else
            {
                var l = listBox1.SelectedItems;
                if (l.Count > 0)
                {
                    newLines = newLines.Where(x => !l.Contains(x)).ToArray();
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(newLines);
                }
                else
                {
                    MessageBox.Show("Список пуст или \r\nнет выделенного элементов!");
                    return;
                }
            }
        }

        private void buttonSelection_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectionMode == SelectionMode.One)
            {
                listBox1.SelectionMode = SelectionMode.MultiExtended;
                buttonSelection.Text = "Выключить функцию выбора нескольких элементов";
            }
            else
            {
                listBox1.SelectionMode = SelectionMode.One;
                buttonSelection.Text = "Включить функцию выбора нескольких элементов";
            }
        }
    }
}