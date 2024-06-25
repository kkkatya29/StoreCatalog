namespace StoreCatalog
{
    partial class Availability
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
            this.QuantityDtGrdVw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityDtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBtn.Font = new System.Drawing.Font("Times New Roman", 9.5F);
            this.BackBtn.Location = new System.Drawing.Point(398, 761);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(87, 30);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // QuantityDtGrdVw
            // 
            this.QuantityDtGrdVw.AllowUserToAddRows = false;
            this.QuantityDtGrdVw.AllowUserToDeleteRows = false;
            this.QuantityDtGrdVw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuantityDtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuantityDtGrdVw.Location = new System.Drawing.Point(12, 12);
            this.QuantityDtGrdVw.Name = "QuantityDtGrdVw";
            this.QuantityDtGrdVw.ReadOnly = true;
            this.QuantityDtGrdVw.RowHeadersWidth = 51;
            this.QuantityDtGrdVw.RowTemplate.Height = 24;
            this.QuantityDtGrdVw.Size = new System.Drawing.Size(473, 739);
            this.QuantityDtGrdVw.TabIndex = 2;
            // 
            // Availability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(497, 803);
            this.Controls.Add(this.QuantityDtGrdVw);
            this.Controls.Add(this.BackBtn);
            this.Name = "Availability";
            this.ShowIcon = false;
            this.Text = "Наличие товаров";
            this.Load += new System.EventHandler(this.Availability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityDtGrdVw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView QuantityDtGrdVw;
    }
}