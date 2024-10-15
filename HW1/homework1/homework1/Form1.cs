namespace homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lblshow.Text = "愛心10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblshow.Text = "大老二";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblshow.Text = "梅花三";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblshow.Text = "愛心A";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblshow.Text = "啊哈有小丑";
        }
    }
