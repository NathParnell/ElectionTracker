using ElectionTracker.Forms;
using ElectionTracker.Models;
using ElectionTracker.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElectionTracker.Controls
{
    public partial class ctrMainMenu : UserControl
    {
        private readonly IUserService _userService;
        private readonly IElectionService _electionService;

        public event Action ElectionGroupClicked;
        public event Action LogOutClicked;

        public ctrMainMenu(IUserService userService, IElectionService electionService)
        {
            InitializeComponent();
            _userService = userService;
            _electionService = electionService;
        }

        private void ctrMainMenu_Load(object sender, EventArgs e)
        {
            Init();
        }

        /// <summary>
        /// method called each time the control is opened 
        /// </summary>
        public void Init()
        {
            DisplayUserDetails();
            DisplayUserElectionGroups();
        }

        /// <summary>
        /// displays the user's name in the for each
        /// </summary>
        private void DisplayUserDetails()
        {
            try
            {
                lblCurrentUserName.Text = $"Current User: { _userService.CurrentUser.Forename} {_userService.CurrentUser.Surname}";
            }
            catch(Exception ex)
            {
                //means that the user hasnt pulled through so a user isnt logged in properly
                if (LogOutClicked != null)
                {
                    LogOutClicked();
                }
            }
        }

        /// <summary>
        /// method which controls the gerating of the flow layout pnel controls
        /// creates a new control for each election group
        /// </summary>
        private void DisplayUserElectionGroups()
        {
            flpUserElectionGroups.Controls.Clear();

            try
            {
                List<ElectionGroupMembership> userElectionGroupMemberships = _electionService.GetUserElectionGroupMemberships();
                List<ElectionGroup> electionGroups = _electionService.GetAllElectionGroups();
                List<ElectionGroup> userElectionGroups = new List<ElectionGroup>();

                //all of these memberships are out users, we want to get all of the groups that they are a part of using
                foreach (ElectionGroupMembership userElectionGroupMembership in userElectionGroupMemberships)
                {
                    if (userElectionGroupMembership.Accepted == false)
                        continue;

                    foreach (ElectionGroup electionGroup in electionGroups)
                    {
                        if (electionGroup.ElectionGroupID == userElectionGroupMembership.ElectionGroupID)
                        {
                            GenerateElectionGroupControl(userElectionGroupMembership, electionGroup);
                        }
                    }                 
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void GenerateElectionGroupControl(ElectionGroupMembership userElectionGroupMembership, ElectionGroup electionGroup)
        {
            var electionGroupControl = new FLPControls.ctrElectionGroup(userElectionGroupMembership, electionGroup);
            electionGroupControl.ElectionGroupClicked += GenerateElectionGroupManager;
            flpUserElectionGroups.Controls.Add(electionGroupControl);
        }

        private void GenerateElectionGroupManager(ElectionGroup electionGroup)
        {
            if (ElectionGroupClicked != null)
            {
                _electionService.SelectedElectionGroup = electionGroup;
                ElectionGroupClicked();
            }
        }

        private void btnCreateElectionGroup_Click(object sender, EventArgs e)
        {
            frmCreateElectionGroup frmCreateElectionGroup = new frmCreateElectionGroup(_userService, _electionService);
            frmCreateElectionGroup.ShowDialog();

            DisplayUserElectionGroups();
        }

        private void btnElectionGroupRegister_Click(object sender, EventArgs e)
        {
            frmRegisterElectionGroup frmRegisterElectionGroup = new frmRegisterElectionGroup(_userService, _electionService);
            frmRegisterElectionGroup.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (LogOutClicked != null)
            {
                LogOutClicked();
            }
        }
    }
}
