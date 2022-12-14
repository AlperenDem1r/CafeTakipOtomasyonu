namespace CafeTakipOtomasyonu
{
    partial class SifreYenileme
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
            this.sifreYenilemeLabel = new System.Windows.Forms.Label();
            this.sifreYenilemeTekrarlaLabel = new System.Windows.Forms.Label();
            this.sifreYenilemeText = new System.Windows.Forms.TextBox();
            this.sifreYenilemeTekrarlaText = new System.Windows.Forms.TextBox();
            this.sifreYenilemeOnayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifreYenilemeLabel
            // 
            this.sifreYenilemeLabel.AutoSize = true;
            this.sifreYenilemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreYenilemeLabel.Location = new System.Drawing.Point(23, 29);
            this.sifreYenilemeLabel.Name = "sifreYenilemeLabel";
            this.sifreYenilemeLabel.Size = new System.Drawing.Size(179, 22);
            this.sifreYenilemeLabel.TabIndex = 0;
            this.sifreYenilemeLabel.Text = "Yeni Şifrenizi Giriniz :";
            // 
            // sifreYenilemeTekrarlaLabel
            // 
            this.sifreYenilemeTekrarlaLabel.AutoSize = true;
            this.sifreYenilemeTekrarlaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreYenilemeTekrarlaLabel.Location = new System.Drawing.Point(23, 66);
            this.sifreYenilemeTekrarlaLabel.Name = "sifreYenilemeTekrarlaLabel";
            this.sifreYenilemeTekrarlaLabel.Size = new System.Drawing.Size(183, 22);
            this.sifreYenilemeTekrarlaLabel.TabIndex = 1;
            this.sifreYenilemeTekrarlaLabel.Text = "Şifreyi Tekrar Giriniz :";
            // 
            // sifreYenilemeText
            // 
            this.sifreYenilemeText.Location = new System.Drawing.Point(243, 28);
            this.sifreYenilemeText.Name = "sifreYenilemeText";
            this.sifreYenilemeText.Size = new System.Drawing.Size(149, 22);
            this.sifreYenilemeText.TabIndex = 2;
            // 
            // sifreYenilemeTekrarlaText
            // 
            this.sifreYenilemeTekrarlaText.Location = new System.Drawing.Point(243, 65);
            this.sifreYenilemeTekrarlaText.Name = "sifreYenilemeTekrarlaText";
            this.sifreYenilemeTekrarlaText.Size = new System.Drawing.Size(149, 22);
            this.sifreYenilemeTekrarlaText.TabIndex = 3;
            // 
            // sifreYenilemeOnayButton
            // 
            this.sifreYenilemeOnayButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sifreYenilemeOnayButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreYenilemeOnayButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sifreYenilemeOnayButton.Location = new System.Drawing.Point(307, 104);
            this.sifreYenilemeOnayButton.Name = "sifreYenilemeOnayButton";
            this.sifreYenilemeOnayButton.Size = new System.Drawing.Size(85, 37);
            this.sifreYenilemeOnayButton.TabIndex = 4;
            this.sifreYenilemeOnayButton.Text = "ONAYLA";
            this.sifreYenilemeOnayButton.UseVisualStyleBackColor = false;
            this.sifreYenilemeOnayButton.Click += new System.EventHandler(this.sifreYenilemeOnayButton_Click);
            // 
            // SifreYenileme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 329);
            this.Controls.Add(this.sifreYenilemeOnayButton);
            this.Controls.Add(this.sifreYenilemeTekrarlaText);
            this.Controls.Add(this.sifreYenilemeText);
            this.Controls.Add(this.sifreYenilemeTekrarlaLabel);
            this.Controls.Add(this.sifreYenilemeLabel);
            this.Name = "SifreYenileme";
            this.Text = "SifreYenileme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sifreYenilemeLabel;
        private System.Windows.Forms.Label sifreYenilemeTekrarlaLabel;
        private System.Windows.Forms.TextBox sifreYenilemeText;
        private System.Windows.Forms.TextBox sifreYenilemeTekrarlaText;
        private System.Windows.Forms.Button sifreYenilemeOnayButton;
    }
}