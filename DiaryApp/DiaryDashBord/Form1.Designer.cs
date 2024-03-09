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
            dateTimePicker1 = new DateTimePicker();
            Comment_Box = new TextBox();
            Save_btn_Comment = new Button();
            Search_btn_Comment = new Button();
            label1 = new Label();
            title_box = new TextBox();
            label2 = new Label();
            date_Box = new TextBox();
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
            textBox1.Location = new Point(676, 405);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(92, 33);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(568, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Comment_Box
            // 
            Comment_Box.BackColor = SystemColors.Info;
            Comment_Box.Location = new Point(31, 128);
            Comment_Box.Multiline = true;
            Comment_Box.Name = "Comment_Box";
            Comment_Box.PlaceholderText = "Hur var den dag";
            Comment_Box.Size = new Size(452, 310);
            Comment_Box.TabIndex = 3;
            // 
            // Save_btn_Comment
            // 
            Save_btn_Comment.Location = new Point(592, 118);
            Save_btn_Comment.Name = "Save_btn_Comment";
            Save_btn_Comment.Size = new Size(88, 40);
            Save_btn_Comment.TabIndex = 4;
            Save_btn_Comment.Text = "Spara";
            Save_btn_Comment.UseVisualStyleBackColor = true;
            Save_btn_Comment.Click += Save_btn_Comment_Click;
            // 
            // Search_btn_Comment
            // 
            Search_btn_Comment.Location = new Point(592, 189);
            Search_btn_Comment.Name = "Search_btn_Comment";
            Search_btn_Comment.Size = new Size(88, 40);
            Search_btn_Comment.TabIndex = 5;
            Search_btn_Comment.Text = "Sök";
            Search_btn_Comment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 7;
            label1.Text = "Titel";
            // 
            // title_box
            // 
            title_box.Location = new Point(100, 36);
            title_box.Name = "title_box";
            title_box.PlaceholderText = "Title";
            title_box.Size = new Size(113, 23);
            title_box.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 90);
            label2.Name = "label2";
            label2.Size = new Size(109, 17);
            label2.TabIndex = 9;
            label2.Text = "Hur vad din dag ?";
            // 
            // date_Box
            // 
            date_Box.Location = new Point(605, 363);
            date_Box.Multiline = true;
            date_Box.Name = "date_Box";
            date_Box.Size = new Size(163, 36);
            date_Box.TabIndex = 10;
            // 
            // Dashbord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(date_Box);
            Controls.Add(label2);
            Controls.Add(title_box);
            Controls.Add(label1);
            Controls.Add(Search_btn_Comment);
            Controls.Add(Save_btn_Comment);
            Controls.Add(Comment_Box);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(Show_username);
            Name = "Dashbord";
            Text = "Dashbord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Show_username;
        public TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox Comment_Box;
        private Button Save_btn_Comment;
        private Button Search_btn_Comment;
        private Label label1;
        private TextBox title_box;
        private Label label2;
        private TextBox date_Box;
    }
}
