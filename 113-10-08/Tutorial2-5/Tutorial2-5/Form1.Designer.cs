namespace Tutorial2_5
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
            ptxback = new PictureBox();
            ptxfront = new PictureBox();
            btnshowback = new Button();
            btnshowfront = new Button();
            btnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).BeginInit();
            SuspendLayout();
            // 
            // ptxback
            // 
            ptxback.Image = Properties.Resources.Backface_Blue;
            ptxback.Location = new Point(56, 70);
            ptxback.Name = "ptxback";
            ptxback.Size = new Size(166, 244);
            ptxback.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxback.TabIndex = 0;
            ptxback.TabStop = false;
            ptxback.Visible = false;
            // 
            // ptxfront
            // 
            ptxfront.Image = Properties.Resources.Ace_Spades;
            ptxfront.Location = new Point(270, 70);
            ptxfront.Name = "ptxfront";
            ptxfront.Size = new Size(166, 244);
            ptxfront.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxfront.TabIndex = 1;
            ptxfront.TabStop = false;
            ptxfront.Visible = false;
            ptxfront.Click += ptxfront_Click;
            // 
            // btnshowback
            // 
            btnshowback.Location = new Point(65, 347);
            btnshowback.Name = "btnshowback";
            btnshowback.Size = new Size(145, 70);
            btnshowback.TabIndex = 2;
            btnshowback.Text = "背面";
            btnshowback.UseVisualStyleBackColor = true;
            btnshowback.Click += btnshowback_Click;
            // 
            // btnshowfront
            // 
            btnshowfront.Location = new Point(279, 347);
            btnshowfront.Name = "btnshowfront";
            btnshowfront.Size = new Size(145, 70);
            btnshowfront.TabIndex = 3;
            btnshowfront.Text = "正面";
            btnshowfront.UseVisualStyleBackColor = true;
            btnshowfront.Click += btnshowfront_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(144, 482);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(192, 70);
            btnexit.TabIndex = 4;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 643);
            Controls.Add(btnexit);
            Controls.Add(btnshowfront);
            Controls.Add(btnshowback);
            Controls.Add(ptxfront);
            Controls.Add(ptxback);
            Font = new Font("Microsoft JhengHei UI", 9F);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxback).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxback;
        private PictureBox ptxfront;
        private Button btnshowback;
        private Button btnshowfront;
        private Button btnexit;
    }
}
