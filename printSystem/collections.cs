using MetroFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printSystem
{
    public partial class collections : Form
    {
        public collections()
        {
            InitializeComponent();
        }



        private void collections_Load(object sender, EventArgs e)
        {

           int count= Convert.ToInt32(this.decTbl11TableAdapter.countofseerCodes("اللغة الفرنسية","2"));
            String[] type_str = new String[count];

          // IList list= this.decTbl11TableAdapter.countofseerCodes("اللغة الفرنسة", "2")
           for (int i =0; i < count; i++)
            {
               // type_str[i] = dataDataSet.decTbl11.Rows[i]["type_str"].ToString();
                //

                //Trace.WriteLine(type_str[i]);



            }


            MetroMessageBox.Show(this, count.ToString(), "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);




            // dataDataSet.decTbl11DataTable list = new dataDataSet.decTbl11DataTable();

            //list[0].

            // TODO: This line of code loads data into the 'dataDataSet.decTbl11' table. You can move, or remove it, as needed.
            this.decTbl11TableAdapter.Fill(this.dataDataSet.decTbl11);


            this.reportViewer1.RefreshReport();


        }
    }
}
