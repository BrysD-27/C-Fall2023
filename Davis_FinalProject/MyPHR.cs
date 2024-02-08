using Davis_FinalProject.Models.DataLayer;

namespace Davis_FinalProject
{
    public partial class MyPHR : Form
    {
        private PCHRContext PCHRContext = new PCHRContext();
        private PatientTbl? _patient = new PatientTbl();
        private PerDetailsTbl? _perDetails = new PerDetailsTbl();
        private PrimaryCareTbl? _primaryCare = new PrimaryCareTbl();
        private List<string> titles = new List<string>
        {
            "Mr",
            "Mrs",
            "Miss",
            "Ms"
        };
        public MyPHR(PatientTbl? patient = null)
        {
            InitializeComponent();
            _patient = patient;
            _perDetails = PCHRContext.PerDetailsTbls.FirstOrDefault(pd => pd.PatientId == _patient.PatientId);
            _primaryCare = PCHRContext.PrimaryCareTbls.FirstOrDefault(pc => pc.PrimaryId == _patient.PrimaryId);
            BuildForm();
        }

        private void MyPHR_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Helper Methods
        private void BuildForm()
        {
            //login details
            usernameTxtbox.Text = _patient?.UserName.Trim();
            oldPasswordtTxtbox.UseSystemPasswordChar = true;
            newPasswordTxtbox.UseSystemPasswordChar = true;
            confirmPasswordTxtbox.UseSystemPasswordChar = true;

            // personal details
            identityNumTxtbox.Text = _patient?.PatientId.Trim();
            titleComboBox.Items.AddRange(titles.ToArray());
            if (_primaryCare?.Title != null)
            {
                titleComboBox.SelectedIndex = titleComboBox.Items.IndexOf(_primaryCare?.Title.Trim());
            }
            if (_patient?.Gender == "Male")
            {
                maleBtn.Checked = true;
            }
            else
            {
                femaleBtn.Checked = true;
            }
            lastnameTxtbox.Text = _patient?.LastName.Trim();
            firstnameTxtbox.Text = _patient?.FirstName.Trim();
            dobPicker.Value = _patient.DateOfBirth.HasValue ? _patient.DateOfBirth.Value : DateTime.Today;

            // contact details 
            contactAddressTxtbox.Text = _patient.AddressStreet;
            contactCityTxtbox.Text = _patient.AddressCity + " " + _patient.AddressState;
            contactZipTxtbox.Text = _patient.AddressZip;
            contactMobileTxtbox.Text = _patient.PhoneMobile;
            contactHomeTxtbox.Text = _patient.PhoneHome;
            contactStateTxtbox.Text = _patient.AddressState;

            // primary care details
            fullnameTxtbox.Text = _primaryCare?.NameFirst.Trim() + " " + _primaryCare?.NameLast.Trim();
            specialityTxtbox.Text = _primaryCare.Specialty;
            primaryCareMobileTxtbox.Text = _primaryCare.PhoneMobile;
            primaryCareWorkTxtbox.Text = _primaryCare.PhoneOffice;

            foreach (Control item in personalDetailsGroup.Controls)
            {
                item.Enabled = false;
            }
            foreach (Control item in contactDetailsGroup.Controls)
            {
                item.Enabled = false;
            }
            foreach (Control item in emergencyDetailsGroup.Controls)
            {
                item.Enabled = false;
            }
            foreach (Control item in primaryCareGroup.Controls)
            {
                item.Enabled = false;
            }
            foreach (Control item in healthInsGroup.Controls)
            {
                item.Enabled = false;
            }
            editPersonalDetLabel.Enabled = true;
            editContactDetLabel.Enabled = true;
            emergencyEditLabel.Enabled = true;
            primaryCareEditLabel.Enabled = true;
            insuranceEditLabel.Enabled = true;
        }

        private void editPersonalDetLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in personalDetailsGroup.Controls)
            {
                item.Enabled = true;
            }
            editPersonalDetLabel.Enabled = false;
        }

        private void savePersonalDetLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (personalDetailsValid())
            {
                PatientTbl updatePatient = new PatientTbl(
                    identityNumTxtbox.Text,
                    firstName: firstnameTxtbox.Text,
                    lastName: lastnameTxtbox.Text,
                    _patient?.UserName,
                    _patient?.Password,
                    primaryID: identityNumTxtbox.Text,
                    gender: personalDetailsGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text,
                    dob: dobPicker.Value
                    );
                PrimaryCareTbl updateTitle = new PrimaryCareTbl(
                    id: _patient.PrimaryId,
                    firstName: firstnameTxtbox.Text,
                    lastName: lastnameTxtbox.Text,
                    title: titleComboBox.SelectedItem.ToString()
                    );
                PCHRContext.PatientTbls.Update(updatePatient);
                PCHRContext.Entry(_primaryCare).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                PCHRContext.PrimaryCareTbls.Update(updateTitle); 
                PCHRContext.SaveChanges();
                foreach (Control item in personalDetailsGroup.Controls)
                {
                    item.Enabled = false;
                }
                editPersonalDetLabel.Enabled = true;
            }
        }

        private bool personalDetailsValid()
        {
            return Validator.IsPresent(identityNumTxtbox) && Validator.IsPresent(firstnameTxtbox) && Validator.IsPresent(lastnameTxtbox);
        }
        private void cancelPersonalDetLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in personalDetailsGroup.Controls)
            {
                item.Enabled = false;
            }
            editPersonalDetLabel.Enabled = true;
        }

        private void editContactDetLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in contactDetailsGroup.Controls)
            {
                item.Enabled = true;
            }
            editContactDetLabel.Enabled = false;
        }

        private void saveContactLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(contactlDetailsValid())
            {
                PatientTbl updateContact = new PatientTbl(
                        _patient.PatientId,
                        _patient.FirstName,
                        _patient.LastName,
                        _patient.UserName,
                        _patient.Password,
                        _patient.PatientId,
                        street: contactAddressTxtbox.Text,
                        city: contactCityTxtbox.Text,
                        state: contactStateTxtbox.Text,
                        zip: contactZipTxtbox.Text,
                        mobilePhone: contactMobileTxtbox.Text,
                        homePhone: contactHomeTxtbox.Text
                    );
                PCHRContext.PatientTbls.Update(updateContact);
                PCHRContext.SaveChanges();
                foreach (Control item in contactDetailsGroup.Controls)
                {
                    item.Enabled = false;
                }
                editContactDetLabel.Enabled = true;
            }
        }

        private bool contactlDetailsValid()
        {
            return Validator.StateLengthCheck(contactStateTxtbox.Text);
        }

        private void cancelContactLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in contactDetailsGroup.Controls)
            {
                item.Enabled = false;
            }
            editContactDetLabel.Enabled = true;
        }

        private void emergencyEditLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in emergencyDetailsGroup.Controls)
            {
                item.Enabled = true;
            }
            emergencyEditLabel.Enabled = false;
        }

        private void emergencySaveLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in emergencyDetailsGroup.Controls)
            {
                item.Enabled = false;
            }
            emergencyEditLabel.Enabled = true;
        }

        private void emergencyCancelLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in emergencyDetailsGroup.Controls)
            {
                item.Enabled = false;
            }
            emergencyEditLabel.Enabled = true;
        }

        private void primaryCareEditLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in primaryCareGroup.Controls)
            {
                item.Enabled = true;
            }
            primaryCareEditLabel.Enabled = false;
        }

        private void primaryCareSaveLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrimaryCareTbl updatePrimaryCare = new PrimaryCareTbl(
                id: _patient.PrimaryId,
                firstName: fullnameTxtbox.Text.Split(' ')[0],
                lastName: fullnameTxtbox.Text.Split(' ')[1],
                specialty: specialityTxtbox.Text,
                mobilePhone: primaryCareMobileTxtbox.Text,
                officePhone: primaryCareWorkTxtbox.Text
                ) ;
            PCHRContext.Entry(_primaryCare).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            PCHRContext.PrimaryCareTbls.Update(updatePrimaryCare);
            PCHRContext.SaveChanges();
            foreach (Control item in primaryCareGroup.Controls)
            {
                item.Enabled = false;
            }
            primaryCareEditLabel.Enabled = true;
        }

        private void primaryCareCancelLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in primaryCareGroup.Controls)
            {
                item.Enabled = false;
            }
            primaryCareEditLabel.Enabled = true;
        }

        private void insuranceEditLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in healthInsGroup.Controls)
            {
                item.Enabled = true;
            }
            insuranceEditLabel.Enabled = false;
        }

        private void insuranceSaveLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in healthInsGroup.Controls)
            {
                item.Enabled = false;
            }
            insuranceEditLabel.Enabled = true;
        }

        private void insuranceCancelLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in healthInsGroup.Controls)
            {
                item.Enabled = false;
            }
            insuranceEditLabel.Enabled = true;
        }

        private void cancelChangePwdLabel_LinkClicked(object? sender = null, LinkLabelLinkClickedEventArgs? e = null)
        {
            oldPasswordtTxtbox.Clear();
            newPasswordTxtbox.Clear();
            confirmPasswordTxtbox.Clear();
        }

        private void changePasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Validator.PasswordMatch(oldPasswordtTxtbox.Text, _patient.Password) && Validator.PasswordMatch(newPasswordTxtbox.Text, confirmPasswordTxtbox.Text))
            {
                _patient.Password = newPasswordTxtbox.Text;
                try
                {
                    PCHRContext.PatientTbls.Update(_patient);
                    PCHRContext.SaveChanges();
                    MessageBox.Show("Password updated!", "Password Change");
                    cancelChangePwdLabel_LinkClicked();
                }
                catch
                {
                    Console.WriteLine("Failed");
                    MessageBox.Show("Password update failed, please try again!", "Password Error");
                }
            }
        }
        #endregion
    }
}
