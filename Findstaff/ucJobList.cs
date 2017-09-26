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
    public partial class ucJobList : UserControl
    {
        MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        private string cmd = "";

        public ucJobList()
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
            ucJobListAddEdit.Dock = DockStyle.Fill;
            ucJobListAddEdit.Visible = true;
            ucJobListAddEdit.panel1.Visible = true;
            ucJobListAddEdit.panel2.Visible = false;
        }

        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            ucJobListAddEdit.Dock = DockStyle.Fill;
            ucJobListAddEdit.Visible = true;
            ucJobListAddEdit.panel1.Visible = false;
            ucJobListAddEdit.panel2.Visible = true;
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpView_Click(object sender, EventArgs e)
        {
            ucJobListView.Dock = DockStyle.Fill;
            ucJobListView.Visible = true;
        }

        private void ucJobListAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            cmd = "select jo.jorder_id'Job Order ID', j.jobname'Job', e.employername'Employer', jl.reqapp'No. of Required Applicants' "+
                "from joborder_t jo join joblist_t jl on jo.JORDER_ID = jl.jorder_id join employer_t e on jo.employer_id = e.employer_id "+
                "join job_t j on jl.job_id = j.job_id where jo.cntrctstat = 'Active' or jo.cntrctstat = 'Renewed';";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvJobList.DataSource = ds.Tables[0];
                }
            }
            connection.Close();
        }
    }
}
