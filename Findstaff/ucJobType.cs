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
    public partial class ucJobType : UserControl
    {
        public ucJobType()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucJobTypeAddEdit.Dock = DockStyle.Fill;
            ucJobTypeAddEdit.Visible = true;
            ucJobTypeAddEdit.panel1.Visible = true;
            ucJobTypeAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucJobTypeAddEdit.Dock = DockStyle.Fill;
            ucJobTypeAddEdit.Visible = true;
            ucJobTypeAddEdit.panel1.Visible = false;
            ucJobTypeAddEdit.panel2.Visible = true;
        }
    }
}
