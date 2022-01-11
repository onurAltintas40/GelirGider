using System;
using System.Data;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class Gider : Form
    {
        public Gider()
        {
            InitializeComponent();
        }

        DataTable borcSonuc;
        private void Hesapla()
        {
            int toplam = 0;

            for (int i = 0; i < dtGiderListesi.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dtGiderListesi.Rows[i].Cells[1].Value);
            }
            txtTutarToplam.Text = toplam.ToString();
        }
        void Temizle()
        {
            var giderSonuc = Veritabani.GiderListele();
            dtGiderListesi.DataSource = giderSonuc;

            dtGiderListesi.Columns[0].Width = 55;
            dtGiderListesi.Columns[1].Width = 160;
            dtGiderListesi.Columns[2].Width = 160;
            dtGiderListesi.Columns[3].Width = 175;
            dtGiderListesi.Columns[4].Width = 160;
            dtGiderListesi.Columns[5].Width = 160;

            cmbGiderTuru.Text = "Gider Türü Seçin";
            cmbGiderTuru.Tag = null;
            txtAciklama.Clear();
            txtTutar.Clear();
            chkOdemeAlindi.Checked = false;
            txtTutar.Focus();
        }

        private void Gider_Load(object sender, System.EventArgs e)
        {
            var giderTuruSonuc = Veritabani.GiderTuruListele();

            cmbGiderTuru.Items.Clear();
            while (giderTuruSonuc.Read())
            {
                cmbGiderTuru.Items.Add(giderTuruSonuc["GiderTuru"]);
            }
            Temizle();
            Hesapla();
        }

        private void btnEkle_Click(object sender, System.EventArgs e)
        {
            if (cmbGiderTuru.Text != "Gider Türü Seçin" && txtTutar.Text != "")
            {
                int odeme = chkOdemeAlindi.Checked == true ? 1 : 0;

                Veritabani.GiderEkle(Double.Parse(txtTutar.Text), DateTime.Now.ToString(), txtAciklama.Text, cmbGiderTuru.Text, odeme);
                if (chkOdemeAlindi.Checked == false)
                {
                    Borc borc = new Borc();
                    borc.a = 1;
                    borc.cmbBorcTuru.Text = cmbGiderTuru.Text;
                    borc.txtTutar.Text = txtTutar.Text;
                    borc.txtAciklama.Text = txtAciklama.Text;
                    borc.ShowDialog();
                }
                Temizle();
            }
            else
            {
                MessageBox.Show("Gider Türü ve Tutar boş olamaz !!!");
            }
        }

        private void btnGuncelle_Click(object sender, System.EventArgs e)
        {
            if (cmbGiderTuru.Tag == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin!!!");
            }
            else
            {
                if (cmbGiderTuru.Text != "Gider Türü Seçin" && txtTutar.Text != "")
                {
                    int odeme = chkOdemeAlindi.Checked == true ? 1 : 0;
                    Veritabani.GiderGuncelle(Double.Parse(txtTutar.Text), DateTime.Now.ToString(), txtAciklama.Text, cmbGiderTuru.Text, odeme, Int32.Parse((string)cmbGiderTuru.Tag));
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Gider Türü ve Tutar boş olamaz !!!");
                }
            }
        }

        private void btnSil_Click(object sender, System.EventArgs e)
        {
            if (cmbGiderTuru.Tag == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin!!!");
            }
            else
            {
                Veritabani.GiderSil(Int32.Parse((string)cmbGiderTuru.Tag));
                Temizle();
            }
        }

        private void dtGiderListesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbGiderTuru.Tag = dtGiderListesi.CurrentRow.Cells[0].Value.ToString();
            txtTutar.Text = dtGiderListesi.CurrentRow.Cells[1].Value.ToString();
            txtAciklama.Text = dtGiderListesi.CurrentRow.Cells[3].Value.ToString();
            cmbGiderTuru.Text = "";
            cmbGiderTuru.SelectedText = dtGiderListesi.CurrentRow.Cells[4].Value.ToString();
            chkOdemeAlindi.Checked = Int32.Parse(dtGiderListesi.CurrentRow.Cells[5].Value.ToString()) == 1 ? true : false;
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnTarihAra_Click(object sender, EventArgs e)
        {
            var sonuc = Veritabani.GiderTarihFiltre(dtBaslangic.Value.ToString(), dtBitis.Value.ToString());
            dtGiderListesi.DataSource = sonuc;

            Hesapla();
        }

        private void txtisimAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = borcSonuc.DefaultView;
            dv.RowFilter = "GelirTuru LIKE '" + txtisimAra.Text + "%'";
            dtGiderListesi.DataSource = dv;

            Hesapla();
        }
    }
}
