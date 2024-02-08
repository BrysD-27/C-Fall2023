namespace Davis_FinalProject
{
    partial class LoginScreen
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
            loginBtn = new Button();
            label1 = new Label();
            usernameTextbox = new TextBox();
            label2 = new Label();
            passwordTxtbox = new TextBox();
            cancelBtn = new Button();
            registerBtn = new Button();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(180, 89);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(90, 22);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(165, 23);
            usernameTextbox.TabIndex = 2;
            usernameTextbox.Tag = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 63);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // passwordTxtbox
            // 
            passwordTxtbox.Location = new Point(90, 60);
            passwordTxtbox.Name = "passwordTxtbox";
            passwordTxtbox.Size = new Size(165, 23);
            passwordTxtbox.TabIndex = 4;
            passwordTxtbox.Tag = "Password";
            passwordTxtbox.KeyDown += passwordTxtbox_KeyDown;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(90, 89);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(90, 122);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(165, 23);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 157);
            Controls.Add(registerBtn);
            Controls.Add(cancelBtn);
            Controls.Add(passwordTxtbox);
            Controls.Add(label2);
            Controls.Add(usernameTextbox);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Name = "LoginScreen";
            Text = "Login";
            FormClosing += LoginScreen_FormClosing;
            Load += LoginScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Label label1;
        private TextBox usernameTextbox;
        private Label label2;
        private TextBox passwordTxtbox;
        private Button cancelBtn;
        private Button registerBtn;
    }
}