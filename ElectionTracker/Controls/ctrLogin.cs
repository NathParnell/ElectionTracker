using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionTracker.Controls
{
    public partial class ctrLogin : UserControl
    {
        public event Action RegisterClicked;

        public ctrLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (RegisterClicked != null)
            {
                RegisterClicked();
            }
        }
    }
}
