namespace SignInFormDiary
{
    partial class Sign_Up
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
            components = new System.ComponentModel.Container();
            User_Name = new Label();
            user_name_in = new TextBox();
            password_in = new TextBox();
            Password_lab = new Label();
            Sign_up_btn = new Button();
            Error_name = new Label();
            btn_Login = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // User_Name
            // 
            User_Name.AutoSize = true;
            User_Name.Font = new Font("Roboto Slab", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_Name.Location = new Point(260, 136);
            User_Name.Name = "User_Name";
            User_Name.Size = new Size(111, 25);
            User_Name.TabIndex = 0;
            User_Name.Text = "User Name";
            // 
            // user_name_in
            // 
            user_name_in.Location = new Point(400, 136);
            user_name_in.Multiline = true;
            user_name_in.Name = "user_name_in";
            user_name_in.Size = new Size(164, 25);
            user_name_in.TabIndex = 1;
            user_name_in.Text = "Your name";
            user_name_in.TextChanged += textBox1_TextChanged;
            // 
            // password_in
            // 
            password_in.Location = new Point(400, 212);
            password_in.MaxLength = 14;
            password_in.Multiline = true;
            password_in.Name = "password_in";
            password_in.PasswordChar = '*';
            password_in.Size = new Size(164, 38);
            password_in.TabIndex = 2;
            password_in.TextChanged += password_TextChanged;
            // 
            // Password_lab
            // 
            Password_lab.AutoSize = true;
            Password_lab.Font = new Font("Roboto Slab", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_lab.Location = new Point(271, 225);
            Password_lab.Name = "Password_lab";
            Password_lab.Size = new Size(100, 25);
            Password_lab.TabIndex = 3;
            Password_lab.Text = "Password";
            // 
            // Sign_up_btn
            // 
            Sign_up_btn.Location = new Point(400, 301);
            Sign_up_btn.Name = "Sign_up_btn";
            Sign_up_btn.Size = new Size(158, 58);
            Sign_up_btn.TabIndex = 4;
            Sign_up_btn.Text = "Sign Up";
            Sign_up_btn.UseVisualStyleBackColor = true;
            Sign_up_btn.Click += Sign_up_btn_Click;
            // 
            // Error_name
            // 
            Error_name.AutoSize = true;
            Error_name.Location = new Point(407, 167);
            Error_name.Name = "Error_name";
            Error_name.Size = new Size(131, 15);
            Error_name.TabIndex = 5;
            Error_name.Text = "Not available username";
            Error_name.Visible = false;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(400, 365);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(158, 62);
            btn_Login.TabIndex = 6;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Login);
            Controls.Add(Error_name);
            Controls.Add(Sign_up_btn);
            Controls.Add(Password_lab);
            Controls.Add(password_in);
            Controls.Add(user_name_in);
            Controls.Add(User_Name);
            Name = "Sign_Up";
            Text = "SignUp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label User_Name;
        private TextBox user_name_in;
        private TextBox password_in;
        private Label Password_lab;
        private Button Sign_up_btn;
        private Label Error_name;
        private Button btn_Login;
        private ErrorProvider errorProvider1;
    }
}
