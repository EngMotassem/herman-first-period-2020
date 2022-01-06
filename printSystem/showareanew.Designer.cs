namespace printSystem
{
    partial class showareanew
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
            this.decTbl11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new printSystem.dataDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.decTbl1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decTbl1TableAdapter = new printSystem.dataDataSetTableAdapters.decTbl1TableAdapter();
            this.decTbl11TableAdapter = new printSystem.dataDataSetTableAdapters.decTbl11TableAdapter();
            this.decTbl3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decTbl3TableAdapter = new printSystem.dataDataSetTableAdapters.decTbl3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // decTbl11BindingSource
            // 
            this.decTbl11BindingSource.DataMember = "decTbl11";
            this.decTbl11BindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.decTbl3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "printSystem.ReportOfStudentnames 5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 15);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1034, 524);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // decTbl1BindingSource
            // 
            this.decTbl1BindingSource.DataMember = "decTbl1";
            this.decTbl1BindingSource.DataSource = this.dataDataSet;
            // 
            // decTbl1TableAdapter
            // 
            this.decTbl1TableAdapter.ClearBeforeFill = true;
            // 
            // decTbl11TableAdapter
            // 
            this.decTbl11TableAdapter.ClearBeforeFill = true;
            // 
            // decTbl3BindingSource
            // 
            this.decTbl3BindingSource.DataMember = "decTbl3";
            this.decTbl3BindingSource.DataSource = this.dataDataSet;
            // 
            // decTbl3TableAdapter
            // 
            this.decTbl3TableAdapter.ClearBeforeFill = true;
            // 
            // showareanew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "showareanew";
            this.Text = "showareanew";
            this.Load += new System.EventHandler(this.showareanew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.decTbl11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource decTbl1BindingSource;
        private dataDataSet dataDataSet;
        private dataDataSetTableAdapters.decTbl1TableAdapter decTbl1TableAdapter;
        private System.Windows.Forms.BindingSource decTbl11BindingSource;
        private dataDataSetTableAdapters.decTbl11TableAdapter decTbl11TableAdapter;
        private System.Windows.Forms.BindingSource decTbl3BindingSource;
        private dataDataSetTableAdapters.decTbl3TableAdapter decTbl3TableAdapter;
    }
}