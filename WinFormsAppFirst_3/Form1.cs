namespace WinFormsAppFirst_3
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
            num = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled && num == 0)
            {
                pictureBox1.Image = Properties.Resources._360_F_231148604_0hQFi09fYKlV0J7jnBVCIFR8sTCOI3J9;
                label1.Text = DateTime.Now.ToString();
                num = 1;
            }
            else if (button1.Enabled && num == 1)
            {
                pictureBox1.Image = Properties.Resources.istockphoto_1294454411_612x612;
                label1.Text = DateTime.Now.AddHours(-3).ToString();
                num = 0;
            }

        }
    }
}
