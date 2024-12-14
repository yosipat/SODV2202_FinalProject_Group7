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
    public partial class HowToPlay : UserControl
    {
        public event EventHandler btnGoClicked;
        public event EventHandler btnBackClicked;
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBackClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            btnGoClicked?.Invoke(this, EventArgs.Empty);
        }
        
    }
}
