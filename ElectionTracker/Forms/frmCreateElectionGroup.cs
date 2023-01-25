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

namespace ElectionTracker
{
    public partial class frmCreateElectionGroup : Form
    {

        private readonly IUserService _userService;
        private readonly IElectionService _electionService;


        public frmCreateElectionGroup(IUserService userService, IElectionService electionService)
        {
            InitializeComponent();
            _userService = userService;
            _electionService = electionService;
        }



        private void btnCreateElectionGroup_Click(object sender, EventArgs e)
        {
            bool success = _electionService.CreateElectionGroup(txtElectionGroupName.Text, txtElectionGroupDescription.Text);
            this.Dispose();
        }
    }
}
