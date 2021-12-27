using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printSystem
{
    public partial class frmReportsMahader : Form
    {
        public DataTable dt = new DataTable();
        string filename = "";
        string seercode = "";

        public frmReportsMahader(int  idd)
        {
            InitializeComponent();
            id = idd; this.Hide();
            this.dataDataSet.Clear();
            this.decTblTableAdapter.FillBy(this.dataDataSet.decTbl, id);
            this.reportViewer1.RefreshReport();
        }

        public void SavePDF(ReportViewer viewer, string savePath )

        {

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;
            byte[] bytes = viewer.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            using (FileStream fs = new FileStream(savePath+filename+".pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

         
        }
        public frmReportsMahader(DataTable datatable)
        {
            InitializeComponent();
            dt = datatable;

            

            seercode = dt.Rows[0]["seercode"].ToString();

            filename = seercode + dt.Rows[0]["studentname"].ToString();





            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rts2 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);


            reportViewer1.LocalReport.DataSources.Add(rts2);

            this.Hide();
            this.reportViewer1.RefreshReport();
        }

        int id = 0;

        private void frmReports_Load(object sender, EventArgs e)
        {
          
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void reportViewer1_RenderingComplete(object sender, Microsoft.Reporting.WinForms.RenderingCompleteEventArgs e)
        {
            reportViewer1.PrintDialog();

            SavePDF(reportViewer1, @"C:\destination\NewDirectory\");
          // reportViewer1.PrinterSettings.IsDirectPrintingSupported();
        }
    }
}
