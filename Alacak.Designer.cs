﻿
namespace GelirGider
{
    partial class Alacak
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAlacakTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtAlacakListesi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKimden = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlacakListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKimden);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtOdemeTarihi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtAciklama);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbAlacakTuru);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 226);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // dtOdemeTarihi
            // 
            this.dtOdemeTarihi.Location = new System.Drawing.Point(113, 115);
            this.dtOdemeTarihi.Name = "dtOdemeTarihi";
            this.dtOdemeTarihi.Size = new System.Drawing.Size(217, 23);
            this.dtOdemeTarihi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ödeme Tarihi:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(493, 19);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(84, 34);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(391, 71);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(186, 23);
            this.txtTutar.TabIndex = 3;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(228, 153);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 53);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(119, 153);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(103, 53);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(10, 153);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 53);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAciklama.Location = new System.Drawing.Point(348, 115);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(229, 91);
            this.txtAciklama.TabIndex = 5;
            this.txtAciklama.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alacak Türü:";
            // 
            // cmbAlacakTuru
            // 
            this.cmbAlacakTuru.FormattingEnabled = true;
            this.cmbAlacakTuru.Location = new System.Drawing.Point(113, 31);
            this.cmbAlacakTuru.Name = "cmbAlacakTuru";
            this.cmbAlacakTuru.Size = new System.Drawing.Size(217, 23);
            this.cmbAlacakTuru.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tutar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtAlacakListesi);
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(948, 488);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alacak Listesi";
            // 
            // dtAlacakListesi
            // 
            this.dtAlacakListesi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtAlacakListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlacakListesi.Location = new System.Drawing.Point(6, 29);
            this.dtAlacakListesi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtAlacakListesi.Name = "dtAlacakListesi";
            this.dtAlacakListesi.RowHeadersWidth = 51;
            this.dtAlacakListesi.RowTemplate.Height = 29;
            this.dtAlacakListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAlacakListesi.Size = new System.Drawing.Size(932, 453);
            this.dtAlacakListesi.TabIndex = 0;
            this.dtAlacakListesi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGelirListesi_CellMouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kimden:";
            // 
            // txtKimden
            // 
            this.txtKimden.Location = new System.Drawing.Point(113, 71);
            this.txtKimden.Name = "txtKimden";
            this.txtKimden.Size = new System.Drawing.Size(217, 23);
            this.txtKimden.TabIndex = 2;
            // 
            // Alacak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 744);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alacak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alacak";
            this.Load += new System.EventHandler(this.Alacak_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAlacakListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtAlacakListesi;
        private System.Windows.Forms.DateTimePicker dtOdemeTarihi;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTutar;
        public System.Windows.Forms.RichTextBox txtAciklama;
        public System.Windows.Forms.ComboBox cmbAlacakTuru;
        private System.Windows.Forms.TextBox txtKimden;
        private System.Windows.Forms.Label label5;
    }
}