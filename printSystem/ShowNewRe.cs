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
    public partial class ShowNewRe : Form
    {
        public ShowNewRe()
        {
            InitializeComponent();
        }

        private void ShowNewRe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.
           // this.decTblTableAdapter.FillByAllData(this.dataDataSet.decTbl);
           // this.reportViewer1.RefreshReport();

        }

        public ShowNewRe(string examName)
        {
            InitializeComponent();

            //this.decTblTableAdapter.FillBy3(this.dataDataSet.decTbl,examName);
            this.decTblTableAdapter.FillByEdyTypeAndExam(this.dataDataSet.decTbl, examName);
            this.reportViewer1.RefreshReport();
        }



    }
}
