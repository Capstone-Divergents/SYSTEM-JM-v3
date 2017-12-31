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
    public partial class ucEmployee : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        private string cmd = "";

        public ucEmployee()
        {
            InitializeComponent();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            ucEmployeeAddEdit.Dock = DockStyle.Fill;
            ucEmployeeAddEdit.Visible = true;
            ucEmployeeAddEdit.panel1.Visible = true;
            ucEmployeeAddEdit.panel2.Visible = false;
        }

        private void btnEmpUpd_Click(object sender, EventArgs e)
        {
            ucEmployeeAddEdit.txtUsername2.Text = dgvEmployee.SelectedRows[0].Cells[0].Value.ToString();
            ucEmployeeAddEdit.cbDept2.Text = dgvEmployee.SelectedRows[0].Cells[2].Value.ToString();
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            cmd = "select fname, lname from emp_t where username = '" + dgvEmployee.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucEmployeeAddEdit.txtFirstName2.Text = dr[0].ToString();
                ucEmployeeAddEdit.txtLastName2.Text = dr[1].ToString();
            }
            dr.Close();

            cmd = "select emp_id, pass, mname, gender, monthname(birthdate), day(birthdate), year(birthdate), addrss, contact, deptname from emp_t where username = '" + dgvEmployee.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucEmployeeAddEdit.txtEmpId.Text = dr[0].ToString();
                ucEmployeeAddEdit.txtPassword2.Text = dr[1].ToString();
                ucEmployeeAddEdit.txtMiddleName2.Text = dr[2].ToString();

                if (dr.GetString(3) == "Male")
                {
                    ucEmployeeAddEdit.rbMale2.Select();
                }
                else
                {
                    ucEmployeeAddEdit.rbFemale2.Select();
                }

                ucEmployeeAddEdit.cbMonth2.Text = dr[4].ToString();
                ucEmployeeAddEdit.cbDay2.Text = dr[5].ToString();
                ucEmployeeAddEdit.cbYear2.Text = dr[6].ToString();
                ucEmployeeAddEdit.txtAddress2.Text = dr[7].ToString();
                ucEmployeeAddEdit.txtContact2.Text = dr[8].ToString();
                ucEmployeeAddEdit.cbDept2.Text = dr[9].ToString();
            }

            dr.Close();
            connection.Close();

            ucEmployeeAddEdit.Dock = DockStyle.Fill;
            ucEmployeeAddEdit.Visible = true;
            ucEmployeeAddEdit.panel1.Visible = false;
            ucEmployeeAddEdit.panel2.Visible = true;    
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from emp_t where username = '" + dgvEmployee.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvEmployee.Rows.Remove(dgvEmployee.SelectedRows[0]);
            MessageBox.Show("Employee Deleted!", "Employee Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void btnEmpView_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "select emp_id, username, Concat(fname , ' ' , mname, ' ', lname ), gender, birthdate, addrss, contact, deptname from emp_t where username = '" + dgvEmployee.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucEmployeeView.empID.Text = dr[0].ToString();
                ucEmployeeView.username.Text = dr[1].ToString();
                ucEmployeeView.name.Text = dr[2].ToString();
                ucEmployeeView.gender.Text = dr[3].ToString();
                ucEmployeeView.bday.Text = dr[4].ToString();
                ucEmployeeView.address.Text = dr[5].ToString();
                ucEmployeeView.contactNum.Text = dr[6].ToString();
                ucEmployeeView.dept.Text = dr[7].ToString();
            }
            ucEmployeeView.Dock = DockStyle.Fill;
            ucEmployeeView.Visible = true;
        }

        public void searchData(string valueToFind)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            string cmd = "select username'Username', Concat(fname , ' ' , lname)'Employee Name', DEPTNAME'Department' from Emp_t WHERE Concat(username, fname , ' ' , lname, deptname) LIKE '%" + valueToFind + "%'";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvEmployee.DataSource = table;
        }

        private void ucEmployeeAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "select username'Username', Concat(fname , ' ' , lname)'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucEmployee_Load(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucEmployeeAddEdit_VisibleChanged_1(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "select username'Username', Concat(fname , ' ' , lname)'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
