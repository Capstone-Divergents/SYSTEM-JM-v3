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
    public partial class ucUtilities : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";

        public ucUtilities()
        {
            InitializeComponent();
            ucEmployee.Dock = DockStyle.Fill;
        }

        private void rbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = true;

            cmd = "select username'Username', Concat(fname , ' ' , lname)'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployee.dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }

        private void ucUtilities_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
