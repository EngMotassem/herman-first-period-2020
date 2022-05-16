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
    public partial class showlagnacount : Form
    {
        public showlagnacount(string text)
        {
            InitializeComponent();

            // this.decTbl3TableAdapter.FillByexam(this.dataDataSet.decTbl3,text);
            this.decTbl3TableAdapter.Fill(this.dataDataSet.decTbl3);

            this.reportViewer1.RefreshReport();
        }

        private void showlagnacount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl3' table. You can move, or remove it, as needed.
           // this.decTbl3TableAdapter.Fill(this.dataDataSet.decTbl3);
            // TODO: This line of code loads data into the 'dataDataSet.decTbl1' table. You can move, or remove it, as needed.
         //   this.decTbl1TableAdapter.Fill(this.dataDataSet.decTbl1);

        }
    }
}
