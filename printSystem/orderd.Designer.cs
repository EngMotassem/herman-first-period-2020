namespace printSystem
{
    partial class orderd
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.decTbl11TableAdapter = new printSystem.dataDataSetTableAdapters.decTbl11TableAdapter();
            this.dataDataSet1 = new printSystem.dataDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "printSystem.RepMahdar - Copy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 15);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1034, 524);
            this.reportViewer1.TabIndex = 2;
            // 
            // decTbl11TableAdapter
            // 
            this.decTbl11TableAdapter.ClearBeforeFill = true;
            // 
            // dataDataSet1
            // 
            this.dataDataSet1.DataSetName = "dataDataSet";
            this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "orderd";
            this.Text = "orderd";
            this.Load += new System.EventHandler(this.orderd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dataDataSetTableAdapters.decTbl11TableAdapter decTbl11TableAdapter;
        private dataDataSet dataDataSet1;
    }
}