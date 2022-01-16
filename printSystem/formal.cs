using System;
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
    public partial class formal : Form
    {
        public formal(string examName)
        {
            InitializeComponent();
            this.decTbl3TableAdapter.FillByexam(this.dataDataSet.decTbl3, examName);

            this.reportViewer1.RefreshReport();
        }

        private void formal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl3' table. You can move, or remove it, as needed.
            //this.decTbl3TableAdapter.Fill(this.dataDataSet.decTbl3);
            // TODO: This line of code loads data into the 'dataDataSet.decTbl1' table. You can move, or remove it, as needed.
           // this.decTbl1TableAdapter.Fill(this.dataDataSet.decTbl1);

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
