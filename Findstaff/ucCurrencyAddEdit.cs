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
    public partial class ucCurrencyAddEdit : UserControl
    {
        public ucCurrencyAddEdit()
        {
            InitializeComponent();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
