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
    public partial class ucJobApp : UserControl
    {
        private MySqlConnection connection;
        private MySqlDataReader dr;
        MySqlCommand com = new MySqlCommand();
        private string cmd = "";

        public ucJobApp()
        {
            InitializeComponent();
        }

        private void btnSetForInitInt_Click(object sender, EventArgs e)
        {

        }

        private void ucJobApp_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            if(this.Visible == true)
            {
                connection.Open();
                cmd = "Select employername from employer_t";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbEmployer.Items.Add(dr[0]);
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbEmployer.Items.Clear();
            }
        }

        private void cbEmployer_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            cmd = "Select j.jorder_id from joborder_t j join employer_t e"
                + " on j.employer_id = e.employer_id "
                +"where j.cntrctstat = 'Active' and e.employername = '"+cbEmployer.Text+"'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbJobOrder.Items.Add(dr[0]);
            }
            dr.Close();
            connection.Close();
        }

        private void cbJobOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            cmd = "select job.jobname from joblist_t j join job_t job on j.job_id = job.job_id where j.jorder_id = '"+cbJobOrder.Text+"'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbJob.Items.Add(dr[0].ToString());
            }
            dr.Close();
            connection.Close();
        }
    }
}
