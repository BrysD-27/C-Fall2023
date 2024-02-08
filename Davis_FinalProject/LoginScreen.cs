
using Davis_FinalProject.Models.DataLayer;

namespace Davis_FinalProject
{
    public partial class LoginScreen : Form
    {
        private PCHRContext _context  = new PCHRContext();
        public LoginScreen()
        {
            InitializeComponent();
        }

        #region Form field methods
        // set controls
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = usernameTextbox;
            passwordTxtbox.UseSystemPasswordChar = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            login();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // take user to Registration form
        private void registerBtn_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Visible = false;
        }
        // UX for enter on password
        private void passwordTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.Focus();
                login();
            }
        }
        #endregion

        #region Helper methods
        // login method
        private void login(object? sender = null, EventArgs? e = null)
        {
            // validate 
            if (Validator.IsPresent(usernameTextbox) && Validator.IsPresent(passwordTxtbox))
            {
                if (!Validator.IsValidUser(usernameTextbox))
                {
                    MessageBox.Show("User not found, please try again!", "Entry Error");
                    usernameTextbox.Focus();
                }
                if (Validator.ValidateUser(usernameTextbox.Text, passwordTxtbox.Text))
                {
                    // if valid, show PHR form
                    PatientTbl? patient = _context.PatientTbls.FirstOrDefault(p => p.UserName == usernameTextbox.Text && p.Password ==  passwordTxtbox.Text);
                    MyPHR myPHR = new MyPHR(patient);
                    myPHR.Show();
                    this.Hide();
                    usernameTextbox.Clear();
                    passwordTxtbox.Clear();
                    patient = null;
                }
            }
        }
        #endregion

        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}