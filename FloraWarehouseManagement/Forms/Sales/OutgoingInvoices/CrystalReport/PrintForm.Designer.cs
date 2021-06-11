
namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.CrystalReport
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.crptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crptInvoices = new FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.CrystalReport.OutgoingInvoicesReport();
            this.SuspendLayout();
            // 
            // crptViewer
            // 
            this.crptViewer.ActiveViewIndex = -1;
            this.crptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptViewer.Location = new System.Drawing.Point(0, 0);
            this.crptViewer.Name = "crptViewer";
            this.crptViewer.Size = new System.Drawing.Size(800, 450);
            this.crptViewer.TabIndex = 0;
            this.crptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crptViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintForm";
            this.Text = "Печатење";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptViewer;
        private OutgoingInvoicesReport crptInvoices;
    }
}