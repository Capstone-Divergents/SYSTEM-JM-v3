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
    public partial class ucRequirements : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucRequirements()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucRequirementsAddEdit.Dock = DockStyle.Fill;
            ucRequirementsAddEdit.Visible = true;
            ucRequirementsAddEdit.panel1.Visible = true;
            ucRequirementsAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRequirements.Rows.Count != 0)
            {
                ucRequirementsAddEdit.txtRequirementID.Text = dgvRequirements.SelectedRows[0].Cells[0].Value.ToString();
                ucRequirementsAddEdit.txtRequirement2.Text = dgvRequirements.SelectedRows[0].Cells[1].Value.ToString();
                ucRequirementsAddEdit.Dock = DockStyle.Fill;
                ucRequirementsAddEdit.Visible = true;
                ucRequirementsAddEdit.panel1.Visible = false;
                ucRequirementsAddEdit.panel2.Visible = true;
                ucRequirementsAddEdit.cbDesignation1.Text = dgvRequirements.SelectedRows[0].Cells[2].Value.ToString();
                ucRequirementsAddEdit.rtbDesc2.Text = dgvRequirements.SelectedRows[0].Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("No record available for edit.", "No Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from genreqs_t where req_id = '" + dgvRequirements.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvRequirements.Rows.Remove(dgvRequirements.SelectedRows[0]);
            MessageBox.Show("Requirement Deleted!", "Requirement Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        public void searchData(string valueToFind)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            string cmd = "Select Req_ID'Requirement ID', Reqname'Requirement Name', Allocation'Purpose', Description from Genreqs_t WHERE concat(Req_ID, Reqname, Allocation, Description) LIKE '%" + valueToFind + "%'";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvRequirements.DataSource = table;
        }

        private void ucRequirementsAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "Select Req_ID'Requirement ID', Reqname'Requirement Name', Allocation'Purpose', Description from Genreqs_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvRequirements.DataSource = ds.Tables[0];
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucRequirements_Load(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }
    }
}
