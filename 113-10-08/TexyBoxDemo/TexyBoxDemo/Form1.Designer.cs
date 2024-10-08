namespace TexyBoxDemo
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
            btnConfirm = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblshow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(68, 56);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(71, 163);
            label2.Name = "label2";
            label2.Size = new Size(186, 41);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(80, 266);
            label3.Name = "label3";
            label3.Size = new Size(177, 41);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Microsoft JhengHei UI", 20F);
            btnConfirm.Location = new Point(136, 344);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(285, 88);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft JhengHei UI", 24F);
            txtFirstName.Location = new Point(290, 51);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(186, 48);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft JhengHei UI", 24F);
            txtLastName.Location = new Point(290, 160);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(186, 48);
            txtLastName.TabIndex = 5;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 24F);
            lblshow.Location = new Point(287, 258);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(189, 60);
            lblshow.TabIndex = 6;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
            Controls.Add(lblshow);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnConfirm);
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
        private Button btnConfirm;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblshow;
    }
}
