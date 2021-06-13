
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutgoingInvoices));
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.gbInvoiceInfo = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbInvCounter = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.tbTax = new System.Windows.Forms.TextBox();
            this.tbPriceWithoutTax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbValuta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInvoiceItems = new System.Windows.Forms.Button();
            this.cbDocType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbInvoiceNum = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderCustomer = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.gbInvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoices.Location = new System.Drawing.Point(0, 353);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.Size = new System.Drawing.Size(974, 330);
            this.dgvInvoices.TabIndex = 3;
            this.dgvInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellClick);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(186)))), ((int)(((byte)(65)))));
            this.pnlControls.Controls.Add(this.gbInvoiceInfo);
            this.pnlControls.Location = new System.Drawing.Point(0, -2);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(974, 355);
            this.pnlControls.TabIndex = 2;
            this.pnlControls.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // gbInvoiceInfo
            // 
            this.gbInvoiceInfo.Controls.Add(this.btnDelete);
            this.gbInvoiceInfo.Controls.Add(this.tbInvCounter);
            this.gbInvoiceInfo.Controls.Add(this.label14);
            this.gbInvoiceInfo.Controls.Add(this.btnNew);
            this.gbInvoiceInfo.Controls.Add(this.btnPrint);
            this.gbInvoiceInfo.Controls.Add(this.label13);
            this.gbInvoiceInfo.Controls.Add(this.label12);
            this.gbInvoiceInfo.Controls.Add(this.label11);
            this.gbInvoiceInfo.Controls.Add(this.tbTotalPrice);
            this.gbInvoiceInfo.Controls.Add(this.tbTax);
            this.gbInvoiceInfo.Controls.Add(this.tbPriceWithoutTax);
            this.gbInvoiceInfo.Controls.Add(this.label10);
            this.gbInvoiceInfo.Controls.Add(this.label9);
            this.gbInvoiceInfo.Controls.Add(this.label8);
            this.gbInvoiceInfo.Controls.Add(this.tbDescription);
            this.gbInvoiceInfo.Controls.Add(this.label7);
            this.gbInvoiceInfo.Controls.Add(this.tbValuta);
            this.gbInvoiceInfo.Controls.Add(this.label6);
            this.gbInvoiceInfo.Controls.Add(this.btnInvoiceItems);
            this.gbInvoiceInfo.Controls.Add(this.cbDocType);
            this.gbInvoiceInfo.Controls.Add(this.label5);
            this.gbInvoiceInfo.Controls.Add(this.mtbDate);
            this.gbInvoiceInfo.Controls.Add(this.label4);
            this.gbInvoiceInfo.Controls.Add(this.label3);
            this.gbInvoiceInfo.Controls.Add(this.tbCustomer);
            this.gbInvoiceInfo.Controls.Add(this.label2);
            this.gbInvoiceInfo.Controls.Add(this.mtbInvoiceNum);
            this.gbInvoiceInfo.Controls.Add(this.label1);
            this.gbInvoiceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInvoiceInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvoiceInfo.Location = new System.Drawing.Point(12, 14);
            this.gbInvoiceInfo.Name = "gbInvoiceInfo";
            this.gbInvoiceInfo.Size = new System.Drawing.Size(805, 335);
            this.gbInvoiceInfo.TabIndex = 0;
            this.gbInvoiceInfo.TabStop = false;
            this.gbInvoiceInfo.Text = "Податоци за документот";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(655, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 45);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Избриши";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbInvCounter
            // 
            this.tbInvCounter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvCounter.Location = new System.Drawing.Point(156, 57);
            this.tbInvCounter.Name = "tbInvCounter";
            this.tbInvCounter.Size = new System.Drawing.Size(58, 27);
            this.tbInvCounter.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(156, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "Бројач:";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(655, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 45);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Нова";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(655, 237);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 45);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Печати";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(581, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "ден.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(581, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "ден.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(581, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "ден.";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPrice.Location = new System.Drawing.Point(438, 119);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(140, 29);
            this.tbTotalPrice.TabIndex = 19;
            this.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTax
            // 
            this.tbTax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTax.Location = new System.Drawing.Point(438, 78);
            this.tbTax.Name = "tbTax";
            this.tbTax.ReadOnly = true;
            this.tbTax.Size = new System.Drawing.Size(140, 29);
            this.tbTax.TabIndex = 18;
            this.tbTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPriceWithoutTax
            // 
            this.tbPriceWithoutTax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceWithoutTax.Location = new System.Drawing.Point(438, 31);
            this.tbPriceWithoutTax.Name = "tbPriceWithoutTax";
            this.tbPriceWithoutTax.ReadOnly = true;
            this.tbPriceWithoutTax.Size = new System.Drawing.Size(140, 29);
            this.tbPriceWithoutTax.TabIndex = 17;
            this.tbPriceWithoutTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(370, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Вкупно:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "ДДВ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(376, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Износ:";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(246, 237);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(341, 77);
            this.tbDescription.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Забелешка:";
            // 
            // tbValuta
            // 
            this.tbValuta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValuta.Location = new System.Drawing.Point(246, 57);
            this.tbValuta.Name = "tbValuta";
            this.tbValuta.Size = new System.Drawing.Size(78, 27);
            this.tbValuta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Валута:";
            // 
            // btnInvoiceItems
            // 
            this.btnInvoiceItems.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInvoiceItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInvoiceItems.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceItems.Location = new System.Drawing.Point(18, 283);
            this.btnInvoiceItems.Name = "btnInvoiceItems";
            this.btnInvoiceItems.Size = new System.Drawing.Size(75, 31);
            this.btnInvoiceItems.TabIndex = 9;
            this.btnInvoiceItems.Text = "Ставки";
            this.btnInvoiceItems.UseVisualStyleBackColor = false;
            this.btnInvoiceItems.Click += new System.EventHandler(this.btnInvoiceItems_Click);
            // 
            // cbDocType
            // 
            this.cbDocType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocType.FormattingEnabled = true;
            this.cbDocType.Items.AddRange(new object[] {
            "Испратница/Фактура",
            "Испратница",
            "Фактура"});
            this.cbDocType.Location = new System.Drawing.Point(18, 237);
            this.cbDocType.Name = "cbDocType";
            this.cbDocType.Size = new System.Drawing.Size(127, 25);
            this.cbDocType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Вид на документ:";
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
            // errorProviderCustomer
            // 
            this.errorProviderCustomer.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCustomer)).EndInit();
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
        private System.Windows.Forms.Button btnInvoiceItems;
        private System.Windows.Forms.ComboBox cbDocType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbValuta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.TextBox tbPriceWithoutTax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ErrorProvider errorProviderCustomer;
        private System.Windows.Forms.TextBox tbInvCounter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
    }
}