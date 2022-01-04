using System;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class Alacak : Form
    {
        public Alacak()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            var alacakSonuc = Veritabani.AlacakListele();
            dtAlacakListesi.DataSource = alacakSonuc;
            dtAlacakListesi.Columns[0].Width = 50;
            dtAlacakListesi.Columns[1].Width = 130;
            dtAlacakListesi.Columns[2].Width = 130;
            dtAlacakListesi.Columns[3].Width = 130;
            dtAlacakListesi.Columns[4].Width = 130;
            dtAlacakListesi.Columns[5].Width = 130;
            dtAlacakListesi.Columns[6].Width = 140;

            cmbAlacakTuru.Text = "Alacak Türü Seçin";
            cmbAlacakTuru.Tag = null;
            txtAciklama.Clear();
            txtTutar.Clear();
            dtOdemeTarihi.Value = DateTime.Now;
            txtTutar.Focus();
            txtKimden.Clear();
        }
        private void Alacak_Load(object sender, EventArgs e)
        {
            var gelirTuruSonuc = Veritabani.GelirTuruListele();

            cmbAlacakTuru.Items.Clear();
            while (gelirTuruSonuc.Read())
            {
                cmbAlacakTuru.Items.Add(gelirTuruSonuc["GelirTuru"]);
            }

            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbAlacakTuru.Text != "Alacak Türü Seçin" && txtTutar.Text != "")            {


                Veritabani.AlacakEkle(Double.Parse(txtTutar.Text), dtOdemeTarihi.Value.ToString(),DateTime.Now.ToString(), cmbAlacakTuru.SelectedText, txtAciklama.Text,txtKimden.Text);
                Temizle();
            }
            else
            {
                MessageBox.Show("Alacak Türü ve Tutar boş olamaz !!!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbAlacakTuru.Tag == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin!!!");
            }
            else
            {
                if (cmbAlacakTuru.Text != "Alacak Türü Seçin" && txtTutar.Text != "")
                {                  
                    Veritabani.AlacakGuncelle(Double.Parse(txtTutar.Text), dtOdemeTarihi.Value.ToString(), DateTime.Now.ToString(), cmbAlacakTuru.SelectedText, txtAciklama.Text,txtKimden.Text,Int32.Parse(cmbAlacakTuru.Tag.ToString()));
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Alacak Türü ve Tutar boş olamaz !!!");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbAlacakTuru.Tag == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin!!!");
            }
            else
            {
                Veritabani.AlacakSil(Int32.Parse((string)cmbAlacakTuru.Tag));
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dtGelirListesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbAlacakTuru.Tag = dtAlacakListesi.CurrentRow.Cells[0].Value.ToString();
            txtTutar.Text = dtAlacakListesi.CurrentRow.Cells[1].Value.ToString();
            dtOdemeTarihi.Value = DateTime.Parse(dtAlacakListesi.CurrentRow.Cells[2].Value.ToString());         
            cmbAlacakTuru.SelectedText = dtAlacakListesi.CurrentRow.Cells[4].Value.ToString();
            txtAciklama.Text = dtAlacakListesi.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
