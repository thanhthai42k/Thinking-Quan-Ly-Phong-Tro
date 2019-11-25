namespace QLPT
{
    partial class FPrint
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
            this.HoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thinkingDataSet6 = new QLPT.thinkingDataSet6();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoadonTableAdapter = new QLPT.thinkingDataSet6TableAdapters.HoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thinkingDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // HoadonBindingSource
            // 
            this.HoadonBindingSource.DataMember = "Hoadon";
            this.HoadonBindingSource.DataSource = this.thinkingDataSet6;
            // 
            // thinkingDataSet6
            // 
            this.thinkingDataSet6.DataSetName = "thinkingDataSet6";
            this.thinkingDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLPT.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(762, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // HoadonTableAdapter
            // 
            this.HoadonTableAdapter.ClearBeforeFill = true;
            // 
            // FPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 452);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.FPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thinkingDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoadonBindingSource;
        private thinkingDataSet6 thinkingDataSet6;
        private thinkingDataSet6TableAdapters.HoadonTableAdapter HoadonTableAdapter;
    }
}