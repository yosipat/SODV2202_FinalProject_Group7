using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SODV2202_FinalProject_Group7
{
    public partial class Home : UserControl
    {
        public event EventHandler btnStartClicked;
        public Home()
        {
            InitializeComponent();

            
          
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStartClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
