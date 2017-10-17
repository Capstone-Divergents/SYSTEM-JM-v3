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
    public partial class ucIntListInit : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        private string jorder = "", job = "", employername = "", appname = "", appno = ""; 

        public ucIntListInit()
        {
            InitializeComponent();
        }

        private void ucIntListInit_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }

        private void btnIntApp_Click(object sender, EventArgs e)
        {
            jorder = joborder.Text;
            job = jobname.Text;
            employername = employer.Text;
            appno = dgvIntervieweeList.SelectedRows[0].Cells[0].Value.ToString();
            appname = dgvIntervieweeList.SelectedRows[0].Cells[2].Value.ToString();
            ucInterviewCriteria.txtAppName.Text = appname;
            ucInterviewCriteria.txtAppNo.Text = appno;
            ucInterviewCriteria.txtJobOrderId.Text = jorder;
            ucInterviewCriteria.txtJobName.Text = job;
            ucInterviewCriteria.txtEmpName.Text = employername;
            ucInterviewCriteria.Dock = DockStyle.Fill;
            ucInterviewCriteria.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
