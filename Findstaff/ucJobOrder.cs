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
    public partial class ucJobOrder : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucJobOrder()
        {
            InitializeComponent();
        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucJobOrderAddEdit.Dock = DockStyle.Fill;
            ucJobOrderAddEdit.Visible = true;
            ucJobOrderAddEdit.panel1.Visible = true;
            ucJobOrderAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucJobOrderAddEdit.txtJobNo2.Text = dgvJobOrder.SelectedRows[0].Cells[0].Value.ToString();
            ucJobOrderAddEdit.Dock = DockStyle.Fill;
            ucJobOrderAddEdit.Visible = true;
            ucJobOrderAddEdit.panel1.Visible = false;
            ucJobOrderAddEdit.panel2.Visible = true;
            ucJobOrderAddEdit.cbEmployer2.Text = dgvJobOrder.SelectedRows[0].Cells[1].Value.ToString();
            //ucJobOrderAddEdit.cbMonth2.Text = dgvJobOrder.SelectedRows[0].Cells[2].Value.ToString();
            //ucJobOrderAddEdit.cbDay2.Text = dgvJobOrder.SelectedRows[0].Cells[2].Value.ToString();
            //ucJobOrderAddEdit.cbYear2.Text = dgvJobOrder.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void ucJobOrder_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "Select country_id 'Country Id', countryname 'Country Name' from Country_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvJobOrder.DataSource = ds.Tables[0];
                }
            }
        }

        private void ucJobOrderAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "Select J.jorder_id 'Job Order ID', e.employername'Employer', j.Cntrctstart 'Contract Start' from Joborder_t j join employer_t e on j.employer_id = e.employer_id";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvJobOrder.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from joborder_t where jorder_id = '" + dgvJobOrder.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvJobOrder.Rows.Remove(dgvJobOrder.SelectedRows[0]);
            MessageBox.Show("Job Order Deleted!", "Job Order Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }
    }
}
