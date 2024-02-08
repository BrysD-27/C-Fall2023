using Davis_FinalProject.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davis_FinalProject
{
    public static class Validator
    {
        private static string title = "Entry Error";
        private static readonly PCHRContext context = new PCHRContext();
        public static string Title
        {
            get => title;
            set => title = value;
        }
        // check if textbox has value
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        // textbox length check
        public static bool MaxLength(TextBox textBox)
        {
            if(textBox.Text.Length >= 10)
            {
                MessageBox.Show(textBox.Tag + "  can't be more than 10 characters.", Title);
                return false;
            }
            return true;
        }
        // check if entered username exists
        public static bool IsValidUser(TextBox textBox)
        {
            try
            {
                if(context.PatientTbls.Where(p => p.UserName == textBox.Text).Any()) {
                    return true;
                }
                return false;
            }
            catch { return false; }
        }
        // check user's entered password matches user's password on database
        public static bool ValidateUser(string username, string password)
        {
            try
            {
                PatientTbl? patient = new PatientTbl();  
                patient = context.PatientTbls.FirstOrDefault(p => p.UserName == username);

                if(patient?.Password.Trim() != password) {
                    MessageBox.Show("Could not validate user, please try again.", Title);
                    return false;
                }
                return true;
            } 
            catch { return false; }
        }
        // check if passwords match
        public static bool PasswordMatch(string password, string confirmPassword)
        {
            if(!confirmPassword.Equals(password))
            {
                MessageBox.Show("Passwords do not match, please try again.", Title);
                return false;
            }
            return true;
        }
        // check state length
        public static bool StateLengthCheck(string state)
        {
            if(state.Length > 2)
            {
                MessageBox.Show("State entry must be Abbrevated to 2 characters, please try again.", Title);
                return false;
            }
            return true;
        }
    }
}
