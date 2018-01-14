using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Findstaff
{
    public partial class ucBanksAllowed : UserControl
    {
        public ucBanksAllowed()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucBanksAllowedAddEdit.Dock = DockStyle.Fill;
            ucBanksAllowedAddEdit.Visible = true;
            ucBanksAllowedAddEdit.panel1.Visible = true;
            ucBanksAllowedAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucBanksAllowedAddEdit.Dock = DockStyle.Fill;
            ucBanksAllowedAddEdit.Visible = true;
            ucBanksAllowedAddEdit.panel1.Visible = false;
            ucBanksAllowedAddEdit.panel2.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ucBanksAllowedView.Dock = DockStyle.Fill;
            ucBanksAllowedView.Visible = true;
        }
    }
}
