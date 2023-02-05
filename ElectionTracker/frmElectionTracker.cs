using ElectionTracker.Controls;
using ElectionTracker.Services;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionTracker
{
    public partial class frmElectionTracker : Form
    {

        private readonly IUserService _userService;
        private readonly ctrRegister _ctrRegister;
        private readonly ctrLogin _ctrLogin;
        private readonly ctrMainMenu _ctrMainMenu;
        private readonly ctrElectionGroupManager _ctrElectionGroupManager;


        public frmElectionTracker(IUserService userService, ctrRegister ctrRegister, ctrLogin ctrLogin, ctrMainMenu ctrMainMenu, ctrElectionGroupManager ctrElectionGroupManager)
        {
            InitializeComponent();
            _userService = userService;
            _ctrRegister = ctrRegister;
            _ctrLogin = ctrLogin;
            _ctrMainMenu = ctrMainMenu;
            _ctrElectionGroupManager = ctrElectionGroupManager;
        }

        private void frmElectionTracker_Load(object sender, EventArgs e)
        {
            GenerateLoginControl();
        }

        private void GenerateLoginControl()
        {
            ClearPanel();
            _ctrLogin.RegisterClicked += GenerateRegistrationControl;
            _ctrLogin.LogInSuccess += GenerateMainMenuControl;
            _ctrLogin.Init();
            pnlElectionTracker.Controls.Add(_ctrLogin);
        }

        private void GenerateRegistrationControl()
        {
            ClearPanel();
            _ctrRegister.RegistrationSuccess+= GenerateMainMenuControl;
            _ctrRegister.Init();
            pnlElectionTracker.Controls.Add(_ctrRegister);
        }

        private void GenerateMainMenuControl()
        {
            ClearPanel();
            _ctrMainMenu.ElectionGroupClicked+= GenerateElectionGroupManagerControl;
            _ctrMainMenu.LogOutClicked += GenerateLoginControl;
            _ctrMainMenu.Init();
            pnlElectionTracker.Controls.Add(_ctrMainMenu);
        }

        private void GenerateElectionGroupManagerControl()
        {
            ClearPanel();
            _ctrElectionGroupManager.MainMenuClicked += GenerateMainMenuControl;
            _ctrElectionGroupManager.LogOutClicked += GenerateLoginControl;
            _ctrElectionGroupManager.Init();
            pnlElectionTracker.Controls.Add(_ctrElectionGroupManager);
        }

        /// <summary>
        /// Method to check if the panel is clear and if not it clears it
        /// </summary>
        private void ClearPanel()
        {
            if (pnlElectionTracker.Controls.Count != 0)
            {
                pnlElectionTracker.Controls.Clear();
            }
        }

    }
    
}
