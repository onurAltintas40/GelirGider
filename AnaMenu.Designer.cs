
namespace GelirGider
{
    partial class AnaMenu
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
            this.btnGelirİslemleri = new System.Windows.Forms.Button();
            this.btnGiderİslemleri = new System.Windows.Forms.Button();
            this.btnAlacakİslemleri = new System.Windows.Forms.Button();
            this.btnBorcİslemleri = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtAlacaklar = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtBorclar = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsGelirİslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGiderİslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAlacakİslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBorcİslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGelirTuru = new System.Windows.Forms.ToolStripMenuItem();
            this.tsKullaniciislemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirTürüİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGiderTuru = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBorcToplam = new System.Windows.Forms.TextBox();
            this.txtGiderToplam = new System.Windows.Forms.TextBox();
            this.txtAlacakToplam = new System.Windows.Forms.TextBox();
            this.txtGiderBorcToplam = new System.Windows.Forms.TextBox();
            this.txtGelirAlacakToplam = new System.Windows.Forms.TextBox();
            this.txtGelirToplam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlacaklar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBorclar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGelirİslemleri
            // 
            this.btnGelirİslemleri.Location = new System.Drawing.Point(17, 34);
            this.btnGelirİslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGelirİslemleri.Name = "btnGelirİslemleri";
            this.btnGelirİslemleri.Size = new System.Drawing.Size(180, 55);
            this.btnGelirİslemleri.TabIndex = 0;
            this.btnGelirİslemleri.Text = "Gelir İşlemleri";
            this.btnGelirİslemleri.UseVisualStyleBackColor = true;
            this.btnGelirİslemleri.Click += new System.EventHandler(this.btnGelirİslemleri_Click);
            // 
            // btnGiderİslemleri
            // 
            this.btnGiderİslemleri.Location = new System.Drawing.Point(17, 97);
            this.btnGiderİslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiderİslemleri.Name = "btnGiderİslemleri";
            this.btnGiderİslemleri.Size = new System.Drawing.Size(180, 55);
            this.btnGiderİslemleri.TabIndex = 1;
            this.btnGiderİslemleri.Text = "Gider İşlemleri";
            this.btnGiderİslemleri.UseVisualStyleBackColor = true;
            this.btnGiderİslemleri.Click += new System.EventHandler(this.btnGiderİslemleri_Click);
            // 
            // btnAlacakİslemleri
            // 
            this.btnAlacakİslemleri.Location = new System.Drawing.Point(259, 34);
            this.btnAlacakİslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlacakİslemleri.Name = "btnAlacakİslemleri";
            this.btnAlacakİslemleri.Size = new System.Drawing.Size(180, 55);
            this.btnAlacakİslemleri.TabIndex = 2;
            this.btnAlacakİslemleri.Text = "Alacak İşlemleri";
            this.btnAlacakİslemleri.UseVisualStyleBackColor = true;
            this.btnAlacakİslemleri.Click += new System.EventHandler(this.btnAlacakİslemleri_Click);
            // 
            // btnBorcİslemleri
            // 
            this.btnBorcİslemleri.Location = new System.Drawing.Point(259, 97);
            this.btnBorcİslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorcİslemleri.Name = "btnBorcİslemleri";
            this.btnBorcİslemleri.Size = new System.Drawing.Size(180, 55);
            this.btnBorcİslemleri.TabIndex = 3;
            this.btnBorcİslemleri.Text = "Borç İşlemleri";
            this.btnBorcİslemleri.UseVisualStyleBackColor = true;
            this.btnBorcİslemleri.Click += new System.EventHandler(this.btnBorcİslemleri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorcİslemleri);
            this.groupBox1.Controls.Add(this.btnGelirİslemleri);
            this.groupBox1.Controls.Add(this.btnAlacakİslemleri);
            this.groupBox1.Controls.Add(this.btnGiderİslemleri);
            this.groupBox1.Location = new System.Drawing.Point(20, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtAlacaklar);
            this.groupBox2.Location = new System.Drawing.Point(20, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 336);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alacaklar";
            // 
            // dtAlacaklar
            // 
            this.dtAlacaklar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtAlacaklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlacaklar.Location = new System.Drawing.Point(6, 25);
            this.dtAlacaklar.Name = "dtAlacaklar";
            this.dtAlacaklar.ReadOnly = true;
            this.dtAlacaklar.RowHeadersWidth = 51;
            this.dtAlacaklar.RowTemplate.Height = 25;
            this.dtAlacaklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtAlacaklar.Size = new System.Drawing.Size(896, 300);
            this.dtAlacaklar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtBorclar);
            this.groupBox3.Location = new System.Drawing.Point(20, 571);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(908, 338);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Borçlar";
            // 
            // dtBorclar
            // 
            this.dtBorclar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtBorclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBorclar.Location = new System.Drawing.Point(6, 25);
            this.dtBorclar.Name = "dtBorclar";
            this.dtBorclar.ReadOnly = true;
            this.dtBorclar.RowHeadersWidth = 51;
            this.dtBorclar.RowTemplate.Height = 25;
            this.dtBorclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtBorclar.Size = new System.Drawing.Size(896, 300);
            this.dtBorclar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGelirİslemleri,
            this.tsGelirTuru,
            this.tsCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsGelirİslemleri
            // 
            this.tsGelirİslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirİşlemleriToolStripMenuItem,
            this.tsGiderİslemleri,
            this.tsAlacakİslemleri,
            this.tsBorcİslemleri});
            this.tsGelirİslemleri.Name = "tsGelirİslemleri";
            this.tsGelirİslemleri.Size = new System.Drawing.Size(60, 20);
            this.tsGelirİslemleri.Text = "İşlemler";
            // 
            // gelirİşlemleriToolStripMenuItem
            // 
            this.gelirİşlemleriToolStripMenuItem.Name = "gelirİşlemleriToolStripMenuItem";
            this.gelirİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gelirİşlemleriToolStripMenuItem.Text = "Gelir İşlemleri";
            this.gelirİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.gelirİşlemleriToolStripMenuItem_Click);
            // 
            // tsGiderİslemleri
            // 
            this.tsGiderİslemleri.Name = "tsGiderİslemleri";
            this.tsGiderİslemleri.Size = new System.Drawing.Size(156, 22);
            this.tsGiderİslemleri.Text = "Gider İşlemleri";
            this.tsGiderİslemleri.Click += new System.EventHandler(this.tsGiderİslemleri_Click);
            // 
            // tsAlacakİslemleri
            // 
            this.tsAlacakİslemleri.Name = "tsAlacakİslemleri";
            this.tsAlacakİslemleri.Size = new System.Drawing.Size(156, 22);
            this.tsAlacakİslemleri.Text = "Alacak İşlemleri";
            this.tsAlacakİslemleri.Click += new System.EventHandler(this.tsAlacakİslemleri_Click);
            // 
            // tsBorcİslemleri
            // 
            this.tsBorcİslemleri.Name = "tsBorcİslemleri";
            this.tsBorcİslemleri.Size = new System.Drawing.Size(156, 22);
            this.tsBorcİslemleri.Text = "Borç İşlemleri";
            this.tsBorcİslemleri.Click += new System.EventHandler(this.tsBorcİslemleri_Click);
            // 
            // tsGelirTuru
            // 
            this.tsGelirTuru.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsKullaniciislemleri,
            this.gelirTürüİşlemleriToolStripMenuItem,
            this.tsGiderTuru});
            this.tsGelirTuru.Name = "tsGelirTuru";
            this.tsGelirTuru.Size = new System.Drawing.Size(56, 20);
            this.tsGelirTuru.Text = "Ayarlar";
            // 
            // tsKullaniciislemleri
            // 
            this.tsKullaniciislemleri.Name = "tsKullaniciislemleri";
            this.tsKullaniciislemleri.Size = new System.Drawing.Size(176, 22);
            this.tsKullaniciislemleri.Text = "Kullanıcı İşlemleri";
            this.tsKullaniciislemleri.Click += new System.EventHandler(this.tsKullaniciislemleri_Click);
            // 
            // gelirTürüİşlemleriToolStripMenuItem
            // 
            this.gelirTürüİşlemleriToolStripMenuItem.Name = "gelirTürüİşlemleriToolStripMenuItem";
            this.gelirTürüİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.gelirTürüİşlemleriToolStripMenuItem.Text = "Gelir Türü İşlemleri";
            this.gelirTürüİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.gelirTürüİşlemleriToolStripMenuItem_Click);
            // 
            // tsGiderTuru
            // 
            this.tsGiderTuru.Name = "tsGiderTuru";
            this.tsGiderTuru.Size = new System.Drawing.Size(176, 22);
            this.tsGiderTuru.Text = "Gider Türü İşlemleri";
            this.tsGiderTuru.Click += new System.EventHandler(this.tsGiderTuru_Click);
            // 
            // tsCikis
            // 
            this.tsCikis.Name = "tsCikis";
            this.tsCikis.Size = new System.Drawing.Size(46, 20);
            this.tsCikis.Text = "ÇIKIŞ";
            this.tsCikis.Click += new System.EventHandler(this.tsCikis_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBorcToplam);
            this.groupBox4.Controls.Add(this.txtGiderToplam);
            this.groupBox4.Controls.Add(this.txtAlacakToplam);
            this.groupBox4.Controls.Add(this.txtGiderBorcToplam);
            this.groupBox4.Controls.Add(this.txtGelirAlacakToplam);
            this.groupBox4.Controls.Add(this.txtGelirToplam);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label77);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(482, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 170);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tutarlar";
            // 
            // txtBorcToplam
            // 
            this.txtBorcToplam.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBorcToplam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBorcToplam.ForeColor = System.Drawing.Color.Red;
            this.txtBorcToplam.Location = new System.Drawing.Point(69, 134);
            this.txtBorcToplam.Name = "txtBorcToplam";
            this.txtBorcToplam.ReadOnly = true;
            this.txtBorcToplam.Size = new System.Drawing.Size(137, 26);
            this.txtBorcToplam.TabIndex = 4;
            this.txtBorcToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGiderToplam
            // 
            this.txtGiderToplam.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtGiderToplam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGiderToplam.ForeColor = System.Drawing.Color.Red;
            this.txtGiderToplam.Location = new System.Drawing.Point(69, 99);
            this.txtGiderToplam.Name = "txtGiderToplam";
            this.txtGiderToplam.ReadOnly = true;
            this.txtGiderToplam.Size = new System.Drawing.Size(137, 26);
            this.txtGiderToplam.TabIndex = 4;
            this.txtGiderToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlacakToplam
            // 
            this.txtAlacakToplam.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtAlacakToplam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAlacakToplam.ForeColor = System.Drawing.Color.Red;
            this.txtAlacakToplam.Location = new System.Drawing.Point(69, 64);
            this.txtAlacakToplam.Name = "txtAlacakToplam";
            this.txtAlacakToplam.ReadOnly = true;
            this.txtAlacakToplam.Size = new System.Drawing.Size(137, 26);
            this.txtAlacakToplam.TabIndex = 4;
            this.txtAlacakToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGiderBorcToplam
            // 
            this.txtGiderBorcToplam.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtGiderBorcToplam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGiderBorcToplam.ForeColor = System.Drawing.Color.Red;
            this.txtGiderBorcToplam.Location = new System.Drawing.Point(244, 121);
            this.txtGiderBorcToplam.Name = "txtGiderBorcToplam";
            this.txtGiderBorcToplam.ReadOnly = true;
            this.txtGiderBorcToplam.Size = new System.Drawing.Size(137, 26);
            this.txtGiderBorcToplam.TabIndex = 4;
            this.txtGiderBorcToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGelirAlacakToplam
            // 
            this.txtGelirAlacakToplam.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtGelirAlacakToplam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGelirAlacakToplam.ForeColor = System.Drawing.Color.Red;
            this.txtGelirAlacakToplam.Location = new System.Drawing.Point(244, 53);
            this.txtGelirAlacakToplam.Name = "txtGelirAlacakToplam";
            this.txtGelirAlacakToplam.ReadOnly = true;
            this.txtGelirAlacakToplam.Size = new System.Drawing.Size(137, 26);
            this.txtGelirAlacakToplam.TabIndex = 4;
            this.txtGelirAlacakToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGelirToplam
            // 
            this.txtGelirToplam.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtGelirToplam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGelirToplam.ForeColor = System.Drawing.Color.Red;
            this.txtGelirToplam.Location = new System.Drawing.Point(69, 28);
            this.txtGelirToplam.Name = "txtGelirToplam";
            this.txtGelirToplam.ReadOnly = true;
            this.txtGelirToplam.Size = new System.Drawing.Size(137, 26);
            this.txtGelirToplam.TabIndex = 4;
            this.txtGelirToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alacak:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(21, 137);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(42, 19);
            this.label77.TabIndex = 2;
            this.label77.Text = "Borç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gider:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gider ve Borc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gelir ve Alacak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gelir:";
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 923);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaMenu_FormClosed);
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAlacaklar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtBorclar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGiderİslemleri;
        private System.Windows.Forms.Button btnAlacakİslemleri;
        private System.Windows.Forms.Button btnBorcİslemleri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsGelirİslemleri;
        private System.Windows.Forms.ToolStripMenuItem gelirİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsGiderİslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsAlacakİslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsBorcİslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsGelirTuru;
        private System.Windows.Forms.ToolStripMenuItem tsKullaniciislemleri;
        private System.Windows.Forms.ToolStripMenuItem tsCikis;
        private System.Windows.Forms.DataGridView dtAlacaklar;
        private System.Windows.Forms.DataGridView dtBorclar;
        private System.Windows.Forms.ToolStripMenuItem gelirTürüİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsGiderTuru;
        private System.Windows.Forms.Button btnGelirİslemleri;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBorcToplam;
        private System.Windows.Forms.TextBox txtGiderToplam;
        private System.Windows.Forms.TextBox txtAlacakToplam;
        private System.Windows.Forms.TextBox txtGelirToplam;
        private System.Windows.Forms.TextBox txtGiderBorcToplam;
        private System.Windows.Forms.TextBox txtGelirAlacakToplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}