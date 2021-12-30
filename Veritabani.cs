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

        public static DataTable GelirListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from Gelir";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public static SQLiteDataReader GelirTuruListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from GelirTuru";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
        }

        public static DataTable GiderListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from Gider";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public static SQLiteDataReader GiderTuruListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from GiderTuru";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
        }

        public static DataTable AlacakListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from Alacak";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public static DataTable BorcListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from Borc";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }


    }
}
