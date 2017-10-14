using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Findstaff
{
    public partial class Login : Form
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        private string cmd = "";

        public Login()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult y = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == y)
            {
                Application.Exit();
            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            string empID = "";
            cmd = "select emp_id from emp_t where username = '"+txtUsername.Text+"' and pass = '"+txtPassword.Text+"';";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                empID = dr[0].ToString();
            }
            dr.Close();
            if(empID != "")
            {
                cmd = "insert into logs_t (emp_id, intime) values ('"+empID+"', current_timestamp())";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                this.Hide();
                fMain m = new fMain();
                m.Show();
            }
            else
            {
                MessageBox.Show("User is not existing in the database.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.DimGray;
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.PasswordChar = '\0';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }

        #region Validations
        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Clear();
            txtUsername.ForeColor = Color.Black;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
            txtPassword.ForeColor = Color.Black;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.PasswordChar = '•';
        }
        #endregion Validations
    }
}
