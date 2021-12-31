
namespace GelirGider
{
    partial class GiderTuru
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
            this.dtGiderTuru = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtGiderTuru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGiderTuru)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGiderTuru
            // 
            this.dtGiderTuru.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtGiderTuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGiderTuru.Location = new System.Drawing.Point(12, 86);
            this.dtGiderTuru.Name = "dtGiderTuru";
            this.dtGiderTuru.RowTemplate.Height = 25;
            this.dtGiderTuru.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGiderTuru.Size = new System.Drawing.Size(240, 268);
            this.dtGiderTuru.TabIndex = 8;
            this.dtGiderTuru.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGiderTuru_CellMouseDoubleClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(79, 45);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(101, 35);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(7, 45);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(66, 35);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtGiderTuru
            // 
            this.txtGiderTuru.Location = new System.Drawing.Point(88, 6);
            this.txtGiderTuru.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiderTuru.Name = "txtGiderTuru";
            this.txtGiderTuru.Size = new System.Drawing.Size(164, 26);
            this.txtGiderTuru.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gider Türü:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(186, 45);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(66, 35);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // GiderTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 363);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dtGiderTuru);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtGiderTuru);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GiderTuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Türü";
            this.Load += new System.EventHandler(this.GiderTuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGiderTuru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGiderTuru;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtGiderTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
    }
}