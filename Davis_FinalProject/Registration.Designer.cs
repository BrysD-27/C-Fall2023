namespace Davis_FinalProject
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            loginDetailsGroupBox = new GroupBox();
            usernameTxtbox = new TextBox();
            passwordTxtbox = new TextBox();
            confirmPwdTxtbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            personalDetailsGroupBox = new GroupBox();
            titleCombobox = new ComboBox();
            femaleRadioBtn = new RadioButton();
            maleRadioBtn = new RadioButton();
            dobDatePicker = new DateTimePicker();
            firstNameTxtbox = new TextBox();
            label7 = new Label();
            lastNameTxtbox = new TextBox();
            initialsTxtBox = new TextBox();
            identityNumTxtbox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            loginBtn = new Button();
            cancelBtn = new Button();
            loginDetailsGroupBox.SuspendLayout();
            personalDetailsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(362, 20);
            label1.TabIndex = 0;
            label1.Text = "Please enter all of the following details to register:";
            // 
            // loginDetailsGroupBox
            // 
            loginDetailsGroupBox.Controls.Add(usernameTxtbox);
            loginDetailsGroupBox.Controls.Add(passwordTxtbox);
            loginDetailsGroupBox.Controls.Add(confirmPwdTxtbox);
            loginDetailsGroupBox.Controls.Add(label4);
            loginDetailsGroupBox.Controls.Add(label3);
            loginDetailsGroupBox.Controls.Add(label2);
            loginDetailsGroupBox.Location = new Point(12, 33);
            loginDetailsGroupBox.Name = "loginDetailsGroupBox";
            loginDetailsGroupBox.Size = new Size(395, 143);
            loginDetailsGroupBox.TabIndex = 1;
            loginDetailsGroupBox.TabStop = false;
            loginDetailsGroupBox.Text = "Login Details";
            // 
            // usernameTxtbox
            // 
            usernameTxtbox.Location = new Point(127, 25);
            usernameTxtbox.Name = "usernameTxtbox";
            usernameTxtbox.Size = new Size(188, 23);
            usernameTxtbox.TabIndex = 0;
            usernameTxtbox.Tag = "Username";
            // 
            // passwordTxtbox
            // 
            passwordTxtbox.Location = new Point(127, 66);
            passwordTxtbox.Name = "passwordTxtbox";
            passwordTxtbox.Size = new Size(188, 23);
            passwordTxtbox.TabIndex = 1;
            passwordTxtbox.Tag = "Password";
            // 
            // confirmPwdTxtbox
            // 
            confirmPwdTxtbox.Location = new Point(127, 107);
            confirmPwdTxtbox.Name = "confirmPwdTxtbox";
            confirmPwdTxtbox.Size = new Size(188, 23);
            confirmPwdTxtbox.TabIndex = 2;
            confirmPwdTxtbox.Tag = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 69);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 110);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 28);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // personalDetailsGroupBox
            // 
            personalDetailsGroupBox.Controls.Add(titleCombobox);
            personalDetailsGroupBox.Controls.Add(femaleRadioBtn);
            personalDetailsGroupBox.Controls.Add(maleRadioBtn);
            personalDetailsGroupBox.Controls.Add(dobDatePicker);
            personalDetailsGroupBox.Controls.Add(firstNameTxtbox);
            personalDetailsGroupBox.Controls.Add(label7);
            personalDetailsGroupBox.Controls.Add(lastNameTxtbox);
            personalDetailsGroupBox.Controls.Add(initialsTxtBox);
            personalDetailsGroupBox.Controls.Add(identityNumTxtbox);
            personalDetailsGroupBox.Controls.Add(label11);
            personalDetailsGroupBox.Controls.Add(label10);
            personalDetailsGroupBox.Controls.Add(label9);
            personalDetailsGroupBox.Controls.Add(label8);
            personalDetailsGroupBox.Controls.Add(label6);
            personalDetailsGroupBox.Controls.Add(label5);
            personalDetailsGroupBox.Location = new Point(12, 182);
            personalDetailsGroupBox.Name = "personalDetailsGroupBox";
            personalDetailsGroupBox.Size = new Size(396, 227);
            personalDetailsGroupBox.TabIndex = 7;
            personalDetailsGroupBox.TabStop = false;
            personalDetailsGroupBox.Text = "Personal Details";
            // 
            // titleCombobox
            // 
            titleCombobox.FormattingEnabled = true;
            titleCombobox.Location = new Point(107, 62);
            titleCombobox.Name = "titleCombobox";
            titleCombobox.Size = new Size(80, 23);
            titleCombobox.TabIndex = 4;
            titleCombobox.Tag = "Title";
            // 
            // femaleRadioBtn
            // 
            femaleRadioBtn.AutoSize = true;
            femaleRadioBtn.Location = new Point(175, 194);
            femaleRadioBtn.Name = "femaleRadioBtn";
            femaleRadioBtn.Size = new Size(63, 19);
            femaleRadioBtn.TabIndex = 10;
            femaleRadioBtn.TabStop = true;
            femaleRadioBtn.Tag = "Female";
            femaleRadioBtn.Text = "Female";
            femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // maleRadioBtn
            // 
            maleRadioBtn.AutoSize = true;
            maleRadioBtn.Location = new Point(107, 194);
            maleRadioBtn.Name = "maleRadioBtn";
            maleRadioBtn.Size = new Size(51, 19);
            maleRadioBtn.TabIndex = 9;
            maleRadioBtn.TabStop = true;
            maleRadioBtn.Tag = "Male";
            maleRadioBtn.Text = "Male";
            maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // dobDatePicker
            // 
            dobDatePicker.Location = new Point(107, 157);
            dobDatePicker.Name = "dobDatePicker";
            dobDatePicker.Size = new Size(255, 23);
            dobDatePicker.TabIndex = 8;
            dobDatePicker.Tag = "Date of Birth";
            // 
            // firstNameTxtbox
            // 
            firstNameTxtbox.Location = new Point(107, 129);
            firstNameTxtbox.Name = "firstNameTxtbox";
            firstNameTxtbox.Size = new Size(255, 23);
            firstNameTxtbox.TabIndex = 7;
            firstNameTxtbox.Tag = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(193, 65);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 2;
            label7.Text = "Initials";
            // 
            // lastNameTxtbox
            // 
            lastNameTxtbox.Location = new Point(107, 101);
            lastNameTxtbox.Name = "lastNameTxtbox";
            lastNameTxtbox.Size = new Size(255, 23);
            lastNameTxtbox.TabIndex = 6;
            lastNameTxtbox.Tag = "Last Name";
            // 
            // initialsTxtBox
            // 
            initialsTxtBox.Location = new Point(240, 62);
            initialsTxtBox.Name = "initialsTxtBox";
            initialsTxtBox.Size = new Size(122, 23);
            initialsTxtBox.TabIndex = 5;
            initialsTxtBox.Tag = "Initials";
            // 
            // identityNumTxtbox
            // 
            identityNumTxtbox.Location = new Point(107, 25);
            identityNumTxtbox.Name = "identityNumTxtbox";
            identityNumTxtbox.Size = new Size(255, 23);
            identityNumTxtbox.TabIndex = 3;
            identityNumTxtbox.Tag = "Identity Number";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 196);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 6;
            label11.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 163);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 5;
            label10.Text = "Date of Birth";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 132);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 4;
            label9.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 104);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 3;
            label8.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 65);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 1;
            label6.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 28);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 0;
            label5.Text = "Identity Number";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(333, 415);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 11;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(252, 415);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 12;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 450);
            Controls.Add(cancelBtn);
            Controls.Add(loginBtn);
            Controls.Add(personalDetailsGroupBox);
            Controls.Add(loginDetailsGroupBox);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Registration";
            FormClosed += Registration_FormClosed;
            Load += Registration_Load;
            loginDetailsGroupBox.ResumeLayout(false);
            loginDetailsGroupBox.PerformLayout();
            personalDetailsGroupBox.ResumeLayout(false);
            personalDetailsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox loginDetailsGroupBox;
        private TextBox usernameTxtbox;
        private TextBox passwordTxtbox;
        private TextBox confirmPwdTxtbox;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox personalDetailsGroupBox;
        private TextBox initialsTxtBox;
        private TextBox identityNumTxtbox;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private RadioButton femaleRadioBtn;
        private RadioButton maleRadioBtn;
        private DateTimePicker dobDatePicker;
        private TextBox firstNameTxtbox;
        private TextBox lastNameTxtbox;
        private Button loginBtn;
        private Button cancelBtn;
        private ComboBox titleCombobox;
    }
}