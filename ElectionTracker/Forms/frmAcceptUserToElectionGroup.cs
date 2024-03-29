﻿using ElectionTracker.Models;
using ElectionTracker.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElectionTracker.Forms
{
    public partial class frmAcceptUserToElectionGroup : Form
    {
        private readonly IUserService _userService;
        private readonly IElectionService _electionService;

        private List<ElectionGroupMembership> _unacceptedElectionGroupMemberships;
        private ElectionGroupMembership _selectedMembershipRequest { get; set; }


        public frmAcceptUserToElectionGroup(IUserService userService, IElectionService electionService)
        {
            _userService = userService;
            _electionService = electionService;
            InitializeComponent();
        }

        private void frmAcceptUserToElectionGroup_Load(object sender, EventArgs e)
        {
            _selectedMembershipRequest = null;
            _unacceptedElectionGroupMemberships = null;

            SetComboBoxValues();
        }

        private void SetComboBoxValues()
        {
            ResetSelectedUserValues();
            cmbSelectUser.Items.Clear();

            _unacceptedElectionGroupMemberships = _electionService.GetUnacceptedElectionGroupMembershipRequests(_electionService.SelectedElectionGroup);
            List<User> usersToAccept = _userService.GetAllUsers();

            foreach (ElectionGroupMembership unacceptedElectionGroupMembership in _unacceptedElectionGroupMemberships)
            {
                foreach (User userToAccept in usersToAccept)
                {
                    if (userToAccept.UserID == unacceptedElectionGroupMembership.UserID)
                    {
                        cmbSelectUser.Items.Add(userToAccept.Forename + " " + userToAccept.Surname);
                    }
                }
            }
        }


        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            ResetSelectedUserValues();

            if (cmbSelectUser.SelectedIndex == -1)
            {
                return;
            }

            _selectedMembershipRequest = _unacceptedElectionGroupMemberships[cmbSelectUser.SelectedIndex];

            User selectedUser = _userService.GetUserByUserID(_selectedMembershipRequest.UserID);

            SetSelectedUserValues(selectedUser);

        }

        private void SetSelectedUserValues(User selectedUser)
        {
            lblUserName.Text = "Name: " + selectedUser.Forename + " " + selectedUser.Surname;
            lblAddress.Text = "Address: " + selectedUser.Address + " " + selectedUser.Postcode;
            lblDateOfBirth.Text = "Date Of Birth" + selectedUser.DateOfBirth.ToShortDateString();
            lblRequestedRole.Text = "Requested Role:" + _selectedMembershipRequest.UserRole.ToString();
            btnAcceptUserRequest.Show();
            btnAcceptUserRequest.Enabled = true;
        }

        private void ResetSelectedUserValues()
        {
            lblUserName.Text = "";
            lblAddress.Text = "";
            lblDateOfBirth.Text = "";
            lblRequestedRole.Text = "";
            btnAcceptUserRequest.Hide();
            btnAcceptUserRequest.Enabled = false;
            _selectedMembershipRequest = null;

        }

        private void btnAcceptUserRequest_Click(object sender, EventArgs e)
        {
            _electionService.AcceptElectionGroupMembershipRequest(_selectedMembershipRequest);

            ResetSelectedUserValues();
            SetComboBoxValues();
        }
    }
}
