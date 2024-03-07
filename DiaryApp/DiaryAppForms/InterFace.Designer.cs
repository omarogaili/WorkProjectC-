namespace DiaryAppForms
{
    partial class Diary_IEN
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
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(332, 325);
            button1.Name = "button1";
            button1.Size = new Size(125, 39);
            button1.TabIndex = 0;
            button1.Text = "Börja Skriva";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 73);
            label1.Name = "label1";
            label1.Size = new Size(367, 35);
            label1.TabIndex = 1;
            label1.Text = "Välkommen Till Din Dagbok";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.retro_anteckningsbok_dagbok__pdp_zoom_3000;
            pictureBox1.Location = new Point(99, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(657, 435);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Diary_IEN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Diary_IEN";
            Text = "Diary IEN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
