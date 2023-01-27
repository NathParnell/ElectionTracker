using ElectionTracker.Classes;
using ElectionTracker.Controls.FLPControls;
using ElectionTracker.Forms;
using ElectionTracker.Services;
using ElectionTracker.Services.Infrastructure;
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
    public partial class ctrMainMenu : UserControl
    {
        private readonly IUserService _userService;
        private readonly IElectionService _electionService;
        private ctrElectionGroup _ctrElectionGroup;

        public event Action ElectionGroupClicked1;

        public ctrMainMenu(IUserService userService, IElectionService electionService, ctrElectionGroup ctrElectionGroup)
        {
            InitializeComponent();
            _userService = userService;
            _electionService = electionService;
            _ctrElectionGroup = ctrElectionGroup;
        }

        private void ctrMainMenu_Load(object sender, EventArgs e)
        {
            DisplayUserDetails();
            DisplayUserElectionGroups();


        }


        public void DisplayUserDetails()
        {
            try
            {
                lblCurrentUserName.Text = _userService.CurrentUser.Forename + " " + _userService.CurrentUser.Surname;
            }
            catch(Exception ex)
            {

            }
        }


        public void DisplayUserElectionGroups()
        {
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
            var electionGroupControl = _ctrElectionGroup;
            electionGroupControl.ElectionGroupClicked += GenerateElectionGroupManager();
            flpUserElectionGroups.Controls.Add(electionGroupControl);
        }

        private void GenerateElectionGroupManager()
        {
            if (ElectionGroupClicked1 != null)
            {
                ElectionGroupClicked1() ;
            }
        }



        private void btnCreateElectionGroup_Click(object sender, EventArgs e)
        {
            frmCreateElectionGroup frmCreateElectionGroup = new frmCreateElectionGroup(_userService, _electionService);
            frmCreateElectionGroup.ShowDialog();
        }

        private void btnElectionGroupRegister_Click(object sender, EventArgs e)
        {
            frmRegisterElectionGroup frmRegisterElectionGroup = new frmRegisterElectionGroup(_userService, _electionService);
            frmRegisterElectionGroup.ShowDialog();
        }
    }
}
