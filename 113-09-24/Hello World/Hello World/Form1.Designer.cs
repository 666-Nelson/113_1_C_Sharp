namespace Hello_World
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
            btn_DisplayMessage = new Button();
            SuspendLayout();
            // 
            // btn_DisplayMessage
            // 
            btn_DisplayMessage.BackColor = Color.Cyan;
            btn_DisplayMessage.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btn_DisplayMessage.ForeColor = Color.FromArgb(255, 128, 128);
            btn_DisplayMessage.Location = new Point(197, 113);
            btn_DisplayMessage.Name = "btn_DisplayMessage";
            btn_DisplayMessage.Size = new Size(351, 145);
            btn_DisplayMessage.TabIndex = 0;
            btn_DisplayMessage.Text = "顯示訊息";
            btn_DisplayMessage.UseVisualStyleBackColor = false;
            btn_DisplayMessage.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 420);
            Controls.Add(btn_DisplayMessage);
            Name = "Form1";
            Text = "Surprise!";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_DisplayMessage;
    }
}
