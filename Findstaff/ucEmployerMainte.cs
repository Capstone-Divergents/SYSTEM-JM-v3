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
    public partial class ucEmployerMainte : UserControl
    {
        public ucEmployerMainte()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucEmployerMainteAddEdit.Dock = DockStyle.Fill;
            ucEmployerMainteAddEdit.Visible = true;
            ucEmployerMainteAddEdit.panel1.Visible = true;
            ucEmployerMainteAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucEmployerMainteAddEdit.Dock = DockStyle.Fill;
            ucEmployerMainteAddEdit.Visible = true;
            ucEmployerMainteAddEdit.panel1.Visible = false;
            ucEmployerMainteAddEdit.panel2.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ucEmployerMainteView.Dock = DockStyle.Fill;
            ucEmployerMainteView.Visible = true;
        }
    }
}
