using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Findstaff
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.LETTER, 10, 10, 42, 43);
            PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("C:\\Users\\jmcamilo435\\Desktop\\Report.pdf", FileMode.Create));
            doc.Open();

            PdfPTable table = new PdfPTable(dgvReport.Columns.Count);

            for (int j = 0; j < dgvReport.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgvReport.Columns[j].HeaderText));
            }
            table.HeaderRows = 1;

            for (int i = 0; i < dgvReport.Rows.Count; i++)
            {
                for (int k = 0; k < dgvReport.Columns.Count; k++)
                {
                    if (dgvReport[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgvReport[k, i].Value.ToString()));
                    }
                }
            }

            doc.Add(table);
            
            doc.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "select j.job_id'Job ID', j.Jobname'Job Name', c.categoryname'Category', j.jobtype'Type of Job' from jobcategory_t c join job_t j on c.category_id = j.category_id";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvReport.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
