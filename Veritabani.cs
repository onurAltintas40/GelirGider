using System.Data;
using System.Data.SQLite;

namespace GelirGider
{
    public class Veritabani
    {
        public static SQLiteConnection con = new SQLiteConnection("Data source = .\\GelirGider.db;Version=3");
       
        public static bool KullaniciGiris(string kullaniciAdi, string sifre)
        {
            if (con.State != ConnectionState.Open) con.Open();

            string sql = "Select * from Kullanici where KullaniciAdi =@KullaniciAdi and Sifre = @Sifre";
            SQLiteParameter prm1 = new SQLiteParameter("KullaniciAdi", kullaniciAdi);
            SQLiteParameter prm2 = new SQLiteParameter("Sifre", sifre);
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            con.Close();
        }


    }
}
