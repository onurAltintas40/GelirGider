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
            var s = Veritabani.GelirTuruListeleDt();
            dataGridView1.DataSource = s;
            dataGridView1.Columns[1].Width = 200;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGelirTuru.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtGelirTuru.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
