using ElectionTracker.Services;
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
        protected IUserService UserService { get; set; }


        public ctrRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ResetRegistration();
            bool detailsValid = UserAuthenticator();

            if (detailsValid == false) { 
                return;
            }

            UserService.CreateAccount(txtForename.Text,
                txtSurname.Text,
                txtEmail.Text,
                txtUsername.Text,
                txtPassword.Text,
                cmbAccountType.Text);
            
        }

        private void ResetRegistration()
        {
            foreach (Control c in this.Controls)
            {
                if (c != lblRegistrationError)
                    c.ForeColor = Color.Black;
               
            }

            lblRegistrationError.Text = ""; 
            
        }

        private bool UserAuthenticator()
        {
            var errorMessage = new System.Text.StringBuilder();
            bool Authenticated = true;

            // Username Regex string from - https://codereview.stackexchange.com/questions/55841/optimizing-and-improving-a-username-regex
            if (ExpressionValidator(txtUsername.Text, "^(?=.{3,32}$)(?!.*[._-]{2})(?!.*[0-9]{5,})[a-z](?:[\\w]*|[a-z\\d\\.]*|[a-z\\d-]*)[a-z0-9]$") == false)
            {
                errorMessage.AppendLine("The Username you have entered is invalid!") ;
                lblUsername.ForeColor = Color.Red;
                Authenticated = false;
            }

            //Password Regex String from - https://uibakery.io/regex-library/password-regex-csharp
            if (ExpressionValidator(txtPassword.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$") == false)
            {
                errorMessage.AppendLine("The Password you have entered is invalid!");
                lblPassword.ForeColor = Color.Red;
                Authenticated = false;
            }        

            //Email Regex String from - https://stackoverflow.com/questions/201323/how-can-i-validate-an-email-address-using-a-regular-expression
            if (ExpressionValidator(txtEmail.Text, "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$") == false)
            {
                errorMessage.AppendLine("The Email you have entered is invalid!");
                lblEmail.ForeColor = Color.Red;
                Authenticated = false;
            }

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

            if (String.IsNullOrEmpty(cmbAccountType.Text))
            {
                errorMessage.AppendLine("Please select an Account Type!");
                lblAccountType.ForeColor = Color.Red;
                Authenticated = false;
            }

            lblRegistrationError.Text = errorMessage.ToString();

            return Authenticated;
        }


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
