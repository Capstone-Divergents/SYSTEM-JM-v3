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
    public partial class ucJobCategory : UserControl
    {

        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucJobCategory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucJobCategoryAddEdit.Dock = DockStyle.Fill;
            ucJobCategoryAddEdit.Visible = true;
            ucJobCategoryAddEdit.panel1.Visible = true;
            ucJobCategoryAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvJobCategory.Rows.Count != 0)
            {
                ucJobCategoryAddEdit.txtID.Text = dgvJobCategory.SelectedRows[0].Cells[0].Value.ToString();
                ucJobCategoryAddEdit.txtCategory2.Text = dgvJobCategory.SelectedRows[0].Cells[1].Value.ToString();
                ucJobCategoryAddEdit.Dock = DockStyle.Fill;
                ucJobCategoryAddEdit.Visible = true;
                ucJobCategoryAddEdit.panel1.Visible = false;
                ucJobCategoryAddEdit.panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("No record available for edit","No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from jobcategory_t where category_id = '" + dgvJobCategory.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvJobCategory.Rows.Remove(dgvJobCategory.SelectedRows[0]);
            MessageBox.Show("Job Category Deleted!", "Job Category Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void ucJobCategoryAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "Select Category_ID'Category ID', categoryname'Category Name' from jobcategory_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvJobCategory.DataSource = ds.Tables[0];
                }
            }
        }

        public void searchData(string valueToFind)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            string cmd = "Select Category_ID'Category ID', categoryname'Category Name' from jobcategory_t WHERE concat(Category_ID, categoryname) LIKE '%" + valueToFind + "%'";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvJobCategory.DataSource = table;
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtCategoryName.Text);
        }

        private void ucJobCategory_Load(object sender, EventArgs e)
        {
            searchData(txtCategoryName.Text);
        }

        private void ucJobCategoryAddEdit_VisibleChanged_1(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "Select Category_ID'Category ID', categoryname'Category Name' from jobcategory_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvJobCategory.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
