namespace CafeTakipOtomasyonu
{
    partial class Giris
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
            this.girisYapButton = new System.Windows.Forms.Button();
            this.girisKullaniciAdiLabel = new System.Windows.Forms.Label();
            this.girisSifreLabel = new System.Windows.Forms.Label();
            this.girisSifreniziMiUnutunuz = new System.Windows.Forms.LinkLabel();
            this.girisKullaniciAdiText = new System.Windows.Forms.TextBox();
            this.girisSifreText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // girisYapButton
            // 
            this.girisYapButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.girisYapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.girisYapButton.Location = new System.Drawing.Point(257, 121);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(111, 32);
            this.girisYapButton.TabIndex = 0;
            this.girisYapButton.Text = "GİRİŞ YAP";
            this.girisYapButton.UseVisualStyleBackColor = false;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // girisKullaniciAdiLabel
            // 
            this.girisKullaniciAdiLabel.AutoSize = true;
            this.girisKullaniciAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisKullaniciAdiLabel.Location = new System.Drawing.Point(40, 49);
            this.girisKullaniciAdiLabel.Name = "girisKullaniciAdiLabel";
            this.girisKullaniciAdiLabel.Size = new System.Drawing.Size(118, 22);
            this.girisKullaniciAdiLabel.TabIndex = 1;
            this.girisKullaniciAdiLabel.Text = "Kullanıcı Adı :";
            // 
            // girisSifreLabel
            // 
            this.girisSifreLabel.AutoSize = true;
            this.girisSifreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisSifreLabel.Location = new System.Drawing.Point(40, 84);
            this.girisSifreLabel.Name = "girisSifreLabel";
            this.girisSifreLabel.Size = new System.Drawing.Size(57, 22);
            this.girisSifreLabel.TabIndex = 2;
            this.girisSifreLabel.Text = "Şifre :";
            // 
            // girisSifreniziMiUnutunuz
            // 
            this.girisSifreniziMiUnutunuz.AutoSize = true;
            this.girisSifreniziMiUnutunuz.Location = new System.Drawing.Point(234, 171);
            this.girisSifreniziMiUnutunuz.Name = "girisSifreniziMiUnutunuz";
            this.girisSifreniziMiUnutunuz.Size = new System.Drawing.Size(134, 16);
            this.girisSifreniziMiUnutunuz.TabIndex = 3;
            this.girisSifreniziMiUnutunuz.TabStop = true;
            this.girisSifreniziMiUnutunuz.Text = "Şifrenizi mi unuttunuz?";
            this.girisSifreniziMiUnutunuz.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.girisSifreniziMiUnutunuz_LinkClicked);
            // 
            // girisKullaniciAdiText
            // 
            this.girisKullaniciAdiText.Location = new System.Drawing.Point(210, 49);
            this.girisKullaniciAdiText.Name = "girisKullaniciAdiText";
            this.girisKullaniciAdiText.Size = new System.Drawing.Size(158, 22);
            this.girisKullaniciAdiText.TabIndex = 4;
            // 
            // girisSifreText
            // 
            this.girisSifreText.Location = new System.Drawing.Point(210, 84);
            this.girisSifreText.Name = "girisSifreText";
            this.girisSifreText.PasswordChar = '*';
            this.girisSifreText.Size = new System.Drawing.Size(158, 22);
            this.girisSifreText.TabIndex = 5;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 631);
            this.Controls.Add(this.girisSifreText);
            this.Controls.Add(this.girisKullaniciAdiText);
            this.Controls.Add(this.girisSifreniziMiUnutunuz);
            this.Controls.Add(this.girisSifreLabel);
            this.Controls.Add(this.girisKullaniciAdiLabel);
            this.Controls.Add(this.girisYapButton);
            this.Name = "Giris";
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisYapButton;
        private System.Windows.Forms.Label girisKullaniciAdiLabel;
        private System.Windows.Forms.Label girisSifreLabel;
        private System.Windows.Forms.LinkLabel girisSifreniziMiUnutunuz;
        private System.Windows.Forms.TextBox girisKullaniciAdiText;
        private System.Windows.Forms.TextBox girisSifreText;
    }
}