using System.Windows.Forms;

namespace GelirGider
{
    public partial class Gelir : Form
    {
        public Gelir()
        {
            InitializeComponent();
        }

        private Veritabani db = new Veritabani();
        private void Gelir_Load(object sender, System.EventArgs e)
        {
            var gelirSonuc = Veritabani.GelirListele();
            dtGelirListesi.DataSource = gelirSonuc;

            var gelirTuruSonuc = Veritabani.GelirTuruListele();

            while (gelirTuruSonuc.Read())
            {
                cmbGelirTuru.Items.Add(gelirTuruSonuc["GelirTuru"]);
            }       
        }
    }
}
