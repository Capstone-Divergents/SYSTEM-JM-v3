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
    public partial class ucCountry : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        private string cmd = "";

        public ucCountry()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucCountryAddEdit.Dock = DockStyle.Fill;
            ucCountryAddEdit.Visible = true;
            ucCountryAddEdit.panel1.Visible = true;
            ucCountryAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucCountryAddEdit.txtCountryID2.Text = dgvCountry.SelectedRows[0].Cells[0].Value.ToString();
            ucCountryAddEdit.txtCountryName2.Text = dgvCountry.SelectedRows[0].Cells[1].Value.ToString();
            ucCountryAddEdit.Dock = DockStyle.Fill;
            ucCountryAddEdit.Visible = true;
            ucCountryAddEdit.panel1.Visible = false;
            ucCountryAddEdit.panel2.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            DialogResult rs = MessageBox.Show("Are you sure you want to delete the country " + dgvCountry.SelectedRows[0].Cells[1].Value.ToString()
                + " from the list of countries?", "Delete Country Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string cmd = "delete from country_t where country_id = '" + dgvCountry.SelectedRows[0].Cells[0].Value.ToString() + "';";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                dgvCountry.Rows.Remove(dgvCountry.SelectedRows[0]);
                MessageBox.Show("Country Deleted!", "Coutry Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "select country_id, countryname from country_t where country_id = '" + dgvCountry.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucCountryView.countryid.Text = dr[0].ToString();
                ucCountryView.countryname.Text = dr[1].ToString();
            }
            dr.Close();

            cmd = "Select c.COUNTRY_ID'Country ID', g.Reqname'Requirement Name' from country_t c join countryreqs_t cr"
                + " on c.country_id = cr.country_id join genreqs_t g on cr.req_id = g.req_id"
                + " where c.country_id = '" + dgvCountry.SelectedRows[0].Cells[0].Value.ToString() + "'";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucCountryView.dgvReq.DataSource = ds.Tables[0];
                }
            }
            dr.Close();

            ucCountryView.Dock = DockStyle.Fill;
            ucCountryView.Visible = true;
        }


        public void searchData(string valueToFind)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            string cmd = "select c.COUNTRY_ID'Country ID', c.COUNTRYNAME'Name of Country', count(cr.req_id)'No. of requirements'"
                    + " from country_t c join countryreqs_t cr on"
                    + " c.country_id = cr.country_id"
                    + " WHERE concat(c.country_id, c.countryname) LIKE '%" + valueToFind + "%' group by c.country_id";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvCountry.DataSource = table;
        }

        private void ucCountryAddEdit1_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "select c.COUNTRY_ID'Country ID', c.COUNTRYNAME'Name of Country', count(cr.req_id)'No. of requirements'"
                    + " from country_t c join countryreqs_t cr on"
                    + " c.country_id = cr.country_id"
                    + " group by c.country_id";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvCountry.DataSource = ds.Tables[0];
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucCountry_Load(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucCountryAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "select c.COUNTRY_ID'Country ID', c.COUNTRYNAME'Name of Country', count(cr.req_id)'No. of requirements'"
                    + " from country_t c join countryreqs_t cr on"
                    + " c.country_id = cr.country_id"
                    + " group by c.country_id";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvCountry.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
