namespace Task04
{
    public partial class Form1 : Form
    {
        int X, Y, W, H;

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Y = 270 - trackBar2.Value*30;
            Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            X = trackBar1.Value;
            Invalidate();
        }

        public Form1()
        {
            InitializeComponent();
            X = Y = 0;
            W = H = 100;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            trackBar1.Maximum = Width - W;
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDark), X, Y, W, H);
            TransparencyKey = SystemColors.ControlDark;
        }

        
    }
}