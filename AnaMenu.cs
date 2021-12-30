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
        }
    }
}
