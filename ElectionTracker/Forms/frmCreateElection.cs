using ElectionTracker.Models;
using ElectionTracker.Services;
using System;
using System.Windows.Forms;

namespace ElectionTracker.Forms
{
    public partial class frmCreateElection : Form
    {
        private readonly IElectionService _electionservice;

        private ElectionGroup _electionGroup;
        public frmCreateElection(IElectionService electionService)
        {
            _electionservice = electionService;
            _electionGroup = _electionservice.SelectedElectionGroup;
            InitializeComponent();
        }

        private void btnCreateElection_Click(object sender, EventArgs e)
        {
            
            Election newElection = new Election(txtElectionName.Text, txtElectionDescription.Text, _electionGroup.ElectionGroupID,
                dtElectionStartDate.Value.AddHours(dtElectionStartTime.Value.Hour).AddMinutes(dtElectionStartTime.Value.Minute),
                dtElectionEndDate.Value.AddHours(dtElectionEndTime.Value.Hour).AddMinutes(dtElectionEndTime.Value.Minute));

            if (_electionservice.NewElectionValidator(newElection) == false)
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
    }
}
