namespace StoreCatalog
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CatalogBtn = new System.Windows.Forms.Button();
            this.AvailabilityBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CatalogBtn
            // 
            this.CatalogBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CatalogBtn.BackColor = System.Drawing.Color.White;
            this.CatalogBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatalogBtn.Location = new System.Drawing.Point(45, 275);
            this.CatalogBtn.Name = "CatalogBtn";
            this.CatalogBtn.Size = new System.Drawing.Size(208, 57);
            this.CatalogBtn.TabIndex = 0;
            this.CatalogBtn.Text = "Каталог";
            this.CatalogBtn.UseVisualStyleBackColor = false;
            this.CatalogBtn.Click += new System.EventHandler(this.CatalogBtn_Click);
            // 
            // AvailabilityBtn
            // 
            this.AvailabilityBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvailabilityBtn.BackColor = System.Drawing.Color.White;
            this.AvailabilityBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvailabilityBtn.Location = new System.Drawing.Point(325, 275);
            this.AvailabilityBtn.Name = "AvailabilityBtn";
            this.AvailabilityBtn.Size = new System.Drawing.Size(208, 57);
            this.AvailabilityBtn.TabIndex = 1;
            this.AvailabilityBtn.Text = "Наличие товаров";
            this.AvailabilityBtn.UseVisualStyleBackColor = false;
            this.AvailabilityBtn.Click += new System.EventHandler(this.AvailabilityBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-123, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1086, 123);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Контакты для связи: \r\n8 (800) 550-00-80, 8 (8453) 513-513\r\nopthzsay@opthz.ru";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AvailabilityBtn);
            this.Controls.Add(this.CatalogBtn);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CatalogBtn;
        private System.Windows.Forms.Button AvailabilityBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

