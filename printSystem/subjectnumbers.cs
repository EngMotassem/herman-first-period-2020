﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printSystem
{
    public partial class subjectnumbers : Form
    {
        public DataTable dt = new DataTable();

        public subjectnumbers()
        {

            this.decTblTableAdapter.Fill(this.dataDataSet.decTbl);

            this.reportViewer1.RefreshReport();
        }

        public subjectnumbers(DataTable datatable)
        {
            dt = datatable;

            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rts2 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);


            reportViewer1.LocalReport.DataSources.Add(rts2);

            // this.Hide();
            this.reportViewer1.RefreshReport();
        }

        private void subjectnumbers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.
            this.decTblTableAdapter.Fill(this.dataDataSet.decTbl);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
