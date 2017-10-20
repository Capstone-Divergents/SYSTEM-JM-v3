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
    public partial class ucAppView : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucAppView()
        {
            InitializeComponent();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucAppView_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
