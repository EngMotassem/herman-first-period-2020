namespace printSystem
{
    partial class showAllStudentsData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.decTbl1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new printSystem.dataDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.decTbl1TableAdapter = new printSystem.dataDataSetTableAdapters.decTbl1TableAdapter();
            this.decTbl11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decTbl11TableAdapter = new printSystem.dataDataSetTableAdapters.decTbl11TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl11BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // decTbl1BindingSource
            // 
            this.decTbl1BindingSource.DataMember = "decTbl1";
            this.decTbl1BindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.decTbl11BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "printSystem.ReportOfStudentnames 2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(39, 11);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(709, 400);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // decTbl1TableAdapter
            // 
            this.decTbl1TableAdapter.ClearBeforeFill = true;
            // 
            // decTbl11BindingSource
            // 
            this.decTbl11BindingSource.DataMember = "decTbl11";
            this.decTbl11BindingSource.DataSource = this.dataDataSet;
            // 
            // decTbl11TableAdapter
            // 
            this.decTbl11TableAdapter.ClearBeforeFill = true;
            // 
            // showAllStudentsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "showAllStudentsData";
            this.Text = "showAllStudentsData";
            this.Load += new System.EventHandler(this.showAllStudentsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.decTbl1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl11BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource decTbl1BindingSource;
        private dataDataSet dataDataSet;
        private dataDataSetTableAdapters.decTbl1TableAdapter decTbl1TableAdapter;
        private System.Windows.Forms.BindingSource decTbl11BindingSource;
        private dataDataSetTableAdapters.decTbl11TableAdapter decTbl11TableAdapter;
    }
}