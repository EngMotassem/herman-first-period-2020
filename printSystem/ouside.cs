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
    public partial class ouside : MetroFramework.Forms.MetroForm
    {
        public ouside()
        {
            InitializeComponent();
            txtDay.Text = dateTimePicker1.Value.ToString("dddd", new System.Globalization.CultureInfo("ar-AE"));
        }

        private void ouside_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.reportTypes' table. You can move, or remove it, as needed.
            this.reportTypesTableAdapter.Fill(this.dataDataSet.reportTypes);
            // TODO: This line of code loads data into the 'dataDataSet.studentData' table. You can move, or remove it, as needed.
            this.studentDataTableAdapter.Fill(this.dataDataSet.studentData);

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            this.studentDataTableAdapter.FillByname(dataDataSet.studentData, txtsearch.Text);
        }

        private void devgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void devgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // عرض قرار سابق من الجريد
                if (e.ColumnIndex == 14)
                {

                 int count=   studentDataTableAdapter.FillBy(dataDataSet.studentData, Convert.ToDecimal(devgrid.Rows[e.RowIndex].Cells[0].Value));


                    if (count > 0)
                    {
                        txtseatNo.Text = dataDataSet.studentData.Rows[0]["seatno"].ToString();
                        txtname.Text = dataDataSet.studentData.Rows[0]["stname"].ToString();
                        txtschool.Text = dataDataSet.studentData.Rows[0]["scname"].ToString();
                        regionText.Text = dataDataSet.studentData.Rows[0]["examScid"].ToString();
                        seerTxt.Text = dataDataSet.studentData.Rows[0]["examscname"].ToString();
                        lagnaNumTxt.Text = dataDataSet.studentData.Rows[0]["seercode"].ToString();
                        typedesc.Text = dataDataSet.studentData.Rows[0]["type_adesc"].ToString();
                        stType.Text = dataDataSet.studentData.Rows[0]["st_type"].ToString();
                       string  depatText = dataDataSet.studentData.Rows[0]["typecode"].ToString();
                        string gender = dataDataSet.studentData.Rows[0]["sex"].ToString();

                        int typecode = Convert.ToInt32(dataDataSet.studentData.Rows[0]["typecode"].ToString());

                        devgrid.Refresh();
                       // if (cmbcourse.SelectedIndex == -1)
                    }

                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDay.Text = dateTimePicker1.Value.ToString("dddd", new System.Globalization.CultureInfo("ar-AE"));
        }
    }
}
