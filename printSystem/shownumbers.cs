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
    public partial class shownumbers : Form
    {
        public shownumbers(string text)
        {
            InitializeComponent();

            this.decTbl11TableAdapter.FillBy3(this.dataDataSet.decTbl11,text);
            this.reportViewer1.RefreshReport();
        }

        private void shownumbers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl11' table. You can move, or remove it, as needed.
            //   this.decTbl11TableAdapter.Fill(this.dataDataSet.decTbl11);
            // TODO: This line of code loads data into the 'dataDataSet.decTbl1' table. You can move, or remove it, as needed.
           

        }
    }
}
