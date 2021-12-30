
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGelirTuru = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.chkOdemeAlindi = new System.Windows.Forms.CheckBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtGelirListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.dtGelirListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGelirListesi.Size = new System.Drawing.Size(932, 396);
            this.dtGelirListesi.TabIndex = 0;
            this.dtGelirListesi.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGelirListesi_RowHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGelirListesi);
            this.groupBox1.Location = new System.Drawing.Point(12, 313);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(948, 431);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelir Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gelir Türü:";
            // 
            // cmbGelirTuru
            // 
            this.cmbGelirTuru.FormattingEnabled = true;
            this.cmbGelirTuru.Location = new System.Drawing.Point(114, 43);
            this.cmbGelirTuru.Name = "cmbGelirTuru";
            this.cmbGelirTuru.Size = new System.Drawing.Size(325, 27);
            this.cmbGelirTuru.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.chkOdemeAlindi);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtAciklama);
            this.groupBox2.Controls.Add(this.dtTarih);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbGelirTuru);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(948, 283);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(114, 94);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(325, 26);
            this.txtTutar.TabIndex = 2;
            // 
            // chkOdemeAlindi
            // 
            this.chkOdemeAlindi.AutoSize = true;
            this.chkOdemeAlindi.Location = new System.Drawing.Point(603, 42);
            this.chkOdemeAlindi.Name = "chkOdemeAlindi";
            this.chkOdemeAlindi.Size = new System.Drawing.Size(111, 23);
            this.chkOdemeAlindi.TabIndex = 4;
            this.chkOdemeAlindi.Text = "Ödeme Alındı";
            this.chkOdemeAlindi.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(422, 201);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 63);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(226, 201);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(127, 63);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(26, 201);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(127, 63);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAciklama.Location = new System.Drawing.Point(603, 95);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(325, 172);
            this.txtAciklama.TabIndex = 5;
            this.txtAciklama.Text = "";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(114, 145);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(325, 26);
            this.dtTarih.TabIndex = 3;
            // 
            // Gelir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 756);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGelirListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGelirTuru;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.CheckBox chkOdemeAlindi;
        private System.Windows.Forms.TextBox txtTutar;
    }
}