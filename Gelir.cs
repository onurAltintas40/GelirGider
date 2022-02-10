using System;
using System.Data;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class Gelir : Form
    {
        public Gelir()
        {
            InitializeComponent();
        }

        DataTable gelirSonuc;
        private void Hesapla()
        {
            int toplam = 0;

            for (int i = 0; i < dtGelirListesi.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dtGelirListesi.Rows[i].Cells[1].Value);
            }
            txtTutarToplam.Text = toplam.ToString();
        }
        private void Gelir_Load(object sender, System.EventArgs e)
        {
            var gelirTuruSonuc = Veritabani.GelirTuruListele();

            cmbGelirTuru.Items.Clear();
            cmbGelirTuruAra.Items.Clear();
            while (gelirTuruSonuc.Read())
            {
                cmbGelirTuru.Items.Add(gelirTuruSonuc["GelirTuru"]);
                cmbGelirTuruAra.Items.Add(gelirTuruSonuc["GelirTuru"]);
            }

            Temizle();           
        }
        void Temizle()
        {
            gelirSonuc = Veritabani.GelirListele();
            dtGelirListesi.DataSource = gelirSonuc;
            dtGelirListesi.Columns[0].Width = 55;
            dtGelirListesi.Columns[1].Width = 165;
            dtGelirListesi.Columns[2].Width = 165;
            dtGelirListesi.Columns[3].Width = 225;
            dtGelirListesi.Columns[4].Width = 165;           

            cmbGelirTuru.Text = "Gelir Türü Seçin";
            cmbGelirTuru.Tag = null;
            txtAciklama.Clear();
            txtTutar.Clear();
            chkOdemeAlindi.Checked = false;
            txtTutar.Focus();
            Hesapla();
        }
        private void btnEkle_Click(object sender, System.EventArgs e)
        {
            if (cmbGelirTuru.Text != "Gelir Türü Seçin" && txtTutar.Text != "")
            { 
                if (chkOdemeAlindi.Checked == false)
                {
                    Alacak alacak = new Alacak();
                    alacak.a = 1;
                    alacak.cmbAlacakTuru.Text = cmbGelirTuru.Text;
                    alacak.txtTutar.Text = txtTutar.Text;
                    alacak.txtAciklama.Text = txtAciklama.Text;
                    alacak.ShowDialog();
                }
                else
                {
                    Veritabani.GelirEkle(Double.Parse(txtTutar.Text), DateTime.Now.ToString(), txtAciklama.Text, cmbGelirTuru.Text);
                }
                Temizle();
            }
            else
            {
                MessageBox.Show("Gelir Türü ve Tutar boş olamaz !!!");
            }

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbGelirTuru.Tag == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin!!!");
            }
            else
            {
                if (cmbGelirTuru.Text != "Gelir Türü Seçin" && txtTutar.Text != "")
                {
                    int odeme = chkOdemeAlindi.Checked == true ? 1 : 0;
                    Veritabani.GelirGuncelle(Double.Parse(txtTutar.Text), DateTime.Now.ToString(), txtAciklama.Text, cmbGelirTuru.Text, Int32.Parse((string)cmbGelirTuru.Tag));
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Gelir Türü ve Tutar boş olamaz !!!");
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbGelirTuru.Tag == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin!!!");
            }
            else
            {
                Veritabani.GelirSil(Int32.Parse((string)cmbGelirTuru.Tag));
                Temizle();
            }
        }
        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void dtGelirListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbGelirTuru.Tag = dtGelirListesi.CurrentRow.Cells[0].Value.ToString();
            txtTutar.Text = dtGelirListesi.CurrentRow.Cells[1].Value.ToString();
            txtAciklama.Text = dtGelirListesi.CurrentRow.Cells[3].Value.ToString();
            cmbGelirTuru.Text = "";
            cmbGelirTuru.SelectedText = dtGelirListesi.CurrentRow.Cells[4].Value.ToString();  
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void btnTarihAra_Click(object sender, EventArgs e)
        {
            var sonuc = Veritabani.GelirTarihFiltre(dtBaslangic.Value.ToString(),dtBitis.Value.ToString());
            dtGelirListesi.DataSource = sonuc;

            Hesapla();
        }       
        private void cmbGelirTuruAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = gelirSonuc.DefaultView;
            dv.RowFilter = "GelirTuru LIKE '" + cmbGelirTuruAra.Text + "%'";
            dtGelirListesi.DataSource = dv;

            Hesapla();
        }
    }
}
