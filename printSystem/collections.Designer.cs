namespace printSystem
{
    partial class collections
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
            this.dataDataSet = new printSystem.dataDataSet();
            this.takenPaperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decTbl11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decTbl11TableAdapter = new printSystem.dataDataSetTableAdapters.decTbl11TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenPaperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl11BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.decTbl11BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "printSystem.RepMahdar - Copy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 1;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // takenPaperBindingSource
            // 
            this.takenPaperBindingSource.DataMember = "takenPaper";
            this.takenPaperBindingSource.DataSource = this.dataDataSet;
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
            // collections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "collections";
            this.Text = "collections";
            this.Load += new System.EventHandler(this.collections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenPaperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl11BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource takenPaperBindingSource;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource decTbl11BindingSource;
        private dataDataSetTableAdapters.decTbl11TableAdapter decTbl11TableAdapter;
    }
}