/*----------------------------------------
 �Z��:��ޤ@��
 �m�W:�i�Ҳ�
---------------------------------*/
namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��ܼ��J�P�I��
        private void btnshowback_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true; //�]�wvisible�ݩʬ���
            ptxfront.Visible = false;

        }

        private void ptxfront_Click(object sender, EventArgs e)
        {

        }
        //��ܼ��J�P����
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
