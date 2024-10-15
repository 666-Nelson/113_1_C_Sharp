namespace _113_10_15_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtdayofweek = new TextBox();
            txtdest = new TextBox();
            txtmonth = new TextBox();
            txtyear = new TextBox();
            lblshow = new Label();
            btnshowdate = new Button();
            btnclean = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(66, 38);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(66, 142);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(66, 249);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 24F);
            label4.Location = new Point(66, 367);
            label4.Name = "label4";
            label4.Size = new Size(82, 41);
            label4.TabIndex = 3;
            label4.Text = "年份";
            // 
            // txtdayofweek
            // 
            txtdayofweek.Location = new Point(228, 38);
            txtdayofweek.Name = "txtdayofweek";
            txtdayofweek.Size = new Size(193, 23);
            txtdayofweek.TabIndex = 4;
            // 
            // txtdest
            // 
            txtdest.Location = new Point(228, 142);
            txtdest.Name = "txtdest";
            txtdest.Size = new Size(193, 23);
            txtdest.TabIndex = 5;
            // 
            // txtmonth
            // 
            txtmonth.Location = new Point(228, 249);
            txtmonth.Name = "txtmonth";
            txtmonth.Size = new Size(193, 23);
            txtmonth.TabIndex = 6;
            // 
            // txtyear
            // 
            txtyear.Location = new Point(228, 367);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(193, 23);
            txtyear.TabIndex = 7;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Location = new Point(66, 426);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(626, 66);
            lblshow.TabIndex = 8;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnshowdate
            // 
            btnshowdate.Location = new Point(60, 529);
            btnshowdate.Name = "btnshowdate";
            btnshowdate.Size = new Size(162, 46);
            btnshowdate.TabIndex = 9;
            btnshowdate.Text = "顯示完整日期";
            btnshowdate.UseVisualStyleBackColor = true;
            btnshowdate.Click += btnshowdate_Click;
            // 
            // btnclean
            // 
            btnclean.Location = new Point(294, 529);
            btnclean.Name = "btnclean";
            btnclean.Size = new Size(162, 46);
            btnclean.TabIndex = 10;
            btnclean.Text = "清空內容";
            btnclean.UseVisualStyleBackColor = true;
            btnclean.Click += btnclean_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(541, 529);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(162, 46);
            btnexit.TabIndex = 11;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 714);
            Controls.Add(btnexit);
            Controls.Add(btnclean);
            Controls.Add(btnshowdate);
            Controls.Add(lblshow);
            Controls.Add(txtyear);
            Controls.Add(txtmonth);
            Controls.Add(txtdest);
            Controls.Add(txtdayofweek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtdayofweek;
        private TextBox txtdest;
        private TextBox txtmonth;
        private TextBox txtyear;
        private Label lblshow;
        private Button btnshowdate;
        private Button btnclean;
        private Button btnexit;
    }
}
