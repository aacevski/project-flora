
namespace FloraWarehouseManagement.Forms
{
    partial class Logins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logins));
            this.dgvLogins = new System.Windows.Forms.DataGridView();
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogins)).BeginInit();
            this.pnlLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLogins
            // 
            this.dgvLogins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogins.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLogins.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogins.Location = new System.Drawing.Point(12, 111);
            this.dgvLogins.Name = "dgvLogins";
            this.dgvLogins.Size = new System.Drawing.Size(950, 558);
            this.dgvLogins.TabIndex = 0;
            // 
            // pnlLabel
            // 
            this.pnlLabel.Controls.Add(this.lblHeader);
            this.pnlLabel.Location = new System.Drawing.Point(325, 12);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(329, 66);
            this.pnlLabel.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(21, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(290, 43);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Дневник на најави";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(186)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.pnlLabel);
            this.Controls.Add(this.dgvLogins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(990, 720);
            this.MinimumSize = new System.Drawing.Size(990, 720);
            this.Name = "Logins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пријави на системот";
            this.Load += new System.EventHandler(this.Logins_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Logins_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogins)).EndInit();
            this.pnlLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogins;
        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Label lblHeader;
    }
}