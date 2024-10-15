namespace _113_10_15_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            string output;

            output = "民國" + txtyear.Text + "年" + txtmonth.Text + "月" + txtdest.Text + "星期" + txtdayofweek.Text;

            lblshow.Text = output;
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtdayofweek.Text = "";
            txtdest.Text = "";
            txtmonth.Text = "";
            txtyear.Text = "";
            lblshow.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
