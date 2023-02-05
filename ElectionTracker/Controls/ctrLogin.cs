using ElectionTracker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionTracker.Controls
{
    public partial class ctrLogin : UserControl
    {
        public event Action RegisterClicked;
        public event Action LogInSuccess;

        private readonly IUserService _userService;

        public ctrLogin(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        /// <summary>
        /// method called each time the control is opened 
        /// </summary>
        public void Init()
        {
            if (_userService.CurrentUser != null)
            {
                _userService.SetCurrentUser();
            }
            this.txtEmail.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (RegisterClicked != null)
            {
                RegisterClicked();
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text))
                return;

            bool loginSuccessful = _userService.AttemptLogin(txtEmail.Text, txtPassword.Text);

            if (loginSuccessful)
            {
                if (LogInSuccess != null)
                {
                    LogInSuccess();
                }
            }

            
        }

        private void ctrLogin_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
