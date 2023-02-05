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

            _userService.AttemptLogin(txtEmail.Text, txtPassword.Text);

            if (LogInSuccess != null)
            {
                LogInSuccess();
            }
        }

        public void Init()
        {
            if (_userService.CurrentUser != null)
            {
                _userService.SetCurrentUser();
            }
            this.txtEmail.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
        }

        private void ctrLogin_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
