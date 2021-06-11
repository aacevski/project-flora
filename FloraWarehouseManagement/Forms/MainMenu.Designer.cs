
namespace FloraWarehouseManagement.Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pnlMenuButtons = new System.Windows.Forms.Panel();
            this.btnLogins = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnlMenuButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuButtons
            // 
            this.pnlMenuButtons.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlMenuButtons.Controls.Add(this.btnLogins);
            this.pnlMenuButtons.Controls.Add(this.btnEmployees);
            this.pnlMenuButtons.Controls.Add(this.btnClients);
            this.pnlMenuButtons.Controls.Add(this.btnProducts);
            this.pnlMenuButtons.Controls.Add(this.btnSales);
            this.pnlMenuButtons.Controls.Add(this.btnInfo);
            this.pnlMenuButtons.Location = new System.Drawing.Point(12, 12);
            this.pnlMenuButtons.MinimumSize = new System.Drawing.Size(1280, 720);
            this.pnlMenuButtons.Name = "pnlMenuButtons";
            this.pnlMenuButtons.Size = new System.Drawing.Size(1280, 720);
            this.pnlMenuButtons.TabIndex = 3;
            // 
            // btnLogins
            // 
            this.btnLogins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogins.BackgroundImage")));
            this.btnLogins.FlatAppearance.BorderSize = 0;
            this.btnLogins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogins.Location = new System.Drawing.Point(916, 404);
            this.btnLogins.Name = "btnLogins";
            this.btnLogins.Size = new System.Drawing.Size(300, 250);
            this.btnLogins.TabIndex = 6;
            this.btnLogins.UseVisualStyleBackColor = true;
            this.btnLogins.Click += new System.EventHandler(this.btnLogins_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployees.BackgroundImage")));
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployees.Location = new System.Drawing.Point(483, 407);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(300, 250);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            this.btnClients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClients.BackgroundImage")));
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClients.Location = new System.Drawing.Point(34, 404);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(300, 250);
            this.btnClients.TabIndex = 4;
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.BackgroundImage")));
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProducts.Location = new System.Drawing.Point(916, 14);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(300, 250);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSales.BackgroundImage")));
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSales.Location = new System.Drawing.Point(483, 14);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(300, 250);
            this.btnSales.TabIndex = 2;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInfo.Location = new System.Drawing.Point(34, 14);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(300, 250);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMenuButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainMenu";
            this.Text = "Главно мени";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.SizeChanged += new System.EventHandler(this.MainMenu_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.pnlMenuButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuButtons;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnLogins;
    }
}