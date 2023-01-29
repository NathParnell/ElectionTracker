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
            Election newElection = new Election(txtElectionName.Text, txtElectionDescription.Text, _electionGroup.ElectionGroupID, Convert.ToDateTime(dtElectionStartDate.Text), Convert.ToDateTime(dtElectionEndDate.Text));

            bool electionAdded = _electionservice.CreateElection(newElection);
            if (electionAdded)
            {
                MessageBox.Show("Election has been added to " + _electionGroup.Name);
                this.Dispose();
            }

        }
    }
}
