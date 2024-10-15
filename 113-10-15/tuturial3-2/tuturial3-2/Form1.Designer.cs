namespace tuturial3_2
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
            txbKM = new TextBox();
            txbLiter = new TextBox();
            lblshow = new Label();
            btnCaulate = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(64, 39);
            label1.Name = "label1";
            label1.Size = new Size(165, 39);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 20F);
            label2.Location = new Point(64, 131);
            label2.Name = "label2";
            label2.Size = new Size(165, 39);
            label2.TabIndex = 1;
            label2.Text = "使用油耗";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 20F);
            label3.Location = new Point(64, 222);
            label3.Name = "label3";
            label3.Size = new Size(165, 39);
            label3.TabIndex = 2;
            label3.Text = "每公升/公里";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbKM
            // 
            txbKM.Font = new Font("Microsoft JhengHei UI", 20F);
            txbKM.Location = new Point(288, 37);
            txbKM.Name = "txbKM";
            txbKM.Size = new Size(221, 41);
            txbKM.TabIndex = 9;
            // 
            // txbLiter
            // 
            txbLiter.Font = new Font("Microsoft JhengHei UI", 20F);
            txbLiter.Location = new Point(288, 129);
            txbLiter.Name = "txbLiter";
            txbLiter.Size = new Size(221, 41);
            txbLiter.TabIndex = 10;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 20F);
            lblshow.Location = new Point(288, 231);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(221, 39);
            lblshow.TabIndex = 11;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCaulate
            // 
            btnCaulate.Location = new Point(109, 315);
            btnCaulate.Name = "btnCaulate";
            btnCaulate.Size = new Size(156, 62);
            btnCaulate.TabIndex = 12;
            btnCaulate.Text = "計算";
            btnCaulate.UseVisualStyleBackColor = true;
            btnCaulate.Click += btnCaulate_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(338, 315);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(156, 62);
            btnexit.TabIndex = 13;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnexit);
            Controls.Add(btnCaulate);
            Controls.Add(lblshow);
            Controls.Add(txbLiter);
            Controls.Add(txbKM);
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
        private TextBox txbKM;
        private TextBox txbLiter;
        private Label lblshow;
        private Button btnCaulate;
        private Button btnexit;
    }
}
