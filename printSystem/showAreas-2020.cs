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
    public partial class showAreas_2020 : Form
    {
        public showAreas_2020(string text)
        {
            InitializeComponent();

            this.decTbl11TableAdapter.FillBy3(this.dataDataSet.decTbl11, text);
            this.reportViewer1.RefreshReport();
        }

        private void showAreas_2020_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl1' table. You can move, or remove it, as needed.
          //  this.decTbl1TableAdapter.Fill(this.dataDataSet.decTbl1);


        }
    }
}
