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
            private int[] calories = { 105, 95, 62, 85 }; // 香蕉、蘋果、橙子、梨子的卡路里數
            private bool[] isSelected = new bool[4]; // 追蹤是否選擇
            private int totalCalories = 0;
            private Label calorieLabel;
            private Button resetButton;

            public CalorieCounterForm()
            {
                // 初始化 PictureBox 和 Label
                calorieLabel = new Label { Text = "總卡路里：0", Location = new System.Drawing.Point(20, 180) };
                resetButton = new Button { Text = "重設", Location = new System.Drawing.Point(20, 220) };
                resetButton.Click += ResetButton_Click;

                for (int i = 0; i < 4; i++)
                {
                    pictureBoxes[i] = new PictureBox
                    {
                        Size = new System.Drawing.Size(100, 100),
                        Location = new System.Drawing.Point(20 + i * 110, 20),
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    // 添加圖片（假設圖片放置在適當位置）
                    pictureBoxes[i].ImageLocation = $"fruit{i}.jpg"; // 替換成你實際的圖片名稱
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
                calorieLabel.Text = $"總卡路里：{totalCalories}";
            }

            private void ResetButton_Click(object sender, EventArgs e)
            {
                totalCalories = 0;
                for (int i = 0; i < isSelected.Length; i++)
                {
                    isSelected[i] = false;
                }
                calorieLabel.Text = "總卡路里：0";
            }
        }
    }
}
