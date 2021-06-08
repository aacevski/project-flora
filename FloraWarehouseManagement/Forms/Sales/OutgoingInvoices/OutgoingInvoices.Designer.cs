
namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices
{
    partial class OutgoingInvoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutgoingInvoices));
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.gbInvoiceInfo = new System.Windows.Forms.GroupBox();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbInvoiceNum = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.gbInvoiceInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.Location = new System.Drawing.Point(0, 353);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(974, 330);
            this.dgvInvoices.TabIndex = 3;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(186)))), ((int)(((byte)(65)))));
            this.pnlControls.Controls.Add(this.gbInvoiceInfo);
            this.pnlControls.Location = new System.Drawing.Point(0, -2);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(974, 355);
            this.pnlControls.TabIndex = 2;
            // 
            // gbInvoiceInfo
            // 
            this.gbInvoiceInfo.Controls.Add(this.mtbDate);
            this.gbInvoiceInfo.Controls.Add(this.label4);
            this.gbInvoiceInfo.Controls.Add(this.label3);
            this.gbInvoiceInfo.Controls.Add(this.tbCustomer);
            this.gbInvoiceInfo.Controls.Add(this.label2);
            this.gbInvoiceInfo.Controls.Add(this.mtbInvoiceNum);
            this.gbInvoiceInfo.Controls.Add(this.label1);
            this.gbInvoiceInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvoiceInfo.Location = new System.Drawing.Point(12, 14);
            this.gbInvoiceInfo.Name = "gbInvoiceInfo";
            this.gbInvoiceInfo.Size = new System.Drawing.Size(534, 335);
            this.gbInvoiceInfo.TabIndex = 0;
            this.gbInvoiceInfo.TabStop = false;
            this.gbInvoiceInfo.Text = "Податоци за документот";
            // 
            // mtbDate
            // 
            this.mtbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDate.Location = new System.Drawing.Point(18, 178);
            this.mtbDate.Mask = "00.00.00";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.ReadOnly = true;
            this.mtbDate.Size = new System.Drawing.Size(85, 24);
            this.mtbDate.TabIndex = 6;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Датум:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(223, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "(F1)";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(18, 115);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.ReadOnly = true;
            this.tbCustomer.Size = new System.Drawing.Size(199, 24);
            this.tbCustomer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Купувач:";
            // 
            // mtbInvoiceNum
            // 
            this.mtbInvoiceNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbInvoiceNum.Location = new System.Drawing.Point(18, 57);
            this.mtbInvoiceNum.Mask = "00000/0000";
            this.mtbInvoiceNum.Name = "mtbInvoiceNum";
            this.mtbInvoiceNum.ReadOnly = true;
            this.mtbInvoiceNum.Size = new System.Drawing.Size(85, 24);
            this.mtbInvoiceNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Број на фактура:";
            // 
            // OutgoingInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.pnlControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(990, 720);
            this.Name = "OutgoingInvoices";
            this.Text = "Излезни фактури";
            this.Load += new System.EventHandler(this.OutgoingInvoices_Load);
            this.SizeChanged += new System.EventHandler(this.OutgoingInvoices_SizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OutgoingInvoices_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.gbInvoiceInfo.ResumeLayout(false);
            this.gbInvoiceInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.GroupBox gbInvoiceInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbInvoiceNum;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label label2;
    }
}