﻿
namespace rehber
{
    partial class RehberiGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RehberiGuncelle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBx_AdListesi = new System.Windows.Forms.ComboBox();
            this.txtBx_Ad = new System.Windows.Forms.TextBox();
            this.txtBx_Soyad = new System.Windows.Forms.TextBox();
            this.txtBx_Tel = new System.Windows.Forms.TextBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Vazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AdaGöreAra=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadi=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon=";
            // 
            // cmbBx_AdListesi
            // 
            this.cmbBx_AdListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_AdListesi.FormattingEnabled = true;
            this.cmbBx_AdListesi.Location = new System.Drawing.Point(72, 4);
            this.cmbBx_AdListesi.Name = "cmbBx_AdListesi";
            this.cmbBx_AdListesi.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_AdListesi.TabIndex = 4;
            this.cmbBx_AdListesi.SelectedIndexChanged += new System.EventHandler(this.cmbBx_AdListesi_SelectedIndexChanged);
            // 
            // txtBx_Ad
            // 
            this.txtBx_Ad.Location = new System.Drawing.Point(41, 33);
            this.txtBx_Ad.Name = "txtBx_Ad";
            this.txtBx_Ad.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Ad.TabIndex = 5;
            // 
            // txtBx_Soyad
            // 
            this.txtBx_Soyad.Location = new System.Drawing.Point(58, 61);
            this.txtBx_Soyad.Name = "txtBx_Soyad";
            this.txtBx_Soyad.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Soyad.TabIndex = 6;
            // 
            // txtBx_Tel
            // 
            this.txtBx_Tel.Location = new System.Drawing.Point(62, 89);
            this.txtBx_Tel.Name = "txtBx_Tel";
            this.txtBx_Tel.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Tel.TabIndex = 7;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(12, 126);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 8;
            this.btn_Guncelle.Text = "Guncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.Location = new System.Drawing.Point(118, 126);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.Size = new System.Drawing.Size(75, 23);
            this.btn_Vazgec.TabIndex = 9;
            this.btn_Vazgec.Text = "İptal";
            this.btn_Vazgec.UseVisualStyleBackColor = true;
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // RehberiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 161);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.txtBx_Tel);
            this.Controls.Add(this.txtBx_Soyad);
            this.Controls.Add(this.txtBx_Ad);
            this.Controls.Add(this.cmbBx_AdListesi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RehberiGuncelle";
            this.Text = "RehberiGuncelle";
            this.Load += new System.EventHandler(this.RehberiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBx_AdListesi;
        private System.Windows.Forms.TextBox txtBx_Ad;
        private System.Windows.Forms.TextBox txtBx_Soyad;
        private System.Windows.Forms.TextBox txtBx_Tel;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Vazgec;
    }
}