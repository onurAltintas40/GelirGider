using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GelirGider
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
            Init_Data();
        }
        
        void KullaniciKontrol()
        {
           bool sonuc = Veritabani.KullaniciGiris(txtKullaniciAdi.Text, txtSifre.Text);

            if(sonuc)
            {
                AnaMenu ana = new AnaMenu();
                ana.Show();
                Hide();              
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
                txtKullaniciAdi.Clear();
                txtKullaniciAdi.Focus();
                txtSifre.Clear();
            }
        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.KullaniciAdi != string.Empty)
            {
                if (Properties.Settings.Default.BeniHatirla == true)
                {
                    txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                    txtSifre.Text = Properties.Settings.Default.Sifre;
                    chkBeniHatirla.Checked = true;
                }
                else
                {
                    txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                }
            }
        }
        private void Save_Data()
        {
            if (chkBeniHatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text.Trim();
                Properties.Settings.Default.Sifre = txtSifre.Text.Trim();
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = "";
                Properties.Settings.Default.Sifre = "";
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
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
        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullaniciKontrol();
            Save_Data();
        }
    }
}
