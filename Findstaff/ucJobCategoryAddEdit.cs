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
using System.Text.RegularExpressions;

namespace Findstaff
{
    public partial class ucJobCategoryAddEdit : UserControl
    {

        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucJobCategoryAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            int ctr = 0;
            if(txtCategory.Text != "")
            {
                string check = "Select Count(CATEGORYNAME) from jobcategory_t where categoryname = '" + txtCategory.Text + "'";
                com = new MySqlCommand(check, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if (ctr == 0)
                {
                    string cmd = "Insert into jobcategory_t (categoryname) values ('" + txtCategory.Text + "')";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategory.Clear();
                    this.Hide();
                }
                else if (ctr != 0)
                {
                    MessageBox.Show("Record already exists.", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Category Text Field Empty","Add Category Error");
            }
            connection.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            string cmd = "";
            if (txtCategory2.Text == "")
            {
                MessageBox.Show("Category name must not be empty.", "Empty Category Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Are you sure You want to update the record with the following details?"
                    + "\nCategory ID: " + txtID.Text + "\nNew Catogory Name: " + txtCategory2.Text, "Confirmation", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    cmd = "Update jobcategory_t set categoryname = '" + txtCategory2.Text + "' where Category_id = '" + txtID.Text + "';";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Changes Saved!", "Update Fee Record!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtCategory2.Clear();
                    this.Hide();
                }
            }
            connection.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucJobCategoryAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtCategory.Text)))
            {
                txtCategory.Text = "";
            }
        }

        private void txtCategory2_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtCategory2.Text)))
            {
                txtCategory2.Text = "";
            }
        }
    }
}
