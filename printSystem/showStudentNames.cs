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
    public partial class showStudentNames : Form
    {
        public showStudentNames()
        {
            InitializeComponent();
        }

        public showStudentNames(string examName,string type)
        {
            InitializeComponent();

            //this.decTblTableAdapter.FillByExamAndHerman(this.dataDataSet.decTbl, examName, type);

          //  this.decTbl11TableAdapter.FillBy5(this.dataDataSet.decTbl11, examName, type);
            this.decTbl1TableAdapter.FillByandOrderByDesN(this.dataDataSet.decTbl1, examName, type);
            


            this.reportViewer1.RefreshReport();


        }

        private void showStudentNames_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl11' table. You can move, or remove it, as needed.
           // this.decTbl11TableAdapter.Fill(this.dataDataSet.decTbl11);
            // TODO: This line of code loads data into the 'dataDataSet.decTbl1' table. You can move, or remove it, as needed.
            //  this.decTbl1TableAdapter.Fill(this.dataDataSet.decTbl1);
            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.
            // this.decTblTableAdapter.Fill(this.dataDataSet.decTbl);
            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.
            // this.decTblTableAdapter.FillByExamAndHerman(this.dataDataSet.decTbl, "الفلسفة", 2);
            //this.reportViewer1.RefreshReport();
            // this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
