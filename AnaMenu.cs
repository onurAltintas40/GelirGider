using System.Windows.Forms;

namespace GelirGider
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
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
            dtBorclar.Columns[5].Width = 130;
            dtAlacaklar.Columns[5].Width = 130;
            dtBorclar.Columns[6].Width = 140;
            dtAlacaklar.Columns[6].Width = 140;
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
    }
}
