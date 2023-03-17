using ElectionTracker.Models;
using ElectionTracker.Services;
using System;
using System.Windows.Forms;

namespace ElectionTracker.Forms
{
    public partial class frmManageElection : Form
    {
        private readonly IElectionService _electionservice;

        private ElectionGroup _electionGroup;
        private string _existingElectionID;
        
        public frmManageElection(IElectionService electionService, string existingElectionID = null)
        {
            _electionservice = electionService;
            _electionGroup = _electionservice.SelectedElectionGroup;
            _existingElectionID = existingElectionID;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            if (_existingElectionID == null)
            {
                lblTitle.Text = "Create Election";
                btnElectionAction.Text = "Create Election";
                btnDeleteElection.Hide();
            }
            else
            {
                lblTitle.Text = " Election";
                btnElectionAction.Text = "Edit Election";
                GetExistingElectionDetails();
            }
        }

        private void GetExistingElectionDetails()
        {
            Election existingElection = _electionservice.GetElectionByElectionID(_existingElectionID);

            txtElectionName.Text = existingElection.Name;
            txtElectionDescription.Text = existingElection.Description;
            dtElectionStartDate.Value = new DateTime(existingElection.StartDate.Year, existingElection.StartDate.Month, existingElection.StartDate.Day);
            dtElectionEndDate.Value = new DateTime(existingElection.EndDate.Year, existingElection.EndDate.Month, existingElection.EndDate.Day);
            dtElectionStartTime.Value = new DateTime(2003, 04, 15).AddHours(existingElection.StartDate.Hour).AddMinutes(existingElection.StartDate.Minute).AddSeconds(existingElection.StartDate.Second);
            dtElectionEndTime.Value = new DateTime(2003,04,15).AddHours(existingElection.EndDate.Hour).AddMinutes(existingElection.EndDate.Minute).AddSeconds(existingElection.EndDate.Second);
        }

        private void btnElectionAction_Click(object sender, EventArgs e)
        {
            if (_existingElectionID == null)
            {
                CreateElection();
            }
            else if (_existingElectionID != null)
            {
                if(DialogResult.Yes == MessageBox.Show("Are you sure you would like to update this election", "Update Election", MessageBoxButtons.YesNo))
                {
                    UpdateElection();
                }
            }
        }

        /// <summary>
        /// method called when the election is being created
        /// </summary>
        private void CreateElection()
        {
            Election newElection = new Election(txtElectionName.Text, txtElectionDescription.Text, _electionGroup.ElectionGroupID,
                dtElectionStartDate.Value.AddHours(dtElectionStartTime.Value.Hour).AddMinutes(dtElectionStartTime.Value.Minute),
                dtElectionEndDate.Value.AddHours(dtElectionEndTime.Value.Hour).AddMinutes(dtElectionEndTime.Value.Minute));

            if (_electionservice.ElectionValidator(newElection) == false)
            {
                MessageBox.Show("This election's End Date is before the Start Date. Please change this!", "Invalid Election");
                return;
            }

            bool electionAdded = _electionservice.CreateElection(newElection);
            if (electionAdded == true)
            {
                MessageBox.Show("Election has been added to " + _electionGroup.Name);
                this.Dispose();
            }
        }

        /// <summary>
        /// method called when an existing election is being edited
        /// </summary>
        private void UpdateElection()
        {
            Election updatedElection = new Election(_existingElectionID, txtElectionName.Text, txtElectionDescription.Text, _electionGroup.ElectionGroupID,
                dtElectionStartDate.Value.AddHours(dtElectionStartTime.Value.Hour).AddMinutes(dtElectionStartTime.Value.Minute),
                dtElectionEndDate.Value.AddHours(dtElectionEndTime.Value.Hour).AddMinutes(dtElectionEndTime.Value.Minute));

            if (_electionservice.ElectionValidator(updatedElection) == false)
            {
                MessageBox.Show("This election's End Date is before the Start Date. Please change this!", "Invalid Election");
                return;
            }

            bool electionUpdated = _electionservice.UpdateElection(updatedElection);
            if (electionUpdated == true)
            {
                MessageBox.Show("Election has been added to " + _electionGroup.Name);
                this.Dispose();
            }
        }

        private void btnDeleteElection_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure you would like to delete this election", "Update Election", MessageBoxButtons.YesNo))
            {
                _electionservice.DeleteElection(_existingElectionID);
                MessageBox.Show("Election Deleted");
                this.Dispose();
            }
        }
    }
}
