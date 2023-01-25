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
            List<ElectionGroup> selectableElectionGroups = _userService.GetElectionGroupsUserIsNotAPartOf();
            foreach(ElectionGroup electionGroup in selectableElectionGroups)
            {
                cmbElectionGroup.Items.Add(electionGroup.Name);
            }


            
        }
    }
}
