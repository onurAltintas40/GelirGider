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
        public static SQLiteDataReader KullaniciGetir()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from Kullanici";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
        }
        public static int KullaniciGuncelle(string kullaniciAdi, string sifre,string ePosta)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "UPDATE Kullanici set KullaniciAdi=@KullaniciAdi, Sifre=@Sifre,EPosta=@EPosta";

            SQLiteParameter prm1 = new SQLiteParameter("KullaniciAdi", kullaniciAdi);
            SQLiteParameter prm2 = new SQLiteParameter("Sifre", sifre);
            SQLiteParameter prm3 = new SQLiteParameter("EPosta", ePosta);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static DataTable GelirListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from Gelir Order By Tarih Desc";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        public static SQLiteDataReader GelirTuruListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from GelirTuru Order By GelirTuru";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
        }
        public static DataTable GelirTuruListeleDt()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from GelirTuru Order By GelirTuru";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static DataTable GiderListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from Gider Order By Tarih Desc";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        public static SQLiteDataReader GiderTuruListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from GiderTuru Order By GiderTuru";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
        }
        public static DataTable GiderTuruListeleDt()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from GiderTuru Order By GiderTuru";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static DataTable AlacakListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from Alacak Order By OdemeTarih Desc";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        public static DataTable BorcListele()
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "Select * from Borc Order By OdemeTarih Desc";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        public static int GelirEkle(double tutar, string tarih, string aciklama, string gelirTuru, int odendi)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "INSERT INTO Gelir(Tutar, Tarih, Aciklama, GelirTuru, Odendi)  VALUES(@Tutar, @Tarih, @Aciklama, @GelirTuru, @Odendi)";

            SQLiteParameter prm1 = new SQLiteParameter("Tutar", tutar);
            SQLiteParameter prm2 = new SQLiteParameter("Tarih", tarih);
            SQLiteParameter prm3 = new SQLiteParameter("Aciklama", aciklama);
            SQLiteParameter prm4 = new SQLiteParameter("GelirTuru", gelirTuru);
            SQLiteParameter prm5 = new SQLiteParameter("Odendi", odendi);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            cmd.Parameters.Add(prm5);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static int GelirGuncelle(double tutar, string tarih, string aciklama, string gelirTuru, int odendi, int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "UPDATE Gelir set Tutar=@Tutar, Tarih=@Tarih, Aciklama=@Aciklama, GelirTuru=@GelirTuru, Odendi=@Odendi where Id=@id";

            SQLiteParameter prm1 = new SQLiteParameter("Tutar", tutar);
            SQLiteParameter prm2 = new SQLiteParameter("Tarih", tarih);
            SQLiteParameter prm3 = new SQLiteParameter("Aciklama", aciklama);
            SQLiteParameter prm4 = new SQLiteParameter("GelirTuru", gelirTuru);
            SQLiteParameter prm5 = new SQLiteParameter("Odendi", odendi);
            SQLiteParameter prm6 = new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            cmd.Parameters.Add(prm5);
            cmd.Parameters.Add(prm6);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static int GelirSil(int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "DELETE from Gelir where Id=@id";
                        
            SQLiteParameter prm1 = new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);            

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static int GelirTuruEkle(string gelirTuru)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "INSERT INTO GelirTuru(GelirTuru)  VALUES(@GelirTuru)";

            SQLiteParameter prm1 = new SQLiteParameter("GelirTuru", gelirTuru);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();

            return sonuc;
        }
        public static int GelirTuruGuncelle(string gelirTuru,int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "UPDATE GelirTuru set GelirTuru=@GelirTuru where Id=@id";

            SQLiteParameter prm1 = new SQLiteParameter("GelirTuru", gelirTuru);
            SQLiteParameter prm2 = new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();

            return sonuc;
        }
        public static int GelirTuruSil(int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "DELETE from GelirTuru where Id=@id";
            
            SQLiteParameter prm1 = new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);          

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();

            return sonuc;
        }
        public static int GiderEkle(double tutar, string tarih, string aciklama, string giderTuru, int odendi)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "INSERT INTO Gider(Tutar, Tarih, Aciklama, GiderTuru, Odendi)  VALUES(@Tutar, @Tarih, @Aciklama, @GiderTuru, @Odendi)";

            SQLiteParameter prm1 = new SQLiteParameter("Tutar", tutar);
            SQLiteParameter prm2 = new SQLiteParameter("Tarih", tarih);
            SQLiteParameter prm3 = new SQLiteParameter("Aciklama", aciklama);
            SQLiteParameter prm4 = new SQLiteParameter("GiderTuru", giderTuru);
            SQLiteParameter prm5 = new SQLiteParameter("Odendi", odendi);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            cmd.Parameters.Add(prm5);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static int GiderGuncelle(double tutar, string tarih, string aciklama, string giderTuru, int odendi,int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "UPDATE Gider set Tutar=@Tutar, Tarih=@Tarih, Aciklama=@Aciklama, GiderTuru=@GiderTuru, Odendi=@Odendi where = Id=@id";

            SQLiteParameter prm1 = new SQLiteParameter("Tutar", tutar);
            SQLiteParameter prm2 = new SQLiteParameter("Tarih", tarih);
            SQLiteParameter prm3 = new SQLiteParameter("Aciklama", aciklama);
            SQLiteParameter prm4 = new SQLiteParameter("GiderTuru", giderTuru);
            SQLiteParameter prm5 = new SQLiteParameter("Odendi", odendi);
            SQLiteParameter prm6 = new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            cmd.Parameters.Add(prm5);
            cmd.Parameters.Add(prm6);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static int GiderSil(int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "DELETE from Gider where Id=@id";
                       
            SQLiteParameter prm1 = new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);            

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static int GiderTuruEkle(string giderTuru)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "INSERT INTO GiderTuru(GiderTuru)  VALUES(@GiderTuru)";

            SQLiteParameter prm1 = new SQLiteParameter("GiderTuru", giderTuru);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();

            return sonuc;
        }
        public static int GiderTuruGuncelle(string giderTuru,int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "UPDATE GiderTuru set GiderTuru=@GiderTuru where Id=@id";

            SQLiteParameter prm1 = new SQLiteParameter("GiderTuru", giderTuru);
            SQLiteParameter prm2 = new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();

            return sonuc;
        }
        public static int GiderTuruSil(int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "DELETE from GiderTuru where Id=@id";
                       
            SQLiteParameter prm1= new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);           

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();

            return sonuc;
        }
        public static int AlacakEkle(double tutar, string odemeTarih, string tarih, string alacakTuru, string aciklama,string kimden)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "INSERT INTO Alacak(Tutar, Tarih, OdemeTarih, AlacakTuru,Kimden, Aciklama)  VALUES(@Tutar, @Tarih, @OdemeTarih, @AlacakTuru,@Kimden, @Aciklama)";

            SQLiteParameter prm1 = new SQLiteParameter("Tutar", tutar);
            SQLiteParameter prm2 = new SQLiteParameter("Tarih", tarih);
            SQLiteParameter prm3 = new SQLiteParameter("OdemeTarih", odemeTarih);
            SQLiteParameter prm4 = new SQLiteParameter("AlacakTuru", alacakTuru);
            SQLiteParameter prm5 = new SQLiteParameter("Kimden", kimden);
            SQLiteParameter prm6 = new SQLiteParameter("Aciklama", aciklama);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            cmd.Parameters.Add(prm5);
            cmd.Parameters.Add(prm6);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static int AlacakGuncelle(double tutar, string odemeTarih, string tarih, string alacakTuru, string aciklama, string kimden, int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "UPDATE Alacak set Tutar=@Tutar, Tarih= @Tarih, OdemeTarih=@OdemeTarih, AlacakTuru=@AlacakTuru,Kimden=@Kimden, Aciklama= @Aciklama where Id = @id";

            SQLiteParameter prm1 = new SQLiteParameter("Tutar", tutar);
            SQLiteParameter prm2 = new SQLiteParameter("Tarih", tarih);
            SQLiteParameter prm3 = new SQLiteParameter("OdemeTarih", odemeTarih);
            SQLiteParameter prm4 = new SQLiteParameter("AlacakTuru", alacakTuru);
            SQLiteParameter prm5 = new SQLiteParameter("Kimden", kimden);
            SQLiteParameter prm6 = new SQLiteParameter("Aciklama", aciklama);
            SQLiteParameter prm7 = new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            cmd.Parameters.Add(prm5);
            cmd.Parameters.Add(prm6);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static int AlacakSil(int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "DELETE from Alacak where Id = @id";
                       
            SQLiteParameter prm1 = new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);           

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static int BorcEkle(double tutar, string odemeTarih, string tarih, string borcTuru, string aciklama,string kime)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "INSERT INTO Borc(Tutar, Tarih,OdemeTarih, BorcTuru,Kime, Aciklama)  VALUES(@Tutar, @Tarih, @OdemeTarih, @BorcTuru, @Kime,@Aciklama)";

            SQLiteParameter prm1 = new SQLiteParameter("Tutar", tutar);
            SQLiteParameter prm2 = new SQLiteParameter("Tarih", tarih);
            SQLiteParameter prm3 = new SQLiteParameter("OdemeTarih", odemeTarih);
            SQLiteParameter prm4 = new SQLiteParameter("BorcTuru", borcTuru);
            SQLiteParameter prm5 = new SQLiteParameter("Kime", kime);
            SQLiteParameter prm6 = new SQLiteParameter("Aciklama", aciklama);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            cmd.Parameters.Add(prm5);
            cmd.Parameters.Add(prm6);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static int BorcGuncelle(double tutar, string odemeTarih, string tarih, string borcTuru, string aciklama, string kime, int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "UPDATE Borc set Tutar=@Tutar, Tarih=@Tarih, OdemeTarih=@OdemeTarih, BorcTuru=@BorcTuru,Kime=@Kime,Aciklama=@Aciklama where Id=@id";

            SQLiteParameter prm1 = new SQLiteParameter("Tutar", tutar);
            SQLiteParameter prm2 = new SQLiteParameter("Tarih", tarih);
            SQLiteParameter prm3 = new SQLiteParameter("OdemeTarih", odemeTarih);
            SQLiteParameter prm4 = new SQLiteParameter("BorcTuru", borcTuru);
            SQLiteParameter prm5 = new SQLiteParameter("Kime", kime);
            SQLiteParameter prm6 = new SQLiteParameter("Aciklama", aciklama);
            SQLiteParameter prm7 = new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            cmd.Parameters.Add(prm5);
            cmd.Parameters.Add(prm6);
            cmd.Parameters.Add(prm7);

            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }
        public static int BorcSil(int id)
        {
            if (con.State != ConnectionState.Open) con.Open();
            string sql = "DELETE from Borc where Id=@id";
                       
            SQLiteParameter prm1 = new SQLiteParameter("Id", id);

            SQLiteCommand cmd = new(sql, con);

            cmd.Parameters.Add(prm1);
           
            var sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;
        }


    }
}
