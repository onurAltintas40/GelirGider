using System;
using System.Drawing;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        double gelirToplam, giderToplam, alacakToplam, borcToplam;
        void ToplamGetir()
        {
            var sonucGelir = Veritabani.GelirToplam();
            var sonucGider = Veritabani.GiderToplam();
            var sonucAlacak = Veritabani.AlacakToplam();
            var sonucBorc = Veritabani.BorcToplam();

            if (sonucGelir.Read())
            {
                if (sonucGelir["Toplam"] is null)
                {
                    gelirToplam = (double)sonucGelir["Toplam"];
                }                
            }

            if (sonucGider.Read())
            {
                if (sonucGider["Toplam"] is null)
                {
                    giderToplam = (double)sonucGider["Toplam"];
                }                
            }

            if (sonucAlacak.Read())
            {
                if (sonucAlacak["Toplam"] is null)
                {
                    alacakToplam = (double)sonucAlacak["Toplam"];
                }                
            }

            if (sonucBorc.Read())
            {
                if (sonucBorc["Toplam"] is null)
                {
                    borcToplam = (double)sonucBorc["Toplam"];
                }                
            }

            txtGelirToplam.Text = gelirToplam.ToString() + " TL";
            txtGiderToplam.Text = giderToplam.ToString() + " TL";
            txtAlacakToplam.Text = alacakToplam.ToString() + " TL";
            txtBorcToplam.Text = borcToplam.ToString() + " TL";

            txtGelirAlacakToplam.Text = (gelirToplam + alacakToplam).ToString() + " TL";
            txtGiderBorcToplam.Text = (giderToplam + borcToplam).ToString() + " TL";

        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void tsCikis_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void btnGelirİslemleri_Click(object sender, System.EventArgs e)
        {
            Gelir g = new Gelir();
            g.ShowDialog();
        }
        private void AnaMenu_Load(object sender, System.EventArgs e)
        {
            var sonucAlacak = Veritabani.AlacakListele();
            var sonucBorcListele = Veritabani.BorcListele();

            dtAlacaklar.DataSource = sonucAlacak;
            dtBorclar.DataSource = sonucBorcListele;
            dtBorclar.Columns[0].Width = 50;
            dtAlacaklar.Columns[0].Width = 50;
            dtBorclar.Columns[1].Width = 130;
            dtAlacaklar.Columns[1].Width = 130;
            dtBorclar.Columns[2].Width = 130;
            dtAlacaklar.Columns[2].Width = 130;
            dtBorclar.Columns[3].Width = 130;
            dtAlacaklar.Columns[3].Width = 130;
            dtBorclar.Columns[4].Width = 130;
            dtAlacaklar.Columns[4].Width = 130;
            dtBorclar.Columns[5].Width = 170;
            dtAlacaklar.Columns[5].Width = 170;

            for (int i = 0; i < dtAlacaklar.RowCount - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if ((DateTime.Parse(dtAlacaklar.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays <= 2 && (DateTime.Parse(dtAlacaklar.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays > -1)
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                else if ((DateTime.Parse(dtAlacaklar.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays <= 5 && (DateTime.Parse(dtAlacaklar.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays > -1)
                {
                    renk.BackColor = Color.Yellow;
                }
                dtAlacaklar.Rows[i].DefaultCellStyle = renk;
            }

            for (int i = 0; i < dtBorclar.RowCount - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if ((DateTime.Parse(dtBorclar.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays <= 2)
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                else if ((DateTime.Parse(dtBorclar.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays <= 5)
                {
                    renk.BackColor = Color.Yellow;
                }
                dtBorclar.Rows[i].DefaultCellStyle = renk;
            }

            ToplamGetir();

        }
        private void gelirTürüİşlemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GelirTuru gt = new GelirTuru();
            gt.ShowDialog();
        }
        private void tsGiderTuru_Click(object sender, System.EventArgs e)
        {
            GiderTuru gi = new GiderTuru();
            gi.ShowDialog();
        }
        private void btnBorcİslemleri_Click(object sender, System.EventArgs e)
        {
            Borc b = new Borc();
            b.ShowDialog();
        }
        private void btnAlacakİslemleri_Click(object sender, System.EventArgs e)
        {
            Alacak a = new Alacak();
            a.ShowDialog();
        }
        private void btnGiderİslemleri_Click(object sender, System.EventArgs e)
        {
            Gider g = new Gider();
            g.ShowDialog();
        }
        private void gelirİşlemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Gelir g = new Gelir();
            g.ShowDialog();
        }
        private void tsGiderİslemleri_Click(object sender, System.EventArgs e)
        {
            Gider g = new Gider();
            g.ShowDialog();
        }
        private void tsAlacakİslemleri_Click(object sender, System.EventArgs e)
        {
            Alacak a = new Alacak();
            a.ShowDialog();
        }
        private void tsBorcİslemleri_Click(object sender, System.EventArgs e)
        {
            Borc b = new Borc();
            b.ShowDialog();
        }
        private void tsKullaniciislemleri_Click(object sender, EventArgs e)
        {
            KullaniciDuzenle k = new KullaniciDuzenle();
            k.ShowDialog();
        }
    }
}
