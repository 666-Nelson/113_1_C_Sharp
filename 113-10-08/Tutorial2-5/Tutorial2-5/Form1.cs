/*----------------------------------------
 班級:資管一甲
 姓名:張旂笙
---------------------------------*/
namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //顯示撲克牌背面
        private void btnshowback_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true; //設定visible屬性為假
            ptxfront.Visible = false;

        }

        private void ptxfront_Click(object sender, EventArgs e)
        {

        }
        //顯示撲克牌正面
        private void btnshowfront_Click(object sender, EventArgs e)
        {
            ptxback.Visible = false;
            ptxfront.Visible = true;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
