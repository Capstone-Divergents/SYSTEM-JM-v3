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
    public partial class ucJobOrderManagement : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";

        public ucJobOrderManagement()
        {
            InitializeComponent();
            ucEmployer.Dock = DockStyle.Fill;
            //ucJobOrder.Dock = DockStyle.Fill;
            ucJobList.Dock = DockStyle.Fill;
            ucJobFees.Dock = DockStyle.Fill;
        }

        private void rbEmployer_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployer.Visible = true;
            //ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;

            cmd = "select e.employer_id'Employer ID', e.employername'Name of Employer', e.foreignprin'Foreign Principal', c.countryname'Country' "
                + "from employer_t e join country_t c "
                + "on e.country_id = c.country_id;";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployer.dgvEmployer.DataSource = ds.Tables[0];
                }
            }
        }

       /* private void rbJobOrder_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployer.Visible = false;
            ucJobOrder.Visible = true;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;

            cmd = "Select J.jorder_id 'Job Order ID', e.employername'Employer', j.Cntrctstart 'Contract Start' from Joborder_t j join employer_t e on j.employer_id = e.employer_id";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucJobOrder.dgvJobOrder.DataSource = ds.Tables[0];
                }
            }
        }*/

        private void rbJobList_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployer.Visible = false;
            //ucJobOrder.Visible = false;
            ucJobList.Visible = true;
            ucJobFees.Visible = false;

            cmd = "select jo.jorder_id'Job Order ID', j.jobname'Job', e.employername'Employer', jo.reqapp'No. of Required Applicants', jo.cntrctend'End of Contract' from joborder_t jo  join employer_t e on jo.employer_id = e.employer_id join job_t j on jo.job_id = j.job_id where jo.cntrctstat = 'Active' or jo.cntrctstat = 'Renewed'; ";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucJobList.dgvJobList.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbJobFees_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployer.Visible = false;
            //ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = true;

            cmd = "select jo.jorder_id'Job Order ID', count(jf.fee_id)'No. of Fees' from joborder_t jo join jobfees_t jf on jo.jorder_id = jf.jorder_id group by jo.jorder_id";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucJobFees.dgvJobFees.DataSource = ds.Tables[0];
                }
            }
        }

        private void ucJobOrderManagement_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
