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
    public partial class ucGenReqs : UserControl
    {
        private MySqlConnection connection;
        private MySqlCommand com = new MySqlCommand();

        public ucGenReqs()
        {
            InitializeComponent();
            ucFees.Dock = DockStyle.Fill;
            ucJobCategory.Dock = DockStyle.Fill;
            ucSkills.Dock = DockStyle.Fill;
            ucRequirements.Dock = DockStyle.Fill;
            ucJobs.Dock = DockStyle.Fill;
            ucJobType.Dock = DockStyle.Fill;
        }

        private void rbFees_CheckedChanged(object sender, EventArgs e)
        {
            ucFees.Visible = true;
            ucJobCategory.Visible = false;
            ucSkills.Visible = false;
            ucRequirements.Visible = false;
            ucJobs.Visible = false;
            ucJobType.Visible = false;

            string com = "Select g.Fee_ID'Fee ID', g.Feename'Fee Name', count(f.fee_id)'No. of Types' from Genfees_t g join feetype_t f "
                + "on g.fee_id = f.fee_id "
                + "group by g.fee_id";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucFees.dgvFees.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbJobCategory_CheckedChanged(object sender, EventArgs e)
        {
            ucFees.Visible = false;
            ucJobCategory.Visible = true;
            ucSkills.Visible = false;
            ucRequirements.Visible = false;
            ucJobs.Visible = false;
            ucJobType.Visible = false;

            string com = "Select Category_ID'Category ID', categoryname'Category Name' from jobcategory_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucJobCategory.dgvJobCategory.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbSkills_CheckedChanged(object sender, EventArgs e)
        {
            ucFees.Visible = false;
            ucJobCategory.Visible = false;
            ucSkills.Visible = true;
            ucRequirements.Visible = false;
            ucJobs.Visible = false;
            ucJobType.Visible = false;

            string com = "Select Skill_ID'Skill ID', skillname'Skill Name' from Genskills_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucSkills.dgvSkills.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbRequirements_CheckedChanged(object sender, EventArgs e)
        {
            ucFees.Visible = false;
            ucJobCategory.Visible = false;
            ucSkills.Visible = false;
            ucRequirements.Visible = true;
            ucJobs.Visible = false;
            ucJobType.Visible = false;

            string com = "Select Req_ID'Requirement ID', Reqname'Requirement Name', Allocation'Purpose', Description from Genreqs_t;";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucRequirements.dgvRequirements.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbJobs_CheckedChanged(object sender, EventArgs e)
        {
            ucFees.Visible = false;
            ucJobCategory.Visible = false;
            ucSkills.Visible = false;
            ucRequirements.Visible = false;
            ucJobs.Visible = true;
            ucJobType.Visible = false;

            string com = "select j.job_id'Job ID', j.Jobname'Job Name', c.categoryname'Category', jt.typename'Type of Job' from jobcategory_t c join job_t j on c.category_id = j.category_id join jobtype_t jt where j.jobtype_id = jt.jobtype_id;";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucJobs.dgvJobs.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbJobType_CheckedChanged(object sender, EventArgs e)
        {
            ucFees.Visible = false;
            ucJobCategory.Visible = false;
            ucSkills.Visible = false;
            ucRequirements.Visible = false;
            ucJobs.Visible = false;
            ucJobType.Visible = true;

        }

        private void ucGenReqs_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
