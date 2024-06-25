namespace StoreCatalog
{
    partial class Catalog
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.DishesTbPg = new System.Windows.Forms.TabPage();
            this.InteriorTbPg = new System.Windows.Forms.TabPage();
            this.ToolsTbPg = new System.Windows.Forms.TabPage();
            this.AppliancesTbPg = new System.Windows.Forms.TabPage();
            this.CatalogTbCntrl = new System.Windows.Forms.TabControl();
            this.CatalogTbCntrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBtn.Font = new System.Drawing.Font("Times New Roman", 9.5F);
            this.BackBtn.Location = new System.Drawing.Point(993, 551);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(87, 30);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DishesTbPg
            // 
            this.DishesTbPg.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.DishesTbPg.Location = new System.Drawing.Point(4, 25);
            this.DishesTbPg.Name = "DishesTbPg";
            this.DishesTbPg.Size = new System.Drawing.Size(1060, 504);
            this.DishesTbPg.TabIndex = 4;
            this.DishesTbPg.Text = "Посуда";
            this.DishesTbPg.UseVisualStyleBackColor = true;
            // 
            // InteriorTbPg
            // 
            this.InteriorTbPg.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.InteriorTbPg.Location = new System.Drawing.Point(4, 25);
            this.InteriorTbPg.Name = "InteriorTbPg";
            this.InteriorTbPg.Padding = new System.Windows.Forms.Padding(3);
            this.InteriorTbPg.Size = new System.Drawing.Size(1060, 504);
            this.InteriorTbPg.TabIndex = 2;
            this.InteriorTbPg.Text = "Интерьер";
            this.InteriorTbPg.UseVisualStyleBackColor = true;
            // 
            // ToolsTbPg
            // 
            this.ToolsTbPg.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.ToolsTbPg.Location = new System.Drawing.Point(4, 25);
            this.ToolsTbPg.Name = "ToolsTbPg";
            this.ToolsTbPg.Size = new System.Drawing.Size(1060, 504);
            this.ToolsTbPg.TabIndex = 5;
            this.ToolsTbPg.Text = "Инструменты";
            this.ToolsTbPg.UseVisualStyleBackColor = true;
            // 
            // AppliancesTbPg
            // 
            this.AppliancesTbPg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppliancesTbPg.Location = new System.Drawing.Point(4, 25);
            this.AppliancesTbPg.Name = "AppliancesTbPg";
            this.AppliancesTbPg.Padding = new System.Windows.Forms.Padding(3);
            this.AppliancesTbPg.Size = new System.Drawing.Size(1060, 504);
            this.AppliancesTbPg.TabIndex = 0;
            this.AppliancesTbPg.Text = "Бытовая техника";
            this.AppliancesTbPg.UseVisualStyleBackColor = true;
            // 
            // CatalogTbCntrl
            // 
            this.CatalogTbCntrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CatalogTbCntrl.Controls.Add(this.AppliancesTbPg);
            this.CatalogTbCntrl.Controls.Add(this.ToolsTbPg);
            this.CatalogTbCntrl.Controls.Add(this.InteriorTbPg);
            this.CatalogTbCntrl.Controls.Add(this.DishesTbPg);
            this.CatalogTbCntrl.Location = new System.Drawing.Point(12, 12);
            this.CatalogTbCntrl.Name = "CatalogTbCntrl";
            this.CatalogTbCntrl.SelectedIndex = 0;
            this.CatalogTbCntrl.Size = new System.Drawing.Size(1068, 533);
            this.CatalogTbCntrl.TabIndex = 1;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1092, 593);
            this.Controls.Add(this.CatalogTbCntrl);
            this.Controls.Add(this.BackBtn);
            this.Name = "Catalog";
            this.ShowIcon = false;
            this.Text = "Каталог";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.CatalogTbCntrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TabPage DishesTbPg;
        private System.Windows.Forms.TabPage InteriorTbPg;
        private System.Windows.Forms.TabPage ToolsTbPg;
        private System.Windows.Forms.TabPage AppliancesTbPg;
        private System.Windows.Forms.TabControl CatalogTbCntrl;
    }
}