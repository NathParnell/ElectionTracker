using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionTracker.Controls.FLPControls
{
    public partial class ctrCandidateVote : UserControl
    {
        public ctrCandidateVote(string candidateName, int voteCount)
        {
            InitializeComponent();
            this.lblCandidateName.Text = candidateName;
            this.lblCandidateVotes.Text = voteCount.ToString();
        }
    }
}
