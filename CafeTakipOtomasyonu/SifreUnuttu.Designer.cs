﻿namespace CafeTakipOtomasyonu
{
    partial class SifreUnuttu
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
            this.mailGonderLabel = new System.Windows.Forms.Label();
            this.mailOnayLabel = new System.Windows.Forms.Label();
            this.mailOnayiText = new System.Windows.Forms.TextBox();
            this.mailGonderText = new System.Windows.Forms.TextBox();
            this.mailGonderButton = new System.Windows.Forms.Button();
            this.mailKontrolButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mailGonderLabel
            // 
            this.mailGonderLabel.AutoSize = true;
            this.mailGonderLabel.BackColor = System.Drawing.SystemColors.Control;
            this.mailGonderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailGonderLabel.Location = new System.Drawing.Point(13, 65);
            this.mailGonderLabel.Name = "mailGonderLabel";
            this.mailGonderLabel.Size = new System.Drawing.Size(244, 22);
            this.mailGonderLabel.TabIndex = 2;
            this.mailGonderLabel.Text = "Lütfen Mail Adresinizi Giriniz :";
            // 
            // mailOnayLabel
            // 
            this.mailOnayLabel.AutoSize = true;
            this.mailOnayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailOnayLabel.Location = new System.Drawing.Point(13, 174);
            this.mailOnayLabel.Name = "mailOnayLabel";
            this.mailOnayLabel.Size = new System.Drawing.Size(248, 22);
            this.mailOnayLabel.TabIndex = 3;
            this.mailOnayLabel.Text = "Mailinize Gelen Kodu Giriniz : ";
            // 
            // mailOnayiText
            // 
            this.mailOnayiText.Location = new System.Drawing.Point(284, 174);
            this.mailOnayiText.Name = "mailOnayiText";
            this.mailOnayiText.Size = new System.Drawing.Size(221, 22);
            this.mailOnayiText.TabIndex = 5;
            // 
            // mailGonderText
            // 
            this.mailGonderText.Location = new System.Drawing.Point(284, 65);
            this.mailGonderText.Name = "mailGonderText";
            this.mailGonderText.Size = new System.Drawing.Size(221, 22);
            this.mailGonderText.TabIndex = 4;
            // 
            // mailGonderButton
            // 
            this.mailGonderButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mailGonderButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailGonderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mailGonderButton.Location = new System.Drawing.Point(415, 104);
            this.mailGonderButton.Name = "mailGonderButton";
            this.mailGonderButton.Size = new System.Drawing.Size(90, 39);
            this.mailGonderButton.TabIndex = 6;
            this.mailGonderButton.Text = "Gönder";
            this.mailGonderButton.UseVisualStyleBackColor = false;
            this.mailGonderButton.Click += new System.EventHandler(this.mailGonderButton_Click);
            // 
            // mailKontrolButton
            // 
            this.mailKontrolButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mailKontrolButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailKontrolButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mailKontrolButton.Location = new System.Drawing.Point(388, 214);
            this.mailKontrolButton.Name = "mailKontrolButton";
            this.mailKontrolButton.Size = new System.Drawing.Size(117, 38);
            this.mailKontrolButton.TabIndex = 7;
            this.mailKontrolButton.Text = "KONTROL ET";
            this.mailKontrolButton.UseVisualStyleBackColor = false;
            this.mailKontrolButton.Click += new System.EventHandler(this.mailKontrolButton_Click);
            // 
            // SifreUnuttu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 290);
            this.Controls.Add(this.mailKontrolButton);
            this.Controls.Add(this.mailGonderButton);
            this.Controls.Add(this.mailGonderText);
            this.Controls.Add(this.mailOnayiText);
            this.Controls.Add(this.mailOnayLabel);
            this.Controls.Add(this.mailGonderLabel);
            this.Name = "SifreUnuttu";
            this.Text = "bu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mailGonderLabel;
        private System.Windows.Forms.Label mailOnayLabel;
        private System.Windows.Forms.TextBox mailOnayiText;
        private System.Windows.Forms.TextBox mailGonderText;
        private System.Windows.Forms.Button mailGonderButton;
        private System.Windows.Forms.Button mailKontrolButton;
    }
}