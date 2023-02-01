using ElectionTracker.Classes;
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

namespace ElectionTracker.Forms
{
    public partial class frmCandidates : Form
    {
        private readonly Election _election;
        private readonly IElectionService _electionService;
        private List<Candidate> _candidates;
        private ElectionGroupUserRole _userRole;

        public frmCandidates(Election election, IElectionService electionService, ElectionGroupUserRole userRole)
        {
            _userRole = userRole;
            _electionService = electionService;
            _election = election;
            InitializeComponent();
        }


        private void frmCandidates_Load(object sender, EventArgs e)
        {
            ClearTextboxes();
            DisableCandidateFields();
            HideAdminButtons();

            FillCandidatesDropdown();

            ManagePermissionsOnLoad();

        }


        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(textBox.Text))
                {
                    //add in some code promting user to fill in all values
                    return;
                }
            }

            Candidate newCandidate = new Candidate(txtCandidateForename.Text, txtCandidateSurname.Text, txtCandidateEmail.Text,
                _election.ElectionID, txtCandidateDescription.Text, txtCandidatePartyname.Text);

            _electionService.CreateCandidate(newCandidate);

            ClearTextboxes();

            FillCandidatesDropdown();

        }


        private void ClearTextboxes()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }
        }

        private void DisableCandidateFields()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Enabled = false;
            }
        }

        private void HideAdminButtons()
        {
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.Hide();
            }
        }

        private void EnableCandidateFields()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Enabled = true;
            }
        }

        private void ManagePermissionsOnLoad()
        {
            if ((int)_userRole == 0)
            {
                EnableCandidateFields();
                btnAddCandidate.Show();
            }
        }

        private void DisplayCandidateInformation()
        {
            if (cmbCandidates.SelectedIndex != -1)
            {
                Candidate selectedCandidate = _candidates[cmbCandidates.SelectedIndex];

                txtCandidateForename.Text = selectedCandidate.Forename;
                txtCandidateSurname.Text = selectedCandidate.Surname;
                txtCandidateEmail.Text = selectedCandidate.Email;
                txtCandidateDescription.Text = selectedCandidate.Description;
                txtCandidatePartyname.Text = selectedCandidate.Partyname;
            }
                
        }

        private void cmbCandidates_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTextboxes();
            DisableCandidateFields();
            HideAdminButtons();

            DisplayCandidateInformation();

            if ((int)_userRole == 0)
            {
                btnNewEntry.Show();
                btnDeleteCandidate.Show();
            }
            
        }

        private void FillCandidatesDropdown()
        {
            if (_candidates != null)
                _candidates.Clear();

            cmbCandidates.Items.Clear();

            _candidates = _electionService.GetCandidatesByElection(_election);

            foreach (Candidate candidate in _candidates)
            {
                cmbCandidates.Items.Add(candidate.Forename + " " + candidate.Surname);
            }
        }

        private void RemoveCandidatesfromDropdown()
        {
            cmbCandidates.SelectedIndex = -1;
        }


        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            RemoveCandidatesfromDropdown();
            ClearTextboxes();
            DisableCandidateFields();
            HideAdminButtons();
            ManagePermissionsOnLoad();
        }

        /// <summary>
        /// deletes candidate (only admins)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteCandidate_Click(object sender, EventArgs e)
        {
            Candidate selectedCandidate = _candidates[cmbCandidates.SelectedIndex];

            //remove candidates
            _electionService.DeleteCandidate(selectedCandidate);


            //reset all fields following a delete
            RemoveCandidatesfromDropdown();
            FillCandidatesDropdown();
            ClearTextboxes();
            DisableCandidateFields();
            HideAdminButtons();
            ManagePermissionsOnLoad();

        }
    }
}
