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
    public partial class showareassubjects : Form
    {
        public showareassubjects()
        {
            InitializeComponent();
        }

        private void showareassubjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl3' table. You can move, or remove it, as needed.
            this.decTbl3TableAdapter.Fill(this.dataDataSet.decTbl3);
            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.
            // this.decTblTableAdapter.Fill(this.dataDataSet.decTbl);

            //  this.decTblTableAdapter.Fill(this.dataDataSet.decTbl);
            //this.decTblTableAdapter.FillByDepatrment(this.dataDataSet.decTbl, "1");


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
