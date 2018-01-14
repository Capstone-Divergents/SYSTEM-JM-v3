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
    public partial class ucCurrency : UserControl
    {
        public ucCurrency()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucCurrencyAddEdit.Dock = DockStyle.Fill;
            ucCurrencyAddEdit.Visible = true;
            ucCurrencyAddEdit.panel1.Visible = true;
            ucCurrencyAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucCurrencyAddEdit.Dock = DockStyle.Fill;
            ucCurrencyAddEdit.Visible = true;
            ucCurrencyAddEdit.panel1.Visible = false;
            ucCurrencyAddEdit.panel2.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ucCurrencyView.Dock = DockStyle.Fill;
            ucCurrencyView.Visible = true;
        }
    }
}
