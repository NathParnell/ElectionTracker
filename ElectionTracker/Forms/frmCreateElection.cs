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

            bool electionAdded = _electionservice.CreateElection(newElection);
            if (electionAdded)
            {
                MessageBox.Show("Election has been added to " + _electionGroup.Name);
                this.Dispose();
            }

        }
    }
}
