
namespace FloraWarehouseManagement.Forms.Sales
{
    partial class SalesMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesMain));
            this.btnOutgoingInvoices = new System.Windows.Forms.Button();
            this.btnPaymentOperations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOutgoingInvoices
            // 
            this.btnOutgoingInvoices.BackColor = System.Drawing.Color.White;
            this.btnOutgoingInvoices.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutgoingInvoices.Location = new System.Drawing.Point(41, 49);
            this.btnOutgoingInvoices.Name = "btnOutgoingInvoices";
            this.btnOutgoingInvoices.Size = new System.Drawing.Size(150, 33);
            this.btnOutgoingInvoices.TabIndex = 0;
            this.btnOutgoingInvoices.Text = "Излезни фактури";
            this.btnOutgoingInvoices.UseVisualStyleBackColor = false;
            this.btnOutgoingInvoices.Click += new System.EventHandler(this.btnOutgoingInvoices_Click);
            // 
            // btnPaymentOperations
            // 
            this.btnPaymentOperations.BackColor = System.Drawing.Color.White;
            this.btnPaymentOperations.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentOperations.Location = new System.Drawing.Point(41, 88);
            this.btnPaymentOperations.Name = "btnPaymentOperations";
            this.btnPaymentOperations.Size = new System.Drawing.Size(150, 33);
            this.btnPaymentOperations.TabIndex = 2;
            this.btnPaymentOperations.Text = "Платен промет";
            this.btnPaymentOperations.UseVisualStyleBackColor = false;
            this.btnPaymentOperations.Click += new System.EventHandler(this.btnPaymentOperations_Click);
            // 
            // SalesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.btnPaymentOperations);
            this.Controls.Add(this.btnOutgoingInvoices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажба";
            this.Load += new System.EventHandler(this.SalesMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOutgoingInvoices;
        private System.Windows.Forms.Button btnPaymentOperations;
    }
}