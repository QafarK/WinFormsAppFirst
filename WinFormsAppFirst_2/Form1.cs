namespace WinFormsAppFirst_2
{
    public partial class Form1 : Form
    {
        Point point_label1;
        public Form1()
        {
            InitializeComponent();

            MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Location.X > label1.Location.X-100 && label1.Location.X < e.Location.X + 100 && e.Location.Y > label1.Location.Y - 100 && label1.Location.Y < e.Location.Y + 100)
            {
                Thread.Sleep(500);
                point_label1.X = Random.Shared.Next(0, 700);
                point_label1.Y = Random.Shared.Next(0, 350);
                label1.Location = point_label1;
            }
        }
    }
}
