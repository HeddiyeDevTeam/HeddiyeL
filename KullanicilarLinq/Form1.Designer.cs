﻿namespace KullanicilarLinq
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnadmin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBurc = new System.Windows.Forms.ComboBox();
            this.cmbYakinlikDerecesi = new System.Windows.Forms.ComboBox();
            this.cmbHediyeAmac = new System.Windows.Forms.ComboBox();
            this.cmbYasAraligi = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.libUrunler = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.IndianRed;
            this.btnadmin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadmin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnadmin.Location = new System.Drawing.Point(231, 18);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(89, 28);
            this.btnadmin.TabIndex = 10;
            this.btnadmin.Text = "Admin Giriş";
            this.btnadmin.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbBurc);
            this.groupBox1.Controls.Add(this.cmbYakinlikDerecesi);
            this.groupBox1.Controls.Add(this.cmbHediyeAmac);
            this.groupBox1.Controls.Add(this.cmbYasAraligi);
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(231, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 316);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hediye Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sizin...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hediye alacağınız kişinin...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(93, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "LİSTELE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cmbBurc
            // 
            this.cmbBurc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBurc.FormattingEnabled = true;
            this.cmbBurc.Location = new System.Drawing.Point(6, 134);
            this.cmbBurc.Name = "cmbBurc";
            this.cmbBurc.Size = new System.Drawing.Size(262, 27);
            this.cmbBurc.TabIndex = 2;
            this.cmbBurc.Text = "Burcu?";
            // 
            // cmbYakinlikDerecesi
            // 
            this.cmbYakinlikDerecesi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYakinlikDerecesi.FormattingEnabled = true;
            this.cmbYakinlikDerecesi.Location = new System.Drawing.Point(6, 245);
            this.cmbYakinlikDerecesi.Name = "cmbYakinlikDerecesi";
            this.cmbYakinlikDerecesi.Size = new System.Drawing.Size(262, 27);
            this.cmbYakinlikDerecesi.TabIndex = 4;
            this.cmbYakinlikDerecesi.Text = "Hediyeyi alacağınız kişi neyiniz olur?";
            // 
            // cmbHediyeAmac
            // 
            this.cmbHediyeAmac.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHediyeAmac.FormattingEnabled = true;
            this.cmbHediyeAmac.Location = new System.Drawing.Point(6, 212);
            this.cmbHediyeAmac.Name = "cmbHediyeAmac";
            this.cmbHediyeAmac.Size = new System.Drawing.Size(262, 27);
            this.cmbHediyeAmac.TabIndex = 3;
            this.cmbHediyeAmac.Text = "Hediyeyi alma nedeniniz?";
            // 
            // cmbYasAraligi
            // 
            this.cmbYasAraligi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYasAraligi.FormattingEnabled = true;
            this.cmbYasAraligi.Location = new System.Drawing.Point(6, 101);
            this.cmbYasAraligi.Name = "cmbYasAraligi";
            this.cmbYasAraligi.Size = new System.Drawing.Size(262, 27);
            this.cmbYasAraligi.TabIndex = 1;
            this.cmbYasAraligi.Text = "Yaşı?";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Cinsiyeti?"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(6, 68);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(262, 27);
            this.cmbCinsiyet.TabIndex = 0;
            this.cmbCinsiyet.Text = "Cinsiyeti?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(360, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(531, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ürün Listesi";
            // 
            // libUrunler
            // 
            this.libUrunler.FormattingEnabled = true;
            this.libUrunler.Location = new System.Drawing.Point(525, 132);
            this.libUrunler.Name = "libUrunler";
            this.libUrunler.Size = new System.Drawing.Size(212, 277);
            this.libUrunler.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.libUrunler);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbBurc;
        private System.Windows.Forms.ComboBox cmbYakinlikDerecesi;
        private System.Windows.Forms.ComboBox cmbHediyeAmac;
        private System.Windows.Forms.ComboBox cmbYasAraligi;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox libUrunler;
    }
}

