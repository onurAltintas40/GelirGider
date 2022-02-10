
namespace GelirGider
{
    partial class Gelir
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
            this.dtGelirListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGelirTuru = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.chkOdemeAlindi = new System.Windows.Forms.CheckBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbGelirTuruAra = new System.Windows.Forms.ComboBox();
            this.btnTarihAra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTutarToplam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGelirListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGelirListesi
            // 
            this.dtGelirListesi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtGelirListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGelirListesi.Location = new System.Drawing.Point(6, 29);
            this.dtGelirListesi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtGelirListesi.Name = "dtGelirListesi";
            this.dtGelirListesi.RowHeadersWidth = 51;
            this.dtGelirListesi.RowTemplate.Height = 29;
            this.dtGelirListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtGelirListesi.Size = new System.Drawing.Size(960, 497);
            this.dtGelirListesi.TabIndex = 0;
            this.dtGelirListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGelirListesi_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGelirListesi);
            this.groupBox1.Location = new System.Drawing.Point(12, 356);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(974, 532);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelir Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gelir Türü:";
            // 
            // cmbGelirTuru
            // 
            this.cmbGelirTuru.FormattingEnabled = true;
            this.cmbGelirTuru.Location = new System.Drawing.Point(114, 31);
            this.cmbGelirTuru.Name = "cmbGelirTuru";
            this.cmbGelirTuru.Size = new System.Drawing.Size(295, 30);
            this.cmbGelirTuru.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.chkOdemeAlindi);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtAciklama);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbGelirTuru);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 238);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(586, 22);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(116, 34);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(114, 80);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(295, 30);
            this.txtTutar.TabIndex = 2;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // chkOdemeAlindi
            // 
            this.chkOdemeAlindi.AutoSize = true;
            this.chkOdemeAlindi.Location = new System.Drawing.Point(114, 129);
            this.chkOdemeAlindi.Name = "chkOdemeAlindi";
            this.chkOdemeAlindi.Size = new System.Drawing.Size(143, 26);
            this.chkOdemeAlindi.TabIndex = 4;
            this.chkOdemeAlindi.Text = "Ödeme Alındı";
            this.chkOdemeAlindi.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(289, 177);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 55);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(148, 177);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 55);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(8, 177);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 55);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAciklama.Location = new System.Drawing.Point(430, 113);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(272, 114);
            this.txtAciklama.TabIndex = 5;
            this.txtAciklama.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbGelirTuruAra);
            this.groupBox4.Controls.Add(this.btnTarihAra);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dtBitis);
            this.groupBox4.Controls.Add(this.dtBaslangic);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(974, 94);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Arama:";
            // 
            // cmbGelirTuruAra
            // 
            this.cmbGelirTuruAra.FormattingEnabled = true;
            this.cmbGelirTuruAra.Location = new System.Drawing.Point(6, 54);
            this.cmbGelirTuruAra.Name = "cmbGelirTuruAra";
            this.cmbGelirTuruAra.Size = new System.Drawing.Size(201, 30);
            this.cmbGelirTuruAra.TabIndex = 21;
            this.cmbGelirTuruAra.SelectedIndexChanged += new System.EventHandler(this.cmbGelirTuruAra_SelectedIndexChanged);
            // 
            // btnTarihAra
            // 
            this.btnTarihAra.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTarihAra.Location = new System.Drawing.Point(854, 22);
            this.btnTarihAra.Name = "btnTarihAra";
            this.btnTarihAra.Size = new System.Drawing.Size(112, 66);
            this.btnTarihAra.TabIndex = 20;
            this.btnTarihAra.Text = "Tarihe Göre Ara";
            this.btnTarihAra.UseVisualStyleBackColor = true;
            this.btnTarihAra.Click += new System.EventHandler(this.btnTarihAra_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bitiş:";
            // 
            // dtBitis
            // 
            this.dtBitis.Location = new System.Drawing.Point(573, 54);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(268, 30);
            this.dtBitis.TabIndex = 18;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Location = new System.Drawing.Point(283, 54);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(270, 30);
            this.dtBaslangic.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Başlangıç:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Gelir Türüne Göre Ara:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTutarToplam);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(727, 125);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(259, 125);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // txtTutarToplam
            // 
            this.txtTutarToplam.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTutarToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTutarToplam.ForeColor = System.Drawing.Color.Red;
            this.txtTutarToplam.Location = new System.Drawing.Point(7, 72);
            this.txtTutarToplam.Name = "txtTutarToplam";
            this.txtTutarToplam.ReadOnly = true;
            this.txtTutarToplam.Size = new System.Drawing.Size(244, 30);
            this.txtTutarToplam.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tutar:";
            // 
            // Gelir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 894);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Gelir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir";
            this.Load += new System.EventHandler(this.Gelir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGelirListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGelirListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGelirTuru;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.CheckBox chkOdemeAlindi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTarihAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTutarToplam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGelirTuruAra;
    }
}