using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class Alacak : Form
    {
        public Alacak()
        {
            InitializeComponent();
        }

        public int a = 0;

        DataTable alacakSonuc;

        void Listele()
        {
            alacakSonuc = Veritabani.AlacakListele();
            dtAlacakListesi.DataSource = alacakSonuc;
            dtAlacakListesi.Columns[0].Width = 50;
            dtAlacakListesi.Columns[1].Width = 155;
            dtAlacakListesi.Columns[2].Width = 155;
            dtAlacakListesi.Columns[3].Width = 155;
            dtAlacakListesi.Columns[4].Width = 155;
            dtAlacakListesi.Columns[5].Width = 160;

            Renk();

            Hesapla();
        }

        void Renk()
        {
            for (int i = 0; i < dtAlacakListesi.RowCount - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if ((DateTime.Parse(dtAlacakListesi.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays <= 2 && (DateTime.Parse(dtAlacakListesi.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays > -1)
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                else if ((DateTime.Parse(dtAlacakListesi.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays <= 5 && (DateTime.Parse(dtAlacakListesi.Rows[i].Cells[3].Value.ToString()).Date - DateTime.Now).TotalDays > -1)
                {
                    renk.BackColor = Color.Yellow;
                }
                dtAlacakListesi.Rows[i].DefaultCellStyle = renk;
            }
        }
        void Temizle()
        {
            cmbAlacakTuru.Text = "Alacak Türü Seçin";
            cmbAlacakTuru.Tag = null;
            txtAciklama.Clear();
            txtTutar.Clear();
            dtOdemeTarihi.Value = DateTime.Now;
            txtTutar.Focus();
            txtKimden.Clear();

            Listele();
            dtAlacakListesi.ClearSelection();
        }

        private void Hesapla()
        {
            int toplam = 0;

            for (int i = 0; i < dtAlacakListesi.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dtAlacakListesi.Rows[i].Cells[2].Value);
            }
            txtTutarToplam.Text = toplam.ToString();
        }
        private void Alacak_Load(object sender, EventArgs e)
        {
            if (a == 0)
            {
                var gelirTuruSonuc = Veritabani.GelirTuruListele();

                cmbAlacakTuru.Items.Clear();
                while (gelirTuruSonuc.Read())
                {
                    cmbAlacakTuru.Items.Add(gelirTuruSonuc["GelirTuru"]);
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
            if (cmbAlacakTuru.Text != "Alacak Türü Seçin" && txtTutar.Text != "")
            {
                Veritabani.AlacakEkle(Double.Parse(txtTutar.Text), dtOdemeTarihi.Value.ToString("yyyy/MM/dd HH:mm:ss"), DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), cmbAlacakTuru.Text, txtAciklama.Text, txtKimden.Text);
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
                    Veritabani.AlacakGuncelle(Convert.ToDouble(txtTutar.Text), dtOdemeTarihi.Value.ToString("yyyy/MM/dd HH:mm:ss"), cmbAlacakTuru.Text, txtAciklama.Text, txtKimden.Text, Convert.ToInt32(cmbAlacakTuru.Tag.ToString()));
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
            txtKimden.Text = dtAlacakListesi.CurrentRow.Cells[1].Value.ToString();
            txtTutar.Text = dtAlacakListesi.CurrentRow.Cells[2].Value.ToString();
            dtOdemeTarihi.Value = DateTime.Parse(dtAlacakListesi.CurrentRow.Cells[3].Value.ToString());
            cmbAlacakTuru.Text = dtAlacakListesi.CurrentRow.Cells[5].Value.ToString();
            txtAciklama.Text = dtAlacakListesi.CurrentRow.Cells[6].Value.ToString();
        }
        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = alacakSonuc.DefaultView;
            dv.RowFilter = "Kimden LIKE '" + txtAdAra.Text + "%'";
            dtAlacakListesi.DataSource = dv;
            Hesapla();
            Renk();
        }
        private void btnOdemeTarihAra_Click(object sender, EventArgs e)
        {
            if (dtBaslangic.Value.AddDays(-1) <= dtBitis.Value)
            {
                var sonuc = Veritabani.AlacakOdemeFiltre(dtBaslangic.Value.AddDays(-1).ToString("yyyy/MM/dd HH:mm:ss"), dtBitis.Value.ToString("yyyy/MM/dd HH:mm:ss"));
                dtAlacakListesi.DataSource = sonuc;

                Hesapla();
                Renk();
            }
            else
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden küçük olamaz !!!");
            }

        }
        private void btnTarihAra_Click(object sender, EventArgs e)
        {
            if (dtBaslangic.Value.AddDays(-1) <= dtBitis.Value)
            {
                var sonuc = Veritabani.AlacakTarihFiltre(dtBaslangic.Value.AddDays(-1).ToString("yyyy/MM/dd HH:mm:ss"), dtBitis.Value.ToString("yyyy/MM/dd HH:mm:ss"));
                dtAlacakListesi.DataSource = sonuc;

                Hesapla();
                Renk();
            }
            else
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden küçük olamaz !!!");
            }
        }

        private void btnAlacakOdendi_Click(object sender, EventArgs e)
        {
            if (cmbAlacakTuru.Tag == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin!!!");
            }
            else
            {
                Veritabani.GelirEkle(Double.Parse(txtTutar.Text), DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), txtAciklama.Text, cmbAlacakTuru.Text);
                Veritabani.AlacakSil(Int32.Parse((string)cmbAlacakTuru.Tag));
                Temizle();

                Gelir g = new Gelir(); 
                g.ShowDialog(); 
            }
        }
    }
}
