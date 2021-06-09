
namespace FloraWarehouseManagement.Forms
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.rbtnTaxNum = new System.Windows.Forms.RadioButton();
            this.rbtnCity = new System.Windows.Forms.RadioButton();
            this.gbProductInfo = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbContactPerson2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPhone2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPhone1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbContactPerson1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.cbBank = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEMBS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTaxNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBankNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBankNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.errorProviderTaxNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlControls.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.gbProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(186)))), ((int)(((byte)(65)))));
            this.pnlControls.Controls.Add(this.gbButtons);
            this.pnlControls.Controls.Add(this.gbProductInfo);
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(974, 409);
            this.pnlControls.TabIndex = 0;
            this.pnlControls.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btnSearch);
            this.gbButtons.Controls.Add(this.tbSearch);
            this.gbButtons.Controls.Add(this.rbtnName);
            this.gbButtons.Controls.Add(this.label11);
            this.gbButtons.Controls.Add(this.btnEdit);
            this.gbButtons.Controls.Add(this.btnDelete);
            this.gbButtons.Controls.Add(this.btnSave);
            this.gbButtons.Controls.Add(this.pnlFilter);
            this.gbButtons.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbButtons.Location = new System.Drawing.Point(640, 18);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(314, 382);
            this.gbButtons.TabIndex = 26;
            this.gbButtons.TabStop = false;
            this.gbButtons.Move += new System.EventHandler(this.Customers_SizeChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(237, 283);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 26);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(13, 283);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(218, 29);
            this.tbSearch.TabIndex = 16;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Checked = true;
            this.rbtnName.Location = new System.Drawing.Point(13, 322);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(91, 25);
            this.rbtnName.TabIndex = 31;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "по назив";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "Пребарување:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnlFilter.Controls.Add(this.rbtnTaxNum);
            this.pnlFilter.Controls.Add(this.rbtnCity);
            this.pnlFilter.Location = new System.Drawing.Point(13, 313);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(295, 48);
            this.pnlFilter.TabIndex = 29;
            // 
            // rbtnTaxNum
            // 
            this.rbtnTaxNum.AutoSize = true;
            this.rbtnTaxNum.Location = new System.Drawing.Point(187, 9);
            this.rbtnTaxNum.Name = "rbtnTaxNum";
            this.rbtnTaxNum.Size = new System.Drawing.Size(104, 25);
            this.rbtnTaxNum.TabIndex = 33;
            this.rbtnTaxNum.TabStop = true;
            this.rbtnTaxNum.Text = "по дан. бр.";
            this.rbtnTaxNum.UseVisualStyleBackColor = true;
            // 
            // rbtnCity
            // 
            this.rbtnCity.AutoSize = true;
            this.rbtnCity.Location = new System.Drawing.Point(99, 9);
            this.rbtnCity.Name = "rbtnCity";
            this.rbtnCity.Size = new System.Drawing.Size(82, 25);
            this.rbtnCity.TabIndex = 32;
            this.rbtnCity.TabStop = true;
            this.rbtnCity.Text = "по град";
            this.rbtnCity.UseVisualStyleBackColor = true;
            // 
            // gbProductInfo
            // 
            this.gbProductInfo.Controls.Add(this.label16);
            this.gbProductInfo.Controls.Add(this.tbContactPerson2);
            this.gbProductInfo.Controls.Add(this.label15);
            this.gbProductInfo.Controls.Add(this.tbPhone2);
            this.gbProductInfo.Controls.Add(this.label14);
            this.gbProductInfo.Controls.Add(this.tbEmail);
            this.gbProductInfo.Controls.Add(this.label13);
            this.gbProductInfo.Controls.Add(this.tbPhone1);
            this.gbProductInfo.Controls.Add(this.label12);
            this.gbProductInfo.Controls.Add(this.tbContactPerson1);
            this.gbProductInfo.Controls.Add(this.label10);
            this.gbProductInfo.Controls.Add(this.tbCity);
            this.gbProductInfo.Controls.Add(this.label8);
            this.gbProductInfo.Controls.Add(this.tbZipCode);
            this.gbProductInfo.Controls.Add(this.label7);
            this.gbProductInfo.Controls.Add(this.tbAddress);
            this.gbProductInfo.Controls.Add(this.cbBank);
            this.gbProductInfo.Controls.Add(this.label6);
            this.gbProductInfo.Controls.Add(this.tbEMBS);
            this.gbProductInfo.Controls.Add(this.label5);
            this.gbProductInfo.Controls.Add(this.tbTaxNum);
            this.gbProductInfo.Controls.Add(this.label4);
            this.gbProductInfo.Controls.Add(this.tbBankNum2);
            this.gbProductInfo.Controls.Add(this.label3);
            this.gbProductInfo.Controls.Add(this.tbBankNum1);
            this.gbProductInfo.Controls.Add(this.label1);
            this.gbProductInfo.Controls.Add(this.label2);
            this.gbProductInfo.Controls.Add(this.label9);
            this.gbProductInfo.Controls.Add(this.tbName);
            this.gbProductInfo.Controls.Add(this.tbDescription);
            this.gbProductInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductInfo.Location = new System.Drawing.Point(12, 18);
            this.gbProductInfo.Name = "gbProductInfo";
            this.gbProductInfo.Size = new System.Drawing.Size(613, 382);
            this.gbProductInfo.TabIndex = 25;
            this.gbProductInfo.TabStop = false;
            this.gbProductInfo.Text = "Податоци за коминтенти";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(447, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 20);
            this.label16.TabIndex = 51;
            this.label16.Text = "Лице за контакт 2";
            // 
            // tbContactPerson2
            // 
            this.tbContactPerson2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContactPerson2.Location = new System.Drawing.Point(451, 109);
            this.tbContactPerson2.Name = "tbContactPerson2";
            this.tbContactPerson2.Size = new System.Drawing.Size(136, 29);
            this.tbContactPerson2.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(447, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "Телефон 2";
            // 
            // tbPhone2
            // 
            this.tbPhone2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone2.Location = new System.Drawing.Point(451, 169);
            this.tbPhone2.Name = "tbPhone2";
            this.tbPhone2.Size = new System.Drawing.Size(136, 29);
            this.tbPhone2.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(292, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 47;
            this.label14.Text = "Е-пошта";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(296, 224);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(166, 29);
            this.tbEmail.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(292, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Телефон 1";
            // 
            // tbPhone1
            // 
            this.tbPhone1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone1.Location = new System.Drawing.Point(296, 169);
            this.tbPhone1.Name = "tbPhone1";
            this.tbPhone1.Size = new System.Drawing.Size(136, 29);
            this.tbPhone1.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(292, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Лице за контакт 1";
            // 
            // tbContactPerson1
            // 
            this.tbContactPerson1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContactPerson1.Location = new System.Drawing.Point(296, 109);
            this.tbContactPerson1.Name = "tbContactPerson1";
            this.tbContactPerson1.Size = new System.Drawing.Size(136, 29);
            this.tbContactPerson1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(445, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Град";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(449, 52);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(66, 29);
            this.tbCity.TabIndex = 8;
            this.tbCity.TextChanged += new System.EventHandler(this.tbCity_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(517, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Пош. број";
            // 
            // tbZipCode
            // 
            this.tbZipCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZipCode.Location = new System.Drawing.Point(521, 52);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(66, 29);
            this.tbZipCode.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Адреса";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(296, 52);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(136, 29);
            this.tbAddress.TabIndex = 7;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // cbBank
            // 
            this.cbBank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBank.FormattingEnabled = true;
            this.cbBank.Items.AddRange(new object[] {
            "Стопанска Банка",
            "Комерцијална Банка",
            "НЛБ Тутунска Банка",
            "Охридска Банка",
            "Шпаркасе Банк",
            "Халкбанк",
            "Прокредит Банка",
            "Стопанска Банка АД Битола",
            "Капитол Банка",
            "Силк Роуд Банка"});
            this.cbBank.Location = new System.Drawing.Point(28, 332);
            this.cbBank.Name = "cbBank";
            this.cbBank.Size = new System.Drawing.Size(166, 29);
            this.cbBank.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "ЕМБС";
            // 
            // tbEMBS
            // 
            this.tbEMBS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEMBS.Location = new System.Drawing.Point(28, 169);
            this.tbEMBS.Name = "tbEMBS";
            this.tbEMBS.Size = new System.Drawing.Size(166, 29);
            this.tbEMBS.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Даночен број";
            // 
            // tbTaxNum
            // 
            this.tbTaxNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaxNum.Location = new System.Drawing.Point(28, 109);
            this.tbTaxNum.Name = "tbTaxNum";
            this.tbTaxNum.Size = new System.Drawing.Size(166, 29);
            this.tbTaxNum.TabIndex = 2;
            this.tbTaxNum.TextChanged += new System.EventHandler(this.tbTaxNum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Банка";
            // 
            // tbBankNum2
            // 
            this.tbBankNum2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBankNum2.Location = new System.Drawing.Point(28, 279);
            this.tbBankNum2.Name = "tbBankNum2";
            this.tbBankNum2.Size = new System.Drawing.Size(166, 29);
            this.tbBankNum2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Жиро сметка (доп.)";
            // 
            // tbBankNum1
            // 
            this.tbBankNum1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBankNum1.Location = new System.Drawing.Point(28, 224);
            this.tbBankNum1.Name = "tbBankNum1";
            this.tbBankNum1.Size = new System.Drawing.Size(166, 29);
            this.tbBankNum1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Жиро сметка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Назив";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Забелешка";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(28, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(166, 29);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(294, 299);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(293, 62);
            this.tbDescription.TabIndex = 15;
            this.tbDescription.Text = "";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 406);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(974, 279);
            this.dgvCustomers.TabIndex = 1;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // errorProviderTaxNum
            // 
            this.errorProviderTaxNum.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.ContainerControl = this;
            this.errorProviderAddress.RightToLeft = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.pnlControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(990, 720);
            this.Name = "Customers";
            this.Text = "Коминтенти";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.SizeChanged += new System.EventHandler(this.Customers_SizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Products_KeyUp);
            this.pnlControls.ResumeLayout(false);
            this.gbButtons.ResumeLayout(false);
            this.gbButtons.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.gbProductInfo.ResumeLayout(false);
            this.gbProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTaxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbProductInfo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbtnCity;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.RadioButton rbtnTaxNum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbContactPerson2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbPhone2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPhone1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbContactPerson1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.ComboBox cbBank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEMBS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTaxNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBankNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBankNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderTaxNum;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
    }
}