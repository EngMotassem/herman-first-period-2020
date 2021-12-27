using MetroFramework;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printSystem
{
    public partial class orderd : Form
    {


       dataDataSetTableAdapters.decTbl11TableAdapter adabdec = new dataDataSetTableAdapters.decTbl11TableAdapter();

        List<String> allCodes = new List<String>();


        public orderd(List<string> allCodes)
        {
            InitializeComponent();
            foreach (String cod in allCodes)
            {

                adabdec.FillByseercode(dataDataSet1.decTbl11, "اللغة الفرنسية", "2", cod);

                String
                    pp = dataDataSet1.decTbl11.Rows[0][2].ToString();


                SavePDF(reportViewer1, @"C:\destination\NewDirectory\", cod);
                reportViewer1.RefreshReport();


            }



        }

        public void SavePDF(ReportViewer viewer, string savePath ,string filename)

        {

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;
            byte[] bytes = viewer.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            using (FileStream fs = new FileStream(savePath + filename + ".pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }


        }

        private void orderd_Load(object sender, EventArgs e)
        {


           







            // }



        }

        private void reportViewer1_RenderingComplete(object sender, Microsoft.Reporting.WinForms.RenderingCompleteEventArgs e)
        {
            reportViewer1.PrintDialog();

           // SavePDF(reportViewer1, @"C:\destination\NewDirectory\");
            // reportViewer1.PrinterSettings.IsDirectPrintingSupported();
        }


        public void getcodes()
        {

            int count = adabdec.FillByexamandcode(dataDataSet1.decTbl11, "اللغة الفرنسية", "2");

            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    String code = dataDataSet1.decTbl11.Rows[i]["type_str"].ToString();

                    allCodes.Add(code);




                }
            }




        }
    }
}
