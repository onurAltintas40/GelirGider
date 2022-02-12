using System;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class GiderTuru : Form
    {
        public GiderTuru()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            txtGiderTuru.Clear();
            txtGiderTuru.Focus();
            dtGiderTuru.DataSource = Veritabani.GiderTuruListeleDt();
            dtGiderTuru.Columns[1].Width = 200;
            dtGiderTuru.ClearSelection();
        }
        private void GiderTuru_Load(object sender, EventArgs e)
        {
            Temizle();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtGiderTuru.Text == "")
            {
                MessageBox.Show("Gider Türü boş geçilemez !!!");
            }
            else
            {
                Veritabani.GiderTuruEkle(txtGiderTuru.Text);
                Temizle();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtGiderTuru.Tag == "")
            {
                MessageBox.Show("Lütfen bir kayıt seçin !!!");
            }
            else
            {
                if (txtGiderTuru.Text == "")
                {
                    MessageBox.Show("Gider Türü boş geçilemez !!!");
                }
                else
                {
                    Veritabani.GiderTuruGuncelle(txtGiderTuru.Text, Int32.Parse(txtGiderTuru.Tag.ToString()));
                    Temizle();
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtGiderTuru.Tag == "")
            {
                MessageBox.Show("Lütfen bir kayıt seçin !!!");
            }
            else
            {
                Veritabani.GiderTuruSil(Int32.Parse(txtGiderTuru.Tag.ToString()));
                Temizle();
            }
        }
        private void dtGiderTuru_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtGiderTuru.Tag = dtGiderTuru.CurrentRow.Cells[0].Value.ToString();
            txtGiderTuru.Text = dtGiderTuru.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
