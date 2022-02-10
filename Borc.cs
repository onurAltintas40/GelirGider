using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class Borc : Form
    {
        public Borc()
        {
            InitializeComponent();
        }

        DataTable borcSonuc;
        public int a = 0;

        void Listele()
        {
            borcSonuc = Veritabani.BorcListele();
            dtBorcListesi.DataSource = borcSonuc;
            dtBorcListesi.Columns[0].Width = 50;
            dtBorcListesi.Columns[1].Width = 155;
            dtBorcListesi.Columns[2].Width = 155;
            dtBorcListesi.Columns[3].Width = 155;
            dtBorcListesi.Columns[4].Width = 155;
            dtBorcListesi.Columns[5].Width = 160;
            //dtBorcListesi.Columns[6].Width = 160;

            for (int i = 0; i < dtBorcListesi.RowCount - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if ((DateTime.Parse(dtBorcListesi.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays <= 2)
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                else if ((DateTime.Parse(dtBorcListesi.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays <= 5)
                {
                    renk.BackColor = Color.Yellow;
                }
                dtBorcListesi.Rows[i].DefaultCellStyle = renk;
            }

            Hesapla();
        }
        void Temizle()
        {
            cmbBorcTuru.Text = "Borç Türü Seçin";
            cmbBorcTuru.Tag = null;
            txtAciklama.Clear();
            txtTutar.Clear();
            dtOdemeTarihi.Value = DateTime.Now;
            txtTutar.Focus();
            txtisimAra.Clear();
            txtKime.Clear();

            Listele();
        }
        private void Hesapla()
        {
            int toplam = 0;

            for (int i = 0; i < dtBorcListesi.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dtBorcListesi.Rows[i].Cells[2].Value);
            }
            txtTutarToplam.Text = toplam.ToString();
        }
        private void Borc_Load(object sender, EventArgs e)
        {
            if (a==0)
            {
                var giderTuruSonuc = Veritabani.GiderTuruListele();

                cmbBorcTuru.Items.Clear();
                while (giderTuruSonuc.Read())
                {
                    cmbBorcTuru.Items.Add(giderTuruSonuc["GiderTuru"]);
                }

                Temizle();
            }
            else
            {
                Listele();
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbBorcTuru.Text != "Borç Türü Seçin" && txtTutar.Text != "")
            {
                Veritabani.BorcEkle(Double.Parse(txtTutar.Text), dtOdemeTarihi.Value.ToString(), DateTime.Now.ToString(), cmbBorcTuru.Text, txtAciklama.Text,txtKime.Text);
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
                    Veritabani.BorcGuncelle(Double.Parse(txtTutar.Text), dtOdemeTarihi.Value.ToString(),cmbBorcTuru.Text, txtAciklama.Text,txtKime.Text, Int32.Parse(cmbBorcTuru.Tag.ToString()));
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
            txtKime.Text = dtBorcListesi.CurrentRow.Cells[1].Value.ToString();
            txtTutar.Text = dtBorcListesi.CurrentRow.Cells[2].Value.ToString();            
            dtOdemeTarihi.Value = DateTime.Parse(dtBorcListesi.CurrentRow.Cells[4].Value.ToString());
            cmbBorcTuru.Text = dtBorcListesi.CurrentRow.Cells[5].Value.ToString();            
            txtAciklama.Text = dtBorcListesi.CurrentRow.Cells[6].Value.ToString();            
        }            
        private void txtisimAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = borcSonuc.DefaultView;
            dv.RowFilter = "Kime LIKE '" + txtisimAra.Text + "%'";
            dtBorcListesi.DataSource = dv;

            Hesapla();
        }
        private void btnTarihAra_Click(object sender, EventArgs e)
        {
            var sonuc = Veritabani.BorcTarihFiltre(dtBaslangic.Value.ToShortDateString(), dtBitis.Value.AddDays(1).ToShortDateString());
            dtBorcListesi.DataSource = sonuc;

            Hesapla();
        }
        private void btnOdemeTarihAra_Click(object sender, EventArgs e)
        {
            var sonuc = Veritabani.BorcOdemeFiltre(dtBaslangic.Value.ToShortDateString(), dtBitis.Value.AddDays(1).ToShortDateString());
            dtBorcListesi.DataSource = sonuc;

            Hesapla();
        }
    }
}
