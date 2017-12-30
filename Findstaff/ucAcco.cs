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
    public partial class ucAcco : UserControl
    {
        public ucAcco()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter;
        private string cmd = "";

        private void btnAdvSe_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnViewAcco_Click(object sender, EventArgs e)
        {
            if(dgvAccounting.Rows.Count != 0)
            {
                string appNo = dgvAccounting.SelectedRows[0].Cells[0].Value.ToString(), appName = dgvAccounting.SelectedRows[0].Cells[1].Value.ToString();
                ucAccoView.init(appNo, appName);
                ucAccoView.Dock = DockStyle.Fill;
                ucAccoView.Visible = true;
            }
        }

        private void ucAcco_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            cmd = "select a.app_no'Application No.', app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', count(p.fee_id)'No. of Fees to be payed' "
                    + "from app_t app join payables_t p "
                    + "on app.app_id = p.app_id "
                    + "join applications_t a on a.app_no = p.app_no "
                    + "where app.appstatus = 'Payment' and a.appstats = 'Active' "
                    + "group by p.app_no";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvAccounting.DataSource = ds.Tables[0];
                }
            }
        }

        private void ucAccoView_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            cmd = "select a.app_no, app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', count(p.fee_id)'No. of Fees to be payed' "
                    + "from app_t app join payables_t p "
                    + "on app.app_id = p.app_id "
                    + "join applications_t a on a.app_no = p.app_no "
                    + "where app.appstatus = 'Payment' and a.appstats = 'Active' "
                    + "group by p.app_no";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvAccounting.DataSource = ds.Tables[0];
                }
            }
        }

        public void searchData(string valueToFind)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            string cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', count(p.fee_id)'No. of Fees to be payed' "
                    + "from app_t app join payables_t p "
                    + "on app.app_id = p.app_id "
                    + "join applications_t a on a.app_no = p.app_no "
                    + "where app.appstatus = 'Payment' and a.appstats = 'Active' and concat(app.app_id , ' ', app.lname, ', ', app.fname, ' ', app.mname) LIKE '%" + valueToFind + "%' "
                    + "group by p.app_no ";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvAccounting.DataSource = table;
            connection.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucAcco_Load(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }
    }
}