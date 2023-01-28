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
using System.Xml.Linq;

namespace ElectionTracker.Forms
{
    public partial class frmRegisterElectionGroup : Form
    {

        private readonly IUserService _userService;
        private readonly IElectionService _electionService;


        public frmRegisterElectionGroup(IUserService userService, IElectionService electionService)
        {
            InitializeComponent();
            _userService = userService;
            _electionService = electionService;

        }

        private void frmRegisterElectionGroup_Load(object sender, EventArgs e)
        {
            cmbElectionGroup.Items.Clear();
            List<ElectionGroup> selectableElectionGroups = _electionService.GetElectionGroupsUserIsNotAPartOf();
            foreach(ElectionGroup electionGroup in selectableElectionGroups)
            {
                cmbElectionGroup.Items.Add(electionGroup.Name);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if ((cmbElectionGroup.SelectedIndex == -1) || cmbRole.SelectedIndex == -1)
                return;
             
            bool requestMade = _electionService.JoinElectionGroupRequest(cmbElectionGroup.Text, cmbRole.Text);
            if (requestMade)
            {
                MessageBox.Show("Your request has been made");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Request failes! Please try again");
            }

        }
    }
}
