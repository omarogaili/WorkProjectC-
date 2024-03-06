namespace DiaryDashBord
{
    partial class Dashbord
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
            Show_username = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Show_username
            // 
            Show_username.AutoSize = true;
            Show_username.Location = new Point(31, 30);
            Show_username.Name = "Show_username";
            Show_username.Size = new Size(0, 15);
            Show_username.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(140, 33);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Dashbord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Show_username);
            Name = "Dashbord";
            Text = "Dashbord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Show_username;
        private TextBox textBox1;
    }
}
