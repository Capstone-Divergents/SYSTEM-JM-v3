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
    public partial class ucEmployerView : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucEmployerView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucEmployerView_Load(object sender, EventArgs e)
        {
            string emp = "", coun = "", prin = "";
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string query = "SELECT * FROM EMPLOYER_T;";
            com = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                emp = dataReader.GetString(1);
                coun = dataReader.GetString(3);
                prin = dataReader.GetString(2);
            }
            connection.Close();

            employer.Text = emp;
            country.Text = coun;
            principal.Text = prin;
        }
    }
}
