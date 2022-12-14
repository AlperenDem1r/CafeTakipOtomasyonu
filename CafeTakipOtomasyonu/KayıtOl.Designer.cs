namespace CafeTakipOtomasyonu
{
    partial class KayıtOl
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
            this.uyeOlButton = new System.Windows.Forms.Button();
            this.kayıtOlKullaniciAdiLabel = new System.Windows.Forms.Label();
            this.kayıtOlSifreLabel = new System.Windows.Forms.Label();
            this.kayıtOlSifreyiTekrarlaLabel = new System.Windows.Forms.Label();
            this.kayıtOlKullaniciAdiText = new System.Windows.Forms.TextBox();
            this.kayıtOlSifreText = new System.Windows.Forms.TextBox();
            this.kayıtOlSifreTekrarlaText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uyeOlButton
            // 
            this.uyeOlButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.uyeOlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeOlButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uyeOlButton.Location = new System.Drawing.Point(331, 160);
            this.uyeOlButton.Name = "uyeOlButton";
            this.uyeOlButton.Size = new System.Drawing.Size(88, 38);
            this.uyeOlButton.TabIndex = 0;
            this.uyeOlButton.Text = "ÜYE OL";
            this.uyeOlButton.UseVisualStyleBackColor = false;
            this.uyeOlButton.Click += new System.EventHandler(this.uyeOlButton_Click);
            // 
            // kayıtOlKullaniciAdiLabel
            // 
            this.kayıtOlKullaniciAdiLabel.AutoSize = true;
            this.kayıtOlKullaniciAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtOlKullaniciAdiLabel.Location = new System.Drawing.Point(45, 41);
            this.kayıtOlKullaniciAdiLabel.Name = "kayıtOlKullaniciAdiLabel";
            this.kayıtOlKullaniciAdiLabel.Size = new System.Drawing.Size(118, 22);
            this.kayıtOlKullaniciAdiLabel.TabIndex = 1;
            this.kayıtOlKullaniciAdiLabel.Text = "Kullanıcı Adı :";
            // 
            // kayıtOlSifreLabel
            // 
            this.kayıtOlSifreLabel.AutoSize = true;
            this.kayıtOlSifreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtOlSifreLabel.Location = new System.Drawing.Point(45, 80);
            this.kayıtOlSifreLabel.Name = "kayıtOlSifreLabel";
            this.kayıtOlSifreLabel.Size = new System.Drawing.Size(57, 22);
            this.kayıtOlSifreLabel.TabIndex = 2;
            this.kayıtOlSifreLabel.Text = "Şifre :";
            // 
            // kayıtOlSifreyiTekrarlaLabel
            // 
            this.kayıtOlSifreyiTekrarlaLabel.AutoSize = true;
            this.kayıtOlSifreyiTekrarlaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtOlSifreyiTekrarlaLabel.Location = new System.Drawing.Point(45, 119);
            this.kayıtOlSifreyiTekrarlaLabel.Name = "kayıtOlSifreyiTekrarlaLabel";
            this.kayıtOlSifreyiTekrarlaLabel.Size = new System.Drawing.Size(183, 22);
            this.kayıtOlSifreyiTekrarlaLabel.TabIndex = 3;
            this.kayıtOlSifreyiTekrarlaLabel.Text = "Şifreyi Tekrar Giriniz :";
            // 
            // kayıtOlKullaniciAdiText
            // 
            this.kayıtOlKullaniciAdiText.Location = new System.Drawing.Point(247, 41);
            this.kayıtOlKullaniciAdiText.Name = "kayıtOlKullaniciAdiText";
            this.kayıtOlKullaniciAdiText.Size = new System.Drawing.Size(172, 22);
            this.kayıtOlKullaniciAdiText.TabIndex = 5;
            this.kayıtOlKullaniciAdiText.TextChanged += new System.EventHandler(this.kayıtOlKullaniciAdiText_TextChanged);
            // 
            // kayıtOlSifreText
            // 
            this.kayıtOlSifreText.Location = new System.Drawing.Point(247, 80);
            this.kayıtOlSifreText.Name = "kayıtOlSifreText";
            this.kayıtOlSifreText.PasswordChar = '*';
            this.kayıtOlSifreText.Size = new System.Drawing.Size(172, 22);
            this.kayıtOlSifreText.TabIndex = 6;
            // 
            // kayıtOlSifreTekrarlaText
            // 
            this.kayıtOlSifreTekrarlaText.Location = new System.Drawing.Point(247, 119);
            this.kayıtOlSifreTekrarlaText.Name = "kayıtOlSifreTekrarlaText";
            this.kayıtOlSifreTekrarlaText.PasswordChar = '*';
            this.kayıtOlSifreTekrarlaText.Size = new System.Drawing.Size(172, 22);
            this.kayıtOlSifreTekrarlaText.TabIndex = 7;
            // 
            // KayıtOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 514);
            this.Controls.Add(this.kayıtOlSifreTekrarlaText);
            this.Controls.Add(this.kayıtOlSifreText);
            this.Controls.Add(this.kayıtOlKullaniciAdiText);
            this.Controls.Add(this.kayıtOlSifreyiTekrarlaLabel);
            this.Controls.Add(this.kayıtOlSifreLabel);
            this.Controls.Add(this.kayıtOlKullaniciAdiLabel);
            this.Controls.Add(this.uyeOlButton);
            this.Name = "KayıtOl";
            this.Text = "KayıtOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uyeOlButton;
        private System.Windows.Forms.Label kayıtOlKullaniciAdiLabel;
        private System.Windows.Forms.Label kayıtOlSifreLabel;
        private System.Windows.Forms.Label kayıtOlSifreyiTekrarlaLabel;
        private System.Windows.Forms.TextBox kayıtOlKullaniciAdiText;
        private System.Windows.Forms.TextBox kayıtOlSifreText;
        private System.Windows.Forms.TextBox kayıtOlSifreTekrarlaText;
    }
}