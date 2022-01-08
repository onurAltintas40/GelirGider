using System;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class KullaniciDuzenle : Form
    {
        public KullaniciDuzenle()
        {
            InitializeComponent();
        }

        void KullaniciGetir()
        {
            var sonuc = Veritabani.KullaniciGetir();

            while (sonuc.Read())
            {
                txtKullaniciAdi.Text = sonuc["KullaniciAdi"].ToString();
                txtSifre.Text = sonuc["Sifre"].ToString();
                txtEPosta.Text = sonuc["EPosta"].ToString();
            }

            
        }
        private void KullaniciDuzenle_Load(object sender, EventArgs e)
        {
            KullaniciGetir();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text is null & txtSifre.Text is null)
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre kısımlarını doldurun.");
            }
            else
            {
                Veritabani.KullaniciGuncelle(txtKullaniciAdi.Text, txtSifre.Text,txtEPosta.Text);
                txtKullaniciAdi.Clear();
                txtKullaniciAdi.Focus();
                txtEPosta.Clear();
                txtSifre.Clear();
            }
        }
    }
}
