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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Findstaff
{
    public partial class ucReports : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";

        public ucReports()
        {
            InitializeComponent();
        }

        #region Load
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            if (cbUnderDept.SelectedIndex == 0)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname, ' ', a.mname, ' ', a.lname)'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Recruitment' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 1)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname, ' ', a.mname, ' ', a.lname)'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Documentation' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 2)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Accounting' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 3)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstatus'Under Department' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Deployed';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 4)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstats = 'Forfeited';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 5)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname, ' ', a.mname, ' ', a.lname)'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id;";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
        }
        #endregion

        #region Create
        private void btnCreatePdf_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            #region Query
            if (cbUnderDept.SelectedIndex == 0)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname, ' ', a.mname, ' ', a.lname)'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Recruitment' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 1)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname, ' ', a.mname, ' ', a.lname)'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Documentation' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 2)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Accounting' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 3)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstatus'Under Department' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Deployed';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 4)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstats = 'Forfeited';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 5)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname, ' ', a.mname, ' ', a.lname)'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id;";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            #endregion

            #region PDF
            Document doc = new Document(PageSize.A4, 30, 30, 50, 10);
            PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("C:\\Users\\ralmojuela\\Desktop\\Report.pdf", FileMode.Create));
            doc.Open();

            doc = BindingData(doc);

            doc.Close();
            MessageBox.Show("PDF Created Successfully!");
            #endregion PDF
        }
        #endregion Create

        private Document BindingData(Document doc)
        {
            iTextSharp.text.Font arial = FontFactory.GetFont("Arial", 13, 1);

            PdfPTable tblMain = new PdfPTable(1);
            tblMain.WidthPercentage = 100;
            tblMain.DefaultCell.Padding = 4.5f;
            tblMain.DefaultCell.Border = 0;

            Chunk header1 = new Chunk("FINDSTAFF PLACEMENT SERVICES, INC.", arial);
            PdfPCell rowHeader1 = new PdfPCell(new Phrase(header1));
            rowHeader1.Border = 0;
            rowHeader1.HorizontalAlignment = 1;
            rowHeader1.Colspan = 1;
            tblMain.AddCell(rowHeader1);
            
            Chunk header3 = new Chunk("''Pioneer in the Recruitment Industry''", arial);
            PdfPCell rowHeader3 = new PdfPCell(new Phrase(header3));
            rowHeader3.Border = 0;
            rowHeader3.HorizontalAlignment = 1;
            rowHeader3.Colspan = 1;
            tblMain.AddCell(rowHeader3);

            Chunk header4 = new Chunk("2082 F. Benitez St., Malate, Manila, Philippines 1004", arial);
            PdfPCell rowHeader4 = new PdfPCell(new Phrase(header4));
            rowHeader4.Border = 0;
            rowHeader4.HorizontalAlignment = 1;
            rowHeader4.Colspan = 1;
            tblMain.AddCell(rowHeader4);

            Chunk header5 = new Chunk("Tel. No. (+632) 5214116", arial);
            PdfPCell rowHeader5 = new PdfPCell(new Phrase(header5));
            rowHeader5.Border = 0;
            rowHeader5.HorizontalAlignment = 1;
            rowHeader5.Colspan = 1;
            tblMain.AddCell(rowHeader5);

            Chunk header6 = new Chunk("\n \n", arial);
            PdfPCell rowHeader6 = new PdfPCell(new Phrase(header6));
            rowHeader6.Border = 0;
            rowHeader6.HorizontalAlignment = 1;
            rowHeader6.Colspan = 1;
            tblMain.AddCell(rowHeader6);

            PdfPCell TotDate = new PdfPCell(new Phrase(DateTime.Now.ToString(), arial));
            TotDate.Border = 0;
            TotDate.Colspan = 1;
            TotDate.HorizontalAlignment = 2;
            tblMain.AddCell(TotDate);

            Chunk header7 = new Chunk("\n \n", arial);
            PdfPCell rowHeader7 = new PdfPCell(new Phrase(header7));
            rowHeader7.Border = 0;
            rowHeader7.HorizontalAlignment = 1;
            rowHeader7.Colspan = 1;
            tblMain.AddCell(rowHeader7);

            PdfPTable table = new PdfPTable(dgvReports.Columns.Count);
            for (int j = 0; j < dgvReports.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgvReports.Columns[j].HeaderText));
                table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            }
            table.HeaderRows = 1;

            for (int i = 0; i < dgvReports.Rows.Count; i++)
            {
                for (int k = 0; k < dgvReports.Columns.Count; k++)
                {
                    if (dgvReports[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgvReports[k, i].Value.ToString()));
                        table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    }
                }
            }

            tblMain.AddCell(table);

            doc.Add(tblMain);
            return doc;
        }
    }
}
