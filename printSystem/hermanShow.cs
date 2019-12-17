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
    public partial class hermanShow : Form
    {
        public hermanShow()
        {
            InitializeComponent();

            //this.hermanTableAdapter1.Fill(this.dataDataSet.herman);

        }

        private void hermanShow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.herman' table. You can move, or remove it, as needed.
            this.hermanTableAdapter.Fill(this.dataDataSet.herman);
            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.

        }
    }
}
