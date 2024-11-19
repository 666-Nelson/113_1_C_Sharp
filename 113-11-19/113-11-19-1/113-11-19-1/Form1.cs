namespace _113_11_19_1
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
        public class CalorieCounterForm : Form
        {
            private PictureBox[] pictureBoxes = new PictureBox[4];
            private int[] calories = { 105, 95, 62, 85 }; // �����Bī�G�B��l�B���l���d������
            private bool[] isSelected = new bool[4]; // �l�ܬO�_���
            private int totalCalories = 0;
            private Label calorieLabel;
            private Button resetButton;

            public CalorieCounterForm()
            {
                // ��l�� PictureBox �M Label
                calorieLabel = new Label { Text = "�`�d�����G0", Location = new System.Drawing.Point(20, 180) };
                resetButton = new Button { Text = "���]", Location = new System.Drawing.Point(20, 220) };
                resetButton.Click += ResetButton_Click;

                for (int i = 0; i < 4; i++)
                {
                    pictureBoxes[i] = new PictureBox
                    {
                        Size = new System.Drawing.Size(100, 100),
                        Location = new System.Drawing.Point(20 + i * 110, 20),
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    // �K�[�Ϥ��]���]�Ϥ���m�b�A���m�^
                    pictureBoxes[i].ImageLocation = $"fruit{i}.jpg"; // �������A��ڪ��Ϥ��W��
                    pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxes[i].Click += (sender, e) => PictureBox_Click(sender, e, i);
                    Controls.Add(pictureBoxes[i]);
                }

                Controls.Add(calorieLabel);
                Controls.Add(resetButton);
            }

            private void PictureBox_Click(object sender, EventArgs e, int index)
            {
                if (isSelected[index])
                {
                    totalCalories -= calories[index];
                }
                else
                {
                    totalCalories += calories[index];
                }
                isSelected[index] = !isSelected[index];
                calorieLabel.Text = $"�`�d�����G{totalCalories}";
            }

            private void ResetButton_Click(object sender, EventArgs e)
            {
                totalCalories = 0;
                for (int i = 0; i < isSelected.Length; i++)
                {
                    isSelected[i] = false;
                }
                calorieLabel.Text = "�`�d�����G0";
            }
        }
    }
}
