using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Findstaff
{
    public partial class ucAccoView : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucAccoView()
        {
            InitializeComponent();
        }

        private void ucAccoView_Load(object sender, EventArgs e)
        {

        }

        private void btnPayBal_Click(object sender, EventArgs e)
        {
            DialogResult y = MessageBox.Show("Are you sure you want to pay the balance(s)?", "Pay Balance?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == y)
            {
                MessageBox.Show("Paid!\n\nTotal : ", "Paid!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
