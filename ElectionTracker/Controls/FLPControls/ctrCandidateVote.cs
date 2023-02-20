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
