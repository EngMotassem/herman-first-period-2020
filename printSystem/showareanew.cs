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
    public partial class showareanew : Form
    {
        public showareanew(string text)
        {
            InitializeComponent();

            this.decTbl3TableAdapter.FillBy1(this.dataDataSet.decTbl3,text);
            //this.decTbl11TableAdapter.Fill(this.dataDataSet.decTbl11);
            // TODO: This line of code loads data into the 'dataDataSet.decTbl1' table. You can move, or remove it, as needed.
            //  this.decTbl1TableAdapter.Fill(this.dataDataSet.decTbl1);

            this.reportViewer1.RefreshReport();
        }

        private void showareanew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl3' table. You can move, or remove it, as needed.
            this.decTbl3TableAdapter.Fill(this.dataDataSet.decTbl3);
            // TODO: This line of code loads data into the 'dataDataSet.decTbl11' table. You can move, or remove it, as needed.

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
