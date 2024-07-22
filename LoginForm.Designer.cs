namespace StatesCapitalsQuiz
{
    partial class LoginForm
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
            txt_username = new TextBox();
            lbl_username = new Label();
            txt_password = new TextBox();
            lbl_password = new Label();
            BtnLogin = new Button();
            BtnClear = new Button();
            BtnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 29);
            label1.Name = "label1";
            label1.Size = new Size(197, 54);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(182, 137);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(315, 31);
            txt_username.TabIndex = 1;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(55, 137);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(91, 25);
            lbl_username.TabIndex = 2;
            lbl_username.Text = "Username";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(182, 214);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(315, 31);
            txt_password.TabIndex = 3;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(59, 203);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(87, 25);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Password";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(385, 312);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(112, 34);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(182, 312);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(112, 34);
            BtnClear.TabIndex = 6;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(59, 400);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(112, 34);
            BtnExit.TabIndex = 7;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 468);
            Controls.Add(BtnExit);
            Controls.Add(BtnClear);
            Controls.Add(BtnLogin);
            Controls.Add(lbl_password);
            Controls.Add(txt_password);
            Controls.Add(lbl_username);
            Controls.Add(txt_username);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "States and Capitals Quiz";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_username;
        private Label lbl_username;
        private TextBox txt_password;
        private Label lbl_password;
        private Button BtnLogin;
        private Button BtnClear;
        private Button BtnExit;
    }
}
