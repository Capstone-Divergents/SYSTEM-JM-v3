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
    public partial class ucEmployer : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        private string cmd = "";

        public ucEmployer()
        {
            InitializeComponent();
        }

        private void btnAdvSe_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            ucEmployerAddEdit.Dock = DockStyle.Fill;
            ucEmployerAddEdit.Visible = true;
            ucEmployerAddEdit.panel1.Visible = true;
            ucEmployerAddEdit.panel2.Visible = false;
        }

        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            ucEmployerAddEdit.txtEmpID.Text = dgvEmployer.SelectedRows[0].Cells[0].Value.ToString();
            ucEmployerAddEdit.txtEmp2.Text = dgvEmployer.SelectedRows[0].Cells[1].Value.ToString();
            ucEmployerAddEdit.txtPrincipal2.Text = dgvEmployer.SelectedRows[0].Cells[2].Value.ToString();
            ucEmployerAddEdit.Dock = DockStyle.Fill;
            ucEmployerAddEdit.Visible = true;
            ucEmployerAddEdit.panel1.Visible = false;
            ucEmployerAddEdit.panel2.Visible = true;
            ucEmployerAddEdit.cbCountry2.Text = dgvEmployer.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from employer_t where employer_id = '" + dgvEmployer.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvEmployer.Rows.Remove(dgvEmployer.SelectedRows[0]);
            MessageBox.Show("Employer Deleted!", "Employer Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        public void searchData(string valueToFind)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            string cmd = "select e.employer_id'Employer ID', e.employername'Name of Employer', e.foreignprin'Foreign Principal', c.countryname'Country' "
                + "from employer_t e join country_t c "
                + "on e.country_id = c.country_id WHERE concat(e.employer_id, e.employername, e.foreignprin, c.countryname) LIKE '%" + valueToFind + "%'";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvEmployer.DataSource = table;
        }

        private void ucEmployerAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "select e.employer_id'Employer ID', e.employername'Name of Employer', e.foreignprin'Foreign Principal', c.countryname'Country' "
                + "from employer_t e join country_t c "
                + "on e.country_id = c.country_id;";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvEmployer.DataSource = ds.Tables[0];
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucEmployer_Load(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucEmployerAddEdit_VisibleChanged_1(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "select e.employer_id'Employer ID', e.employername'Name of Employer', e.foreignprin'Foreign Principal', c.countryname'Country' "
                + "from employer_t e join country_t c "
                + "on e.country_id = c.country_id;";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvEmployer.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "select employer_id, employername, foreignprin, email, contact, companyadd from employer_t where employer_id = '" + dgvEmployer.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucEmployerView.empID.Text = dr[0].ToString();
                ucEmployerView.employer.Text = dr[1].ToString();
                ucEmployerView.forPrincipal.Text = dr[2].ToString();
                ucEmployerView.compEmail.Text = dr[3].ToString();
                ucEmployerView.contact.Text = dr[4].ToString();
                ucEmployerView.compAdd.Text = dr[5].ToString(); 
            }
            dr.Close();

            cmd = "select countryname from country_t where countryname = '" + dgvEmployer.SelectedRows[0].Cells[3].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucEmployerView.country.Text = dr[0].ToString();
            }
            dr.Close();

            ucEmployerView.Dock = DockStyle.Fill;
            ucEmployerView.Visible = true;
        }
    }
}
