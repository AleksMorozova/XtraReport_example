namespace XtraReportTest
{
    partial class MainXtraForm
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
            this.btnFirstReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnSecondReport = new DevExpress.XtraEditors.SimpleButton();
            this.documentViewer = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.btnThirdReport = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnFirstReport
            // 
            this.btnFirstReport.Location = new System.Drawing.Point(555, 23);
            this.btnFirstReport.Name = "btnFirstReport";
            this.btnFirstReport.Size = new System.Drawing.Size(89, 23);
            this.btnFirstReport.TabIndex = 1;
            this.btnFirstReport.Text = "First Report";
            this.btnFirstReport.Click += new System.EventHandler(this.btnFirstReport_Click);
            // 
            // btnSecondReport
            // 
            this.btnSecondReport.Location = new System.Drawing.Point(555, 65);
            this.btnSecondReport.Name = "btnSecondReport";
            this.btnSecondReport.Size = new System.Drawing.Size(89, 23);
            this.btnSecondReport.TabIndex = 2;
            this.btnSecondReport.Text = "Second Report";
            this.btnSecondReport.Click += new System.EventHandler(this.btnSecondReport_Click);
            // 
            // documentViewer
            // 
            this.documentViewer.IsMetric = false;
            this.documentViewer.Location = new System.Drawing.Point(0, 0);
            this.documentViewer.Name = "documentViewer";
            this.documentViewer.Size = new System.Drawing.Size(519, 466);
            this.documentViewer.TabIndex = 0;
            // 
            // btnThirdReport
            // 
            this.btnThirdReport.Location = new System.Drawing.Point(555, 105);
            this.btnThirdReport.Name = "btnThirdReport";
            this.btnThirdReport.Size = new System.Drawing.Size(89, 23);
            this.btnThirdReport.TabIndex = 3;
            this.btnThirdReport.Text = "Third Report";
            this.btnThirdReport.Click += new System.EventHandler(this.btnThirdReport_Click);
            // 
            // MainXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 468);
            this.Controls.Add(this.btnThirdReport);
            this.Controls.Add(this.btnSecondReport);
            this.Controls.Add(this.btnFirstReport);
            this.Controls.Add(this.documentViewer);
            this.Name = "MainXtraForm";
            this.Text = "MainXtraForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer;
        private DevExpress.XtraEditors.SimpleButton btnFirstReport;
        private DevExpress.XtraEditors.SimpleButton btnSecondReport;
        private DevExpress.XtraEditors.SimpleButton btnThirdReport;
    }
}