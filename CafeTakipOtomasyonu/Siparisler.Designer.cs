namespace CafeTakipOtomasyonu
{
    partial class Siparisler
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
            this.urunSiparisList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.siparisleriListeleButton = new System.Windows.Forms.Button();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // urunSiparisList
            // 
            this.urunSiparisList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.urunSiparisList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.urunSiparisList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunSiparisList.FullRowSelect = true;
            this.urunSiparisList.GridLines = true;
            this.urunSiparisList.HideSelection = false;
            this.urunSiparisList.Location = new System.Drawing.Point(12, 98);
            this.urunSiparisList.Name = "urunSiparisList";
            this.urunSiparisList.Size = new System.Drawing.Size(1139, 463);
            this.urunSiparisList.TabIndex = 2;
            this.urunSiparisList.UseCompatibleStateImageBehavior = false;
            this.urunSiparisList.View = System.Windows.Forms.View.Details;
            this.urunSiparisList.SelectedIndexChanged += new System.EventHandler(this.urunSiparisList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MASA NO";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ÜRÜNLER";
            this.columnHeader2.Width = 380;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "TUTAR";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 4;
            this.columnHeader4.Text = "TARİH";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 2;
            this.columnHeader5.Text = "ADET";
            // 
            // siparisleriListeleButton
            // 
            this.siparisleriListeleButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.siparisleriListeleButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisleriListeleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siparisleriListeleButton.Location = new System.Drawing.Point(12, 12);
            this.siparisleriListeleButton.Name = "siparisleriListeleButton";
            this.siparisleriListeleButton.Size = new System.Drawing.Size(180, 69);
            this.siparisleriListeleButton.TabIndex = 3;
            this.siparisleriListeleButton.Text = "Tüm Siparişleri Listele";
            this.siparisleriListeleButton.UseVisualStyleBackColor = false;
            this.siparisleriListeleButton.Click += new System.EventHandler(this.siparisleriListeleButton_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Saat";
            this.columnHeader6.Width = 80;
            // 
            // Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 625);
            this.Controls.Add(this.siparisleriListeleButton);
            this.Controls.Add(this.urunSiparisList);
            this.Name = "Siparisler";
            this.Text = "SİPARİSLER";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView urunSiparisList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button siparisleriListeleButton;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}