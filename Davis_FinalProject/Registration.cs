using Davis_FinalProject.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Davis_FinalProject
{
    public partial class Registration : Form
    {
        // class properties
        private PCHRContext context = new PCHRContext();
        private PatientTbl newPatient = new PatientTbl();
        private PerDetailsTbl newPerDetails = new PerDetailsTbl();
        private PrimaryCareTbl newPrimaryCare = new PrimaryCareTbl();
        private string[] titles =
        {
            "Mr",
            "Mrs",
            "Miss",
            "Ms"
        };
        public Registration()
        {
            InitializeComponent();
        }
        // set form controls
        private void Registration_Load(object? sender, EventArgs? e)
        {
            titleCombobox.Items.AddRange(titles);
            passwordTxtbox.UseSystemPasswordChar = true;
            confirmPwdTxtbox.UseSystemPasswordChar = true;
            maleRadioBtn.Checked = true;
        }

        #region Event Handlers
        // show login form when form is closed
        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["LoginScreen"]?.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // register new user method
        private void loginBtn_Click(object sender, EventArgs e)
        {
            // validate entries
            if (isvalid())
            {
                if (Validator.IsValidUser(usernameTxtbox))
                {
                    MessageBox.Show("Username already taken, please try again!", "Entry error");
                    return;
                }
                try
                {
                    // pass new patient properties to database, set known props for other tables related to patient
                    newPatient = new PatientTbl(
                        identityNumTxtbox.Text,
                        firstNameTxtbox.Text,
                        lastNameTxtbox.Text,
                        usernameTxtbox.Text,
                        passwordTxtbox.Text,
                        identityNumTxtbox.Text,
                        dobDatePicker.Value,
                        gender: personalDetailsGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text
                    );
                    context.PatientTbls.Add(newPatient);
                    newPerDetails = new PerDetailsTbl(
                        id: identityNumTxtbox.Text
                    );
                    context.PerDetailsTbls.Add(newPerDetails);

                    newPrimaryCare = new PrimaryCareTbl(
                        identityNumTxtbox.Text,
                        lastName: lastNameTxtbox.Text,
                        firstName: firstNameTxtbox.Text,
                        title: titleCombobox.SelectedItem.ToString()
                        );
                    context.PrimaryCareTbls.Add(newPrimaryCare);
                    context.SaveChanges();
                    MessageBox.Show("User created! Please login.", "Success", MessageBoxButtons.OK);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region Helper Methods
        // validate method
        private bool isvalid()
        {
            return Validator.IsPresent(usernameTxtbox) && Validator.IsPresent(passwordTxtbox) &&
                   Validator.IsPresent(confirmPwdTxtbox) && Validator.IsPresent(identityNumTxtbox) &&
                   Validator.PasswordMatch(passwordTxtbox.Text, confirmPwdTxtbox.Text) && 
                   Validator.IsPresent(lastNameTxtbox) && Validator.IsPresent(firstNameTxtbox);
        }
        #endregion
    }
}