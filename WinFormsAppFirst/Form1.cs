namespace WinFormsAppFirst
{
    public partial class Form1 : Form
    {
        Point startPoint;
        Point endPoint;
        public Form1()
        {
            InitializeComponent();
            MouseUp += Form1_MouseUp;
            MouseDown += Form1_MouseDown;
            MouseDoubleClick += label1_Click2;
        }

        private void label1_Click2(object sender, EventArgs e)
        {
            label1.Text = null;

        }

        private void label1_Click1(object sender, EventArgs e)
        {
            int dx = endPoint.X - startPoint.X;
            int dy = endPoint.Y - startPoint.Y;
            label1.Text = $"startPointX:{startPoint.X}\nstartPointY:{startPoint.Y}\nendPointX:{endPoint.X}\nendPointY:{endPoint.Y}\nSahe:{Math.Abs(dx) * Math.Abs(dy)}";
        }


        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void Form1_MouseUp(object? sender, MouseEventArgs e)
        {
            endPoint = e.Location;
            int dx = endPoint.X - startPoint.X;
            int dy = endPoint.Y - startPoint.Y;
            if (Math.Abs(dx) <= 10 && Math.Abs(dy) <= 10)
            {
                label1.AutoSize = false;
                label1.Location = new Point(startPoint.X, startPoint.Y);
                label1.Name = "label1";
                label1.Size = new Size(100, 100);
                label1.TabIndex = 0;
                label1.Text = "Size is lower than 10 !";

            }
            else if (endPoint.X > startPoint.X && endPoint.Y > startPoint.Y)
            {
                label1.AutoSize = false;
                label1.Location = new Point(startPoint.X, startPoint.Y);
                label1.Name = "label1";
                label1.Size = new Size(dy, dx);
                label1.TabIndex = 0;
                label1.Text = null;

            }
            else if (endPoint.X < startPoint.X && endPoint.Y > startPoint.Y)
            {
                label1.AutoSize = false;
                label1.Location = new Point(endPoint.X, startPoint.Y);
                label1.Name = "label1";
                label1.Size = new Size(Math.Abs(dx), dy);
                label1.TabIndex = 0;
                label1.Text = null;

            }
            else if (endPoint.X < startPoint.X && startPoint.Y > endPoint.Y)
            {
                label1.AutoSize = false;
                label1.Location = new Point(endPoint.X, endPoint.Y);
                label1.Name = "label1";
                label1.Size = new Size(Math.Abs(dx), Math.Abs(dy));
                label1.TabIndex = 0;
                label1.Text = null;

            }
            else if (endPoint.X > startPoint.X && startPoint.Y > endPoint.Y)
            {
                label1.AutoSize = false;
                label1.Location = new Point(startPoint.X, endPoint.Y);
                label1.Name = "label1";
                label1.Size = new Size(Math.Abs(dx), Math.Abs(dy));
                label1.TabIndex = 0;
                label1.Text = null;

            }
        }


    }
}
