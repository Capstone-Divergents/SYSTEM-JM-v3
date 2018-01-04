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
    public partial class ucJobTypeAddEdit : UserControl
    {
        public ucJobTypeAddEdit()
        {
            InitializeComponent();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            txtType.Clear();
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
