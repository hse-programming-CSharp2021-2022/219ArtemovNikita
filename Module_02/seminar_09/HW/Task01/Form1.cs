namespace Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoTask();
        }

        bool flag = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0 && flag)
                label1.Text = label1.Text[..^1];
            if (label1.Text.Length == 0 && flag)
            {
                disappear();
            }
            if (!flag)
            {
                this.Opacity += 0.1;
                if (this.Opacity >= 0.97)
                    timer1.Stop();
            }
        }

        private void disappear()
        {
            this.Opacity -= 0.1;
            if (this.Opacity <= 0)
            {
                label1.Text = "Кот уже ушел!";
                flag = false;
            }
        }

        private void DoTask()
        {
            label1.Text = "Чеширский кот";
            timer1.Interval = 500;
            timer1.Enabled = true;
            timer1.Start();
        }

       

        
    }
}