
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlMenuButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuButtons
            // 
            this.pnlMenuButtons.Controls.Add(this.button5);
            this.pnlMenuButtons.Controls.Add(this.button4);
            this.pnlMenuButtons.Controls.Add(this.button3);
            this.pnlMenuButtons.Controls.Add(this.button2);
            this.pnlMenuButtons.Controls.Add(this.button1);
            this.pnlMenuButtons.Location = new System.Drawing.Point(12, 12);
            this.pnlMenuButtons.MinimumSize = new System.Drawing.Size(1280, 720);
            this.pnlMenuButtons.Name = "pnlMenuButtons";
            this.pnlMenuButtons.Size = new System.Drawing.Size(1280, 720);
            this.pnlMenuButtons.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 250);
            this.button1.TabIndex = 1;
            this.button1.Text = "Податоци за фирма";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 250);
            this.button2.TabIndex = 2;
            this.button2.Text = "Продажба";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(916, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 250);
            this.button3.TabIndex = 3;
            this.button3.Text = "Артикли";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 250);
            this.button4.TabIndex = 4;
            this.button4.Text = "Коминтенти";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(713, 404);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(300, 250);
            this.button5.TabIndex = 5;
            this.button5.Text = "Вработени";
            this.button5.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}