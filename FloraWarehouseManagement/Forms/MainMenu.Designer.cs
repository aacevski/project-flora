
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
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(713, 404);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(300, 250);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "Вработени";
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(251, 404);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(300, 250);
            this.btnClients.TabIndex = 4;
            this.btnClients.Text = "Коминтенти";
            this.btnClients.UseVisualStyleBackColor = true;
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
            this.btnSales.Location = new System.Drawing.Point(483, 14);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(300, 250);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Продажба";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(34, 14);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(300, 250);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Податоци за фирма";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMenuButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainMenu";
            this.Text = "Главно мени";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.SizeChanged += new System.EventHandler(this.MainMenu_SizeChanged);
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
    }
}