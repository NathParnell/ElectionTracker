using ElectionTracker.Services;
using ElectionTracker.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ElectionTracker.Controls
{
    public partial class ctrRegister : UserControl
    {

        private readonly IUserService _userService;

        public event Action RegistrationSuccess;


        public ctrRegister(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            ResetRegistration();
            bool detailsValid = UserAuthenticator();

            if (detailsValid != true) { 
                return;
            }

            bool RegistrationComplete = _userService.CreateAccount(txtForename.Text,
                txtSurname.Text,
                txtEmail.Text,
                txtPassword.Text);

            if (RegistrationComplete == false)
                return;
            
            if (RegistrationSuccess != null)
            {
                RegistrationSuccess();
            }
            
        }

        /// <summary>
        /// Resets the registration fieldsso the colors retuen to normal
        /// </summary>
        private void ResetRegistration()
        {
            foreach (Control c in this.Controls)
            {
                if (c != lblRegistrationError)
                    c.ForeColor = Color.Black;
               
            }

            lblRegistrationError.Text = ""; 
            
        }


        /// <summary>
        /// Goes through all of the registration controls and ensures that certain entries such as passwords follow appropriate standards
        /// </summary>
        /// <returns></returns>
        private bool UserAuthenticator()
        {
            var errorMessage = new System.Text.StringBuilder();
            bool Authenticated = true;

            if (String.IsNullOrEmpty(txtForename.Text))
            {
                errorMessage.AppendLine("Please provide a Forename!");
                lblForename.ForeColor = Color.Red;
                Authenticated = false;
            }


            if (String.IsNullOrEmpty(txtSurname.Text))
            {
                errorMessage.AppendLine("Please provide a Surname!");
                lblSurname.ForeColor = Color.Red;

                Authenticated = false;
            }

            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                errorMessage.AppendLine("Please provide an Address!");
                lblAddress.ForeColor = Color.Red;

                Authenticated = false;
            }

            if (String.IsNullOrEmpty(txtPostcode.Text))
            {
                errorMessage.AppendLine("Please provide a Postcode!");
                lblPostcode.ForeColor = Color.Red;

                Authenticated = false;
            }
            //create an over 18 checker
            if (String.IsNullOrEmpty(dtDateOfBirth.Value.ToString()) )
            {
                errorMessage.AppendLine("Please provide a Postcode!");
                lblPostcode.ForeColor = Color.Red;

                Authenticated = false;
            }

            //Email Regex String from - https://stackoverflow.com/questions/201323/how-can-i-validate-an-email-address-using-a-regular-expression
            if (ExpressionValidator(txtEmail.Text, "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$") == false)
            {
                errorMessage.AppendLine("The Email you have entered is invalid!");
                lblEmail.ForeColor = Color.Red;
                Authenticated = false;
            }

            //Password Regex String from - https://uibakery.io/regex-library/password-regex-csharp
            if ((ExpressionValidator(txtPassword.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$") == false) || txtPassword.Text != txtRePassword.Text)
            {
                errorMessage.AppendLine("The Password you have entered is invalid!");
                lblPassword.ForeColor = Color.Red;
                Authenticated = false;
            }        

            lblRegistrationError.Text = errorMessage.ToString();

            return Authenticated;
        }

        /// <summary>
        /// passes in a user input and a validation string to compare the input against
        /// </summary>
        /// <param name="UserInput"></param>
        /// <param name="ValidationString"></param>
        /// <returns></returns>
        private bool ExpressionValidator(string UserInput, string ValidationString)
        {
            // I used this regex validator to ensure that user inputs are valid for the system - https://uibakery.io/regex-library/password-regex-csharp
            Regex RegexValidator = new Regex (ValidationString);
            if (RegexValidator.IsMatch(UserInput))
                return true;

            return false;
        }

    }
}
