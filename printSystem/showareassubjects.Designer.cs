namespace printSystem
{
    partial class showareassubjects
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
            this.decTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new printSystem.dataDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.decTblTableAdapter = new printSystem.dataDataSetTableAdapters.decTblTableAdapter();
            this.decTbl3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decTbl3TableAdapter = new printSystem.dataDataSetTableAdapters.decTbl3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.decTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // decTblBindingSource
            // 
            this.decTblBindingSource.DataMember = "decTbl";
            this.decTblBindingSource.DataSource = this.dataDataSet;
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
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "printSystem.ReportOfAllSubjects.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(45, 10);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(778, 405);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // decTblTableAdapter
            // 
            this.decTblTableAdapter.ClearBeforeFill = true;
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
            // showareassubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 441);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "showareassubjects";
            this.Text = "showareassubjects";
            this.Load += new System.EventHandler(this.showareassubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.decTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTbl3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource decTblBindingSource;
        private dataDataSet dataDataSet;
        private dataDataSetTableAdapters.decTblTableAdapter decTblTableAdapter;
        private System.Windows.Forms.BindingSource decTbl3BindingSource;
        private dataDataSetTableAdapters.decTbl3TableAdapter decTbl3TableAdapter;
    }
}