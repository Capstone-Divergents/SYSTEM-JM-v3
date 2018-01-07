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
        MySqlDataReader dr;
        private string cmd = "";

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
            ucJobOrderAddEdit.Dock = DockStyle.Fill;
            ucJobOrderAddEdit.txtJobNo2.Text = dgvJobOrder.SelectedRows[0].Cells[0].Value.ToString();
            connection.Open();
            cmd = "select monthname(cntrctstart), day(cntrctstart), year(cntrctstart) from joborder_t where jorder_id = '" + dgvJobOrder.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobOrderAddEdit.cbMonth2.Text = dr[0].ToString();
                ucJobOrderAddEdit.cbDay2.Text = dr[1].ToString();
                ucJobOrderAddEdit.cbYear2.Text = dr[2].ToString();
            }
            dr.Close();
            connection.Close();
            ucJobOrderAddEdit.cbEmployer2.Text = dgvJobOrder.SelectedRows[0].Cells[1].Value.ToString();

            ucJobOrderAddEdit.Visible = true;
            ucJobOrderAddEdit.panel1.Visible = false;
            ucJobOrderAddEdit.panel2.Visible = true;
        }

        private void ucJobOrder_VisibleChanged(object sender, EventArgs e)
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

        public void searchData(string valueToFind)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            string cmd = "Select J.jorder_id 'Job Order ID', e.employername'Employer', j.Cntrctstart 'Contract Start', j.cntrctend'End of Contract' from Joborder_t j join employer_t e on j.employer_id = e.employer_id WHERE concat(j.jorder_id, e.employername, j.Cntrctstart) LIKE '%" + valueToFind + "%'";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvJobOrder.DataSource = table;
        }

        private void ucJobOrderAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "Select J.jorder_id 'Job Order ID', e.employername'Employer', j.Cntrctstart 'Contract Start', j.cntrctend'End of Contract' from Joborder_t j join employer_t e on j.employer_id = e.employer_id";
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
            DialogResult rs = MessageBox.Show("Are you sure you want to delete the job order "+ dgvJobOrder.SelectedRows[0].Cells[0].Value.ToString() +"?"
                +"\nAll jobs listed under this job order will be deleted, and forfeit any active applications.", "Delete Job Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                string cmd = "delete from joborder_t where jorder_id = '" + dgvJobOrder.SelectedRows[0].Cells[0].Value.ToString() + "';";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                dgvJobOrder.Rows.Remove(dgvJobOrder.SelectedRows[0]);
                MessageBox.Show("Job Order Deleted!", "Job Order Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucJobOrder_Load(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucJobOrderAddEdit_VisibleChanged_1(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "Select J.jorder_id 'Job Order ID', e.employername'Employer', j.Cntrctstart 'Contract Start', j.cntrctend'End of Contract' from Joborder_t j join employer_t e on j.employer_id = e.employer_id";
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
    }
}
