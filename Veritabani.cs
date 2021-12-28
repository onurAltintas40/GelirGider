using System.Data;
using System.Data.SQLite;

namespace GelirGider
{
    public class Veritabani
    {
        public static SQLiteConnection con = new SQLiteConnection("Data source = .\\GelirGider.db;Version=3");

        static DataTable dt;
        public static DataTable Listele(string kullaniciAdi, string sifre)
        {
            string sql = "Select * from Kullanici where KullaniciAdi ='"+kullaniciAdi+"' and Sifre ='"+sifre+"'";

            dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, con);
            adtr.Fill(dt);
            return dt;
        }
    }
}
