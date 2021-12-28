using System;
using System.Data;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        
        void KullaniciKontrol()
        {
            DataTable dt = Veritabani.Listele(txtKullaniciAdi.Text, txtSifre.Text);

            if (dt is null) MessageBox.Show("Kullanıcı bulunamadı");
            else
            {
                AnaMenu ana = new AnaMenu();
                ana.ShowDialog();
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KullaniciGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
