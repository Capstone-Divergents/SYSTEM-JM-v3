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
    public partial class ucJobFees : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        private string cmd = "";

        public ucJobFees()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucJobFeesAddEdit.Dock = DockStyle.Fill;
            ucJobFeesAddEdit.Visible = true;
            ucJobFeesAddEdit.panel1.Visible = true;
            ucJobFeesAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucJobFeesAddEdit.Dock = DockStyle.Fill;
            ucJobFeesAddEdit.Visible = true;
            ucJobFeesAddEdit.panel1.Visible = false;
            ucJobFeesAddEdit.panel2.Visible = true;
        }

        private void ucJobFeesAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Findstaff.Connection();
            connection = con.dbConnection();
            connection.Open();
            cmd = "select jo.jorder_id'Job Order ID', count(jf.fee_id)'No. of Fees' from joborder_t jo join jobfees_t jf on jo.jorder_id = jf.jorder_id";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvJobFees.DataSource = ds.Tables[0];
                }
            }
            connection.Close();
        }

        public void searchData(string valueToFind)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            string cmd = "select jo.jorder_id'Job Order ID', count(jf.fee_id)'No. of Fees' from joborder_t jo join jobfees_t jf on jo.jorder_id = jf.jorder_id WHERE jf.jorder_id LIKE '%" + valueToFind + "%'";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvJobFees.DataSource = table;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchData(txtSearch.Text);
        }

        private void ucJobFees_Load(object sender, EventArgs e)
        {
            searchData(txtSearch.Text);
        }
    }
}
