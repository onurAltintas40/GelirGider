using System;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class Gelir : Form
    {
        public Gelir()
        {
            InitializeComponent();
        }
       
        private void Gelir_Load(object sender, System.EventArgs e)
        {
            var gelirTuruSonuc = Veritabani.GelirTuruListele();

            cmbGelirTuru.Items.Clear();
            while (gelirTuruSonuc.Read())
            {
                cmbGelirTuru.Items.Add(gelirTuruSonuc["GelirTuru"]);
            }

            Temizle();
        }

        void Temizle()
        {
            var gelirSonuc = Veritabani.GelirListele();
            dtGelirListesi.DataSource = gelirSonuc;

            cmbGelirTuru.Text = "Gelir Türü Seçin";
            cmbGelirTuru.Tag = null;
            txtAciklama.Clear();
            txtTutar.Clear();
            dtTarih.Value = DateTime.Now;
            chkOdemeAlindi.Checked = false;
            txtTutar.Focus();

        }
        private void dtGelirListesi_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbGelirTuru.Tag = dtGelirListesi.CurrentRow.Cells[0].Value.ToString();
            txtTutar.Text = dtGelirListesi.CurrentRow.Cells[1].Value.ToString();
            dtTarih.Value = DateTime.Parse((string)dtGelirListesi.CurrentRow.Cells[2].Value);
            txtAciklama.SelectedText = dtGelirListesi.CurrentRow.Cells[3].Value.ToString();
            cmbGelirTuru.SelectedText = dtGelirListesi.CurrentRow.Cells[4].Value.ToString();
            chkOdemeAlindi.Checked = (int)dtGelirListesi.CurrentRow.Cells[5].Value == 1 ? true : false;

            Temizle();
        }
        private void btnEkle_Click(object sender, System.EventArgs e)
        {
            int odeme = chkOdemeAlindi.Checked == true ? 1 : 0;           

            Veritabani.GelirEkle(Double.Parse(txtTutar.Text),dtTarih.Value.ToString(),txtAciklama.Text,cmbGelirTuru.Text,odeme);
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int odeme = chkOdemeAlindi.Checked == true ? 1 : 0;
            Veritabani.GelirGuncelle(Double.Parse(txtTutar.Text), dtTarih.Value.ToString(), txtAciklama.Text, cmbGelirTuru.Text, odeme,Int32.Parse((string)cmbGelirTuru.Tag));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Veritabani.GelirSil(Int32.Parse((string)cmbGelirTuru.Tag));
            Temizle();
        }
    }
}
