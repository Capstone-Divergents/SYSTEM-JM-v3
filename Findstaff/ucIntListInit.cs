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
            ucInterviewCriteria.Dock = DockStyle.Fill;
            ucInterviewCriteria.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
