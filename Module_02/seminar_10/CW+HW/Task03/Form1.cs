namespace Task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Size size;
            if (button.Text == "��������� �����")
                size = new Size(this.Size.Width + 30, this.Size.Height + 30);
            else
                size = new Size(this.Size.Width - 30, this.Size.Height - 30);

            if (size.Width > this.MaximumSize.Width || size.Height > this.MaximumSize.Height)
            {
                button.Text = "��������� �����";
                MessageBox.Show("maxlimit");
            }
            else if (size.Width < this.MinimumSize.Width || size.Height < this.MinimumSize.Height)
            {
                button.Text = "��������� �����";
                MessageBox.Show("minlimit");
            }
            else
            {
                this.Size = size;
            }
        }
    }
}