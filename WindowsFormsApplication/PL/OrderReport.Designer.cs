namespace WindowsFormsApplication.PL
{
    partial class OrderReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.testDataSet2 = new WindowsFormsApplication.testDataSet2();
            this.testDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "OrderDataSetReport";
            reportDataSource2.Value = this.testDataSet2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication.PL.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(545, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // testDataSet2
            // 
            this.testDataSet2.DataSetName = "testDataSet2";
            this.testDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSet2BindingSource
            // 
            this.testDataSet2BindingSource.DataSource = this.testDataSet2;
            this.testDataSet2BindingSource.Position = 0;
            // 
            // OrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 357);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OrderReport";
            this.Text = "Order Report";
            this.Load += new System.EventHandler(this.OrderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource testDataSet2BindingSource;
        private testDataSet2 testDataSet2;
    }
}