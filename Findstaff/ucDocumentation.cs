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
    public partial class ucDocumentation : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter;
        MySqlDataReader dr;
        private string cmd = "";

        public ucDocumentation()
        {
            InitializeComponent();
        }

        private void btnAdvSe_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnCheckDetails_Click(object sender, EventArgs e)
        {
            if(dgvDocumentation.Rows.Count != 0)
            {
                string appno = dgvDocumentation.SelectedRows[0].Cells[0].Value.ToString(), appname = dgvDocumentation.SelectedRows[0].Cells[1].Value.ToString();
                ucDocAppDetails.init(appno, appname);
                ucDocAppDetails.Dock = DockStyle.Fill;
                ucDocAppDetails.Visible = true;
            }
        }

        private void ucDocAppDetails_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            cmd = "select a.app_no'Application No.', app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', count(ad.req_id)'No. of Documents to be passed' "
                    + "from app_t app join appdoc_t ad "
                    + "on app.app_id = ad.app_id "
                    + "join applications_t a on a.app_no = ad.app_no "
                    + "where app.appstatus = 'Selected' and a.appstats = 'Active' "
                    + "group by ad.app_no";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvDocumentation.DataSource = ds.Tables[0];
                }
            }
        }

        private void ucDocumentation_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            cmd = "select a.app_no'Application No.', app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', count(ad.req_id)'No. of Documents to be passed' "
                    + "from app_t app join appdoc_t ad "
                    + "on app.app_id = ad.app_id "
                    + "join applications_t a on a.app_no = ad.app_no "
                    + "where app.appstatus = 'Selected' and a.appstats = 'Active' "
                    + "group by ad.app_no";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvDocumentation.DataSource = ds.Tables[0];
                }
            }
        }

        public void searchData(string valueToFind)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            string cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', count(ad.req_id)'No. of Documents to be passed' "
                    + "from app_t app join appdoc_t ad "
                    + "on app.app_id = ad.app_id "
                    + "join applications_t a on a.app_no = ad.app_no "
                    + "where app.appstatus = 'Documentation' and a.appstats = 'Active' and concat(app.app_id , ' ', app.lname, ', ', app.fname, ' ', app.mname) LIKE '%" + valueToFind + "%' "
                    + "group by ad.app_no ";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvDocumentation.DataSource = table;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucDocumentation_Load(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }
    }
}
