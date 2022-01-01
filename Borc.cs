using System;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class Borc : Form
    {
        public Borc()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            var borcSonuc = Veritabani.BorcListele();
            dtBorcListesi.DataSource = borcSonuc;

            cmbBorcTuru.Text = "Borç Türü Seçin";
            cmbBorcTuru.Tag = null;
            txtAciklama.Clear();
            txtTutar.Clear();
            dtOdemeTarihi.Value = DateTime.Now;
            txtTutar.Focus();
        }
        private void Borc_Load(object sender, EventArgs e)
        {
            var giderTuruSonuc = Veritabani.GiderTuruListele();

            cmbBorcTuru.Items.Clear();
            while (giderTuruSonuc.Read())
            {
                cmbBorcTuru.Items.Add(giderTuruSonuc["GiderTuru"]);
            }

            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbBorcTuru.Text != "Borç Türü Seçin" && txtTutar.Text != "")
            {
                Veritabani.BorcEkle(Double.Parse(txtTutar.Text), dtOdemeTarihi.Value.ToString(), DateTime.Now.ToString(), cmbBorcTuru.SelectedText, txtAciklama.Text);
                Temizle();
            }
            else
            {
                MessageBox.Show("Borç Türü ve Tutar boş olamaz !!!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbBorcTuru.Tag == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin!!!");
            }
            else
            {
                if (cmbBorcTuru.Text != "Borç Türü Seçin" && txtTutar.Text != "")
                {
                    Veritabani.BorcGuncelle(Double.Parse(txtTutar.Text), dtOdemeTarihi.Value.ToString(), DateTime.Now.ToString(), cmbBorcTuru.SelectedText, txtAciklama.Text, Int32.Parse(cmbBorcTuru.Tag.ToString()));
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Borç Türü ve Tutar boş olamaz !!!");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbBorcTuru.Tag == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin!!!");
            }
            else
            {
                Veritabani.BorcSil(Int32.Parse((string)cmbBorcTuru.Tag));
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dtBorcListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbBorcTuru.Tag = dtBorcListesi.CurrentRow.Cells[0].Value.ToString();            
            dtOdemeTarihi.Value = DateTime.Parse(dtBorcListesi.CurrentRow.Cells[2].Value.ToString());
            cmbBorcTuru.SelectedText = dtBorcListesi.CurrentRow.Cells[3].Value.ToString();
            txtAciklama.Text = dtBorcListesi.CurrentRow.Cells[4].Value.ToString();
            txtTutar.Text = dtBorcListesi.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
