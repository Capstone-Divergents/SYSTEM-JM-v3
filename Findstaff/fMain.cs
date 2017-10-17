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
    public partial class fMain : Form
    {
        MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        private string cmd = "";

        public fMain()
        {
            InitializeComponent();
            ucJobOrderManagement.Dock = DockStyle.Fill;
            ucRecruitment.Dock = DockStyle.Fill;
            ucDocumentation.Dock = DockStyle.Fill;
            ucAcco.Dock = DockStyle.Fill;
            ucMaintenance.Dock = DockStyle.Fill;
            ucReports.Dock = DockStyle.Fill;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();

            string name = "", dept = "";

            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            cmd = "SELECT concat(E.fname, ' ', E.mname, ' ', E.lname), E.deptname FROM EMP_T E JOIN LOGS_T L"
                + " ON E.EMP_ID = L.EMP_ID where LOG_ID = (SELECT MAX(LOG_ID) FROM LOGS_T);";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                name = dr[0].ToString();
                dept = dr[1].ToString();
            }
            dr.Close();
            connection.Close();

            lblName.Text = name;
            lblDept.Text = dept;
            if(dept == "Recruitment")
            {
                rbJobOrderManagement.Enabled = false;
                rbRecruitment.Enabled = true;
                rbDocumentation.Enabled = false;
                rbAcco.Enabled = false;
                rbMaintenance.Enabled = false;
                rbReports.Enabled = false;
            }
            else if (dept == "Documentation")
            {
                rbJobOrderManagement.Enabled = false;
                rbRecruitment.Enabled = false;
                rbDocumentation.Enabled = true;
                rbAcco.Enabled = false;
                rbMaintenance.Enabled = false;
                rbReports.Enabled = false;
            }
            else if (dept == "Accounting")
            {
                rbJobOrderManagement.Enabled = false;
                rbRecruitment.Enabled = false;
                rbDocumentation.Enabled = false;
                rbAcco.Enabled = true;
                rbMaintenance.Enabled = false;
                rbReports.Enabled = false;
            }
            else if (dept == "Marketing")
            {
                rbJobOrderManagement.Enabled = false;
                rbRecruitment.Enabled = false;
                rbDocumentation.Enabled = false;
                rbAcco.Enabled = false;
                rbMaintenance.Enabled = true;
                rbReports.Enabled = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            connection.Open();
            string empID = "";
            DialogResult y = MessageBox.Show("Are you sure you want to logout?", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == y)
            {
                cmd = "select emp_id from emp_t where concat(fname, ' ', mname, ' ', lname) = '" + lblName.Text + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    empID = dr[0].ToString();
                }
                dr.Close();
                cmd = "update logs_t set outtime = current_timestamp() where outtime is null and emp_id = '"+empID+"'";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                this.Hide();
                Login l = new Login();
                l.Show();
            }
            connection.Close();
        }

        private void rbJobOrderManagement_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = true;
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = false;
            ucAcco.Visible = false;
            ucMaintenance.Visible = false;
            ucReports.Visible = false;
        }

        private void rbRecruitment_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = false;
            ucRecruitment.Visible = true;
            ucDocumentation.Visible = false;
            ucAcco.Visible = false;
            ucMaintenance.Visible = false;
            ucReports.Visible = false;
        }

        private void rbDocumentation_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = false;
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = true;
            ucAcco.Visible = false;
            ucMaintenance.Visible = false;
            ucReports.Visible = false;
        }

        private void rbAcco_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = false;
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = false;
            ucAcco.Visible = true;
            ucMaintenance.Visible = false;
            ucReports.Visible = false;
        }

        private void rbFlightBooking_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = false;
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = false;
            ucAcco.Visible = false;
            ucMaintenance.Visible = false;
            ucReports.Visible = false;
        }

        private void rbMaintenance_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = false;
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = false;
            ucAcco.Visible = false;
            ucMaintenance.Visible = true;
            ucReports.Visible = false;
        }

        private void rbReports_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = false;
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = false;
            ucAcco.Visible = false;
            ucMaintenance.Visible = false;
            ucReports.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
