
namespace FloraWarehouseManagement.Forms
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.rbtnProduct = new System.Windows.Forms.RadioButton();
            this.rbtnCode = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProductInfo = new System.Windows.Forms.GroupBox();
            this.mtbHelpCode = new System.Windows.Forms.MaskedTextBox();
            this.mtbCode = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTaxGroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.tbProductNameLatin = new System.Windows.Forms.TextBox();
            this.mtbGroupCode = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDDV = new System.Windows.Forms.CheckBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlControls.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.gbProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(186)))), ((int)(((byte)(65)))));
            this.pnlControls.Controls.Add(this.gbButtons);
            this.pnlControls.Controls.Add(this.label3);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.gbProductInfo);
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(974, 355);
            this.pnlControls.TabIndex = 0;
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btnSearch);
            this.gbButtons.Controls.Add(this.tbSearch);
            this.gbButtons.Controls.Add(this.label11);
            this.gbButtons.Controls.Add(this.btnEdit);
            this.gbButtons.Controls.Add(this.btnDelete);
            this.gbButtons.Controls.Add(this.btnSave);
            this.gbButtons.Controls.Add(this.pnlFilter);
            this.gbButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbButtons.Location = new System.Drawing.Point(640, 18);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(314, 319);
            this.gbButtons.TabIndex = 26;
            this.gbButtons.TabStop = false;
            this.gbButtons.Move += new System.EventHandler(this.Products_SizeChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(237, 254);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 26);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(13, 254);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(218, 26);
            this.tbSearch.TabIndex = 26;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Пребарување:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(91, 85);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 53);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Промени";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(91, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 53);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Избриши";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(91, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 53);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Внеси";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.rbtnProduct);
            this.pnlFilter.Controls.Add(this.rbtnCode);
            this.pnlFilter.Location = new System.Drawing.Point(13, 284);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(218, 24);
            this.pnlFilter.TabIndex = 29;
            // 
            // rbtnProduct
            // 
            this.rbtnProduct.AutoSize = true;
            this.rbtnProduct.Location = new System.Drawing.Point(112, 0);
            this.rbtnProduct.Name = "rbtnProduct";
            this.rbtnProduct.Size = new System.Drawing.Size(103, 24);
            this.rbtnProduct.TabIndex = 32;
            this.rbtnProduct.TabStop = true;
            this.rbtnProduct.Text = "по артикл";
            this.rbtnProduct.UseVisualStyleBackColor = true;
            // 
            // rbtnCode
            // 
            this.rbtnCode.AutoSize = true;
            this.rbtnCode.Location = new System.Drawing.Point(0, 0);
            this.rbtnCode.Name = "rbtnCode";
            this.rbtnCode.Size = new System.Drawing.Size(104, 24);
            this.rbtnCode.TabIndex = 31;
            this.rbtnCode.TabStop = true;
            this.rbtnCode.Text = "по шифра";
            this.rbtnCode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Мерка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Артикл";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шифра";
            // 
            // gbProductInfo
            // 
            this.gbProductInfo.Controls.Add(this.mtbHelpCode);
            this.gbProductInfo.Controls.Add(this.mtbCode);
            this.gbProductInfo.Controls.Add(this.label4);
            this.gbProductInfo.Controls.Add(this.cbTaxGroup);
            this.gbProductInfo.Controls.Add(this.label9);
            this.gbProductInfo.Controls.Add(this.cbUnit);
            this.gbProductInfo.Controls.Add(this.tbOrigin);
            this.gbProductInfo.Controls.Add(this.tbProductNameLatin);
            this.gbProductInfo.Controls.Add(this.mtbGroupCode);
            this.gbProductInfo.Controls.Add(this.label8);
            this.gbProductInfo.Controls.Add(this.label6);
            this.gbProductInfo.Controls.Add(this.tbProductName);
            this.gbProductInfo.Controls.Add(this.tbDescription);
            this.gbProductInfo.Controls.Add(this.label7);
            this.gbProductInfo.Controls.Add(this.label5);
            this.gbProductInfo.Controls.Add(this.cbDDV);
            this.gbProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductInfo.Location = new System.Drawing.Point(12, 18);
            this.gbProductInfo.Name = "gbProductInfo";
            this.gbProductInfo.Size = new System.Drawing.Size(613, 319);
            this.gbProductInfo.TabIndex = 25;
            this.gbProductInfo.TabStop = false;
            this.gbProductInfo.Text = "Податоци за артикл";
            // 
            // mtbHelpCode
            // 
            this.mtbHelpCode.AllowPromptAsInput = false;
            this.mtbHelpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbHelpCode.Location = new System.Drawing.Point(294, 48);
            this.mtbHelpCode.Mask = "0000000";
            this.mtbHelpCode.Name = "mtbHelpCode";
            this.mtbHelpCode.Size = new System.Drawing.Size(74, 22);
            this.mtbHelpCode.TabIndex = 25;
            this.mtbHelpCode.ValidatingType = typeof(int);
            this.mtbHelpCode.Click += new System.EventHandler(this.mtbHelpCode_Click);
            // 
            // mtbCode
            // 
            this.mtbCode.AllowPromptAsInput = false;
            this.mtbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCode.Location = new System.Drawing.Point(25, 44);
            this.mtbCode.Mask = "0000000";
            this.mtbCode.Name = "mtbCode";
            this.mtbCode.Size = new System.Drawing.Size(74, 22);
            this.mtbCode.TabIndex = 20;
            this.mtbCode.ValidatingType = typeof(int);
            this.mtbCode.Click += new System.EventHandler(this.mtbCode_Click);
            this.mtbCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCode_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Даночна група";
            // 
            // cbTaxGroup
            // 
            this.cbTaxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaxGroup.FormattingEnabled = true;
            this.cbTaxGroup.Items.AddRange(new object[] {
            "5",
            "18"});
            this.cbTaxGroup.Location = new System.Drawing.Point(24, 207);
            this.cbTaxGroup.Name = "cbTaxGroup";
            this.cbTaxGroup.Size = new System.Drawing.Size(50, 28);
            this.cbTaxGroup.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Забелешка";
            // 
            // cbUnit
            // 
            this.cbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "бр",
            "кг",
            "м",
            "л",
            "мл"});
            this.cbUnit.Location = new System.Drawing.Point(24, 152);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(50, 28);
            this.cbUnit.TabIndex = 6;
            // 
            // tbOrigin
            // 
            this.tbOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrigin.Location = new System.Drawing.Point(292, 147);
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.Size = new System.Drawing.Size(145, 22);
            this.tbOrigin.TabIndex = 15;
            // 
            // tbProductNameLatin
            // 
            this.tbProductNameLatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductNameLatin.Location = new System.Drawing.Point(292, 97);
            this.tbProductNameLatin.Name = "tbProductNameLatin";
            this.tbProductNameLatin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbProductNameLatin.Size = new System.Drawing.Size(145, 22);
            this.tbProductNameLatin.TabIndex = 17;
            // 
            // mtbGroupCode
            // 
            this.mtbGroupCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbGroupCode.Location = new System.Drawing.Point(25, 277);
            this.mtbGroupCode.Mask = "0000000";
            this.mtbGroupCode.Name = "mtbGroupCode";
            this.mtbGroupCode.Size = new System.Drawing.Size(74, 22);
            this.mtbGroupCode.TabIndex = 22;
            this.mtbGroupCode.ValidatingType = typeof(int);
            this.mtbGroupCode.Click += new System.EventHandler(this.mtbGroupCode_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Латиница";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Помошна шифра";
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductName.Location = new System.Drawing.Point(24, 97);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(145, 22);
            this.tbProductName.TabIndex = 21;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(292, 207);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(293, 96);
            this.tbDescription.TabIndex = 18;
            this.tbDescription.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Потекло";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Групна шифра";
            // 
            // cbDDV
            // 
            this.cbDDV.AutoSize = true;
            this.cbDDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDDV.Location = new System.Drawing.Point(175, 99);
            this.cbDDV.Name = "cbDDV";
            this.cbDDV.Size = new System.Drawing.Size(87, 24);
            this.cbDDV.TabIndex = 9;
            this.cbDDV.Text = "Со ДДВ";
            this.cbDDV.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Location = new System.Drawing.Point(0, 355);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(974, 330);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.pnlControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(990, 720);
            this.Name = "Products";
            this.Text = "Артикли";
            this.Load += new System.EventHandler(this.Products_Load);
            this.SizeChanged += new System.EventHandler(this.Products_SizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Products_KeyUp);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.gbButtons.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.gbProductInfo.ResumeLayout(false);
            this.gbProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.ComboBox cbTaxGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.TextBox tbProductNameLatin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOrigin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbDDV;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtbGroupCode;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.MaskedTextBox mtbCode;
        private System.Windows.Forms.GroupBox gbProductInfo;
        private System.Windows.Forms.MaskedTextBox mtbHelpCode;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbtnProduct;
        private System.Windows.Forms.RadioButton rbtnCode;
    }
}