using ElectionTracker.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ElectionTracker.Controls
{
    public partial class ctrRegister : UserControl
    {

        private readonly IUserService _userService;

        public event Action RegistrationSuccess;
        public event Action LoginClicked;


        public ctrRegister(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        public void Init()
        {
            foreach (var button in this.Controls.OfType<TextBox>())
            {
                button.Text = string.Empty;
            }

            ttPassword.SetToolTip(txtPassword, "Must be at least 7 characters long, Contain a special character, uppercase letter, lowercase letter and a number");

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
                txtAddress.Text,
                txtPostcode.Text,
                dtDateOfBirth.Value,
                txtEmail.Text,
                txtPassword.Text);

            if (RegistrationComplete == false)
                return;
            
            if (RegistrationSuccess != null)
            {
                RegistrationSuccess();
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (LoginClicked != null)
            {
                LoginClicked();
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

            foreach ( TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(textBox.Text.ToString()))
                {
                    errorMessage.AppendLine($"Please provide a {textBox.Name.Remove(0,3)}!");
                    this.Controls[textBox.Name.Remove(0, 3).Insert(0,"lbl")].ForeColor = Color.Red;
                    Authenticated = false;
                }
            }
            
            if (String.IsNullOrEmpty(dtDateOfBirth.Value.ToString()))
            {
                errorMessage.AppendLine("Please provide a date of birth!");
                lblDateOfBirth.ForeColor = Color.Red;

                Authenticated = false;
            }

            //Email Regex String from - https://stackoverflow.com/questions/201323/how-can-i-validate-an-email-address-using-a-regular-expression
            if (_userService.ExpressionValidator(txtEmail.Text, "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$") == false)
            {
                errorMessage.AppendLine("The Email you have entered is invalid!");
                lblEmail.ForeColor = Color.Red;
                Authenticated = false;
            }

            //Password Regex String from - https://uibakery.io/regex-library/password-regex-csharp
            if ((_userService.ExpressionValidator(txtPassword.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$") == false) || txtPassword.Text != txtRePassword.Text)
            {
                errorMessage.AppendLine("The Password you have entered is invalid!");
                lblPassword.ForeColor = Color.Red;
                Authenticated = false;
            }

            try
            {
                if (_userService.CheckEmailIsUnique(txtEmail.Text) == false)
                {
                    errorMessage.AppendLine("The Email you have entered has already been used to create an account");
                    lblEmail.ForeColor = Color.Red;
                    Authenticated = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            lblRegistrationError.Text = errorMessage.ToString();

            return Authenticated;
        }

    }
}
