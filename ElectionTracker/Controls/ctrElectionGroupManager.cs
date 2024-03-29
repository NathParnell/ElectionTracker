﻿using ElectionTracker.Forms;
using ElectionTracker.Models;
using ElectionTracker.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElectionTracker.Controls
{
    public partial class ctrElectionGroupManager : UserControl
    {
        private readonly IUserService _userService;
        private readonly IElectionService _electionService;
        private ElectionGroup _electionGroup;
        private ElectionGroupUserRole _userRole;
        public event Action MainMenuClicked;
        public event Action LogOutClicked;

        public ctrElectionGroupManager(IElectionService electionService, IUserService userService)
        {
            _electionService = electionService;
            _userService = userService;
            InitializeComponent();
        }

        private void ctrElectionGroupManager_Load(object sender, EventArgs e)
        {
           Init();
        }

        public void Init()
        {
            _electionGroup = _electionService.SelectedElectionGroup;

            lblElectionGroupName.Text = _electionGroup.Name;

            _userRole = _electionService.GetUserRole();

            DisplayUserDetails();

            ManagePermissions();

            DisplayElections();
        }


        private void DisplayUserDetails()
        {
            try
            {
                lblCurrentUserName.Text = $"Current User: {_userService.CurrentUser.Forename} {_userService.CurrentUser.Surname}";
            }
            catch (Exception ex)
            {
                //means that the user hasnt pulled through so a user isnt logged in properly
                if (LogOutClicked != null)
                {
                    LogOutClicked();
                }
            }
        }

        private void btnCreateElection_Click(object sender, EventArgs e)
        {
            frmManageElection frmManageElection = new frmManageElection(_electionService);
            frmManageElection.ShowDialog();

            DisplayElections();
        }

        private void btnAcceptElectionGroupMembers_Click(object sender, EventArgs e)
        {
            frmAcceptUserToElectionGroup frmAcceptUserToElectionGroup = new frmAcceptUserToElectionGroup(_userService, _electionService);
            frmAcceptUserToElectionGroup.ShowDialog();
        }

        private void DisplayElections()
        {
            flpActiveElections.Controls.Clear();

            List<Election> elections = _electionService.GetElectionsbyElectionGroupID(_electionGroup.ElectionGroupID);

            foreach(Election election in elections)
            {
                GenerateElectionControl(election);
            }
        }

        private void GenerateElectionControl(Election election)
        {
            var electionControl = new FLPControls.ctrElectionSelect(election, _userRole, _electionService, _userService);
            electionControl.ElectionEdited += DisplayElections;
            flpActiveElections.Controls.Add(electionControl);
        }

        private void ManagePermissions()
        {
            //add in permissions for this ctrl
            if (_userRole == ElectionGroupUserRole.Administrator)
            {
                btnCreateElection.Show();
                btnAcceptElectionGroupMembers.Show();
            }
            else
            {
                btnCreateElection.Hide();
                btnAcceptElectionGroupMembers.Hide();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (MainMenuClicked != null)
            {
                MainMenuClicked();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (LogOutClicked != null)
            {
                LogOutClicked();
            }
        }
    }
}
