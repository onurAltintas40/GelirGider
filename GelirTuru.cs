using System;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class GelirTuru : Form
    {
        public GelirTuru()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            txtGelirTuru.Clear();
            txtGelirTuru.Focus();
            var sonuc = Veritabani.GelirTuruListele();
            dtGelirTuru.DataSource = sonuc;
        }
        private void GelirTuru_Load(object sender, EventArgs e)
        {
            Temizle();
        }       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtGelirTuru.Text == "")
            {
                MessageBox.Show("Gelir Türü boş geçilemez !!!");
            }
            else
            {
                Veritabani.GelirTuruEkle(txtGelirTuru.Text);
                Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtGelirTuru.Tag == "")
            {
                MessageBox.Show("Lütfen bir kayıt seçin !!!");
            }
            else
            {
                if (txtGelirTuru.Text == "")
                {
                    MessageBox.Show("Gelir Türü boş geçilemez !!!");
                }
                else
                {
                    Veritabani.GelirTuruGuncelle(txtGelirTuru.Text, Int32.Parse(txtGelirTuru.Tag.ToString()));
                    Temizle();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtGelirTuru.Tag == "")
            {
                MessageBox.Show("Lütfen bir kayıt seçin !!!");
            }
            else
            {
                Veritabani.GelirTuruSil(Int32.Parse(txtGelirTuru.Tag.ToString()));
                Temizle();
            }
        }

        private void dtGelirTuru_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtGelirTuru.Tag = dtGelirTuru.CurrentRow.Cells[0].Value.ToString();
            txtGelirTuru.Text = dtGelirTuru.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
