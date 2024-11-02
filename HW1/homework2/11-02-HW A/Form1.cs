namespace _11_02_HW_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double seatA;
            double seatB;
            double seatC;
            double priceA;
            double priceB;
            double priceC;
            double Total;

            priceA = double.Parse(txtpriceA.Text);
            priceB = double.Parse(txtpriceB.Text);
            priceC = double.Parse(txtpriceC.Text);

            seatA = double.Parse(txtseatA.Text);
            seatB = double.Parse(txtseatB.Text);
            seatC = double.Parse(txtseatC.Text);

            Total = priceA * seatA + priceB * seatB + priceC * seatC;

            lbltotal.Text = Total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpriceA.Text = "";
            txtpriceB.Text = "";
            txtpriceC.Text = "";
            txtseatA.Text = "";
            txtseatB.Text = "";
            txtseatC.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtpriceA.Text = "";
            txtpriceB.Text = "";
            txtpriceC.Text = "";
            txtseatA.Text = "";
            txtseatB.Text = "";
            txtseatC.Text = "";
            lbltotal.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
