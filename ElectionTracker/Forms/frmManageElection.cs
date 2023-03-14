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
            init();
        }

        private void init()
        {
            if (_existingElectionID == null)
            {
                btnElectionAction.Text = "Create Election";
            }
            else
            {
                btnElectionAction.Text = "Edit Election";
                getExistingElectionDetails();
            }
        }

        private void getExistingElectionDetails()
        {
            Election existingElection = _electionservice.GetElectionByElectionID(_existingElectionID);

            txtElectionName.Text = existingElection.Name;
            txtElectionDescription.Text = existingElection.Description;
            dtElectionStartDate.Value = existingElection.StartDate;
            dtElectionEndDate.Value = existingElection.EndDate;
            dtElectionStartTime.Value = existingElection.StartDate;
            dtElectionEndTime.Value = existingElection.EndDate;
        }

        private void btnElectionAction_Click(object sender, EventArgs e)
        {
            if (_existingElectionID == null)
            {
                createElection();
            }
            else if (_existingElectionID != null)
            {
                if(DialogResult.Yes == MessageBox.Show("Are you sure you would like to update this election", "Update Election", MessageBoxButtons.YesNo))
                {
                    updateElection();
                }
            }
        }

        /// <summary>
        /// method called when the election is being created
        /// </summary>
        private void createElection()
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
        private void updateElection()
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

    }
}
