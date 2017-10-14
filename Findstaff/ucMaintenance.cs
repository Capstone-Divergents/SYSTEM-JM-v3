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
    public partial class ucMaintenance : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";

        public ucMaintenance()
        {
            InitializeComponent();
            ucEmployee.Dock = DockStyle.Fill;
            ucApplicant.Dock = DockStyle.Fill;
            ucCountry.Dock = DockStyle.Fill;
            ucGenReqs.Dock = DockStyle.Fill;
        }

        private void rbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = true;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucGenReqs.Visible = false;

            cmd = "select username'Username', Concat(fname , ' ' , lname)'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployee.dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbApplicant_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = true;
            ucCountry.Visible = false;
            ucGenReqs.Visible = false;

            cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', job.jobname'Applying for' "
                    + "from app_t app join job_t job "
                    + "on app.position = job.jobname ";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucApplicant.dgvApplicant.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbCountry_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = true;
            ucGenReqs.Visible = false;

            cmd = "select c.COUNTRY_ID'Country ID', c.COUNTRYNAME'Name of Country', count(cr.req_id)'No. of requirements'"
                    + " from country_t c join countryreqs_t cr on"
                    + " c.country_id = cr.country_id"
                    + " group by c.country_id";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucCountry.dgvCountry.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbGeneralRequirements_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucGenReqs.Visible = true;
        }

        private void ucMaintenance_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
