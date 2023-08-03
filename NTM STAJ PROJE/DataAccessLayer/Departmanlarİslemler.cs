using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class Departmanlarİslemler
    {
        public static SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS;initial catalog=NTMSTAJPROJE;integrated security=true;MultipleActiveResultSets=True");
        public static List<Departmanlar> Listele()
        {
            SqlCommand komut = new SqlCommand("select *from TabloDepartmanlar", baglanti);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            
            SqlDataReader dr=komut.ExecuteReader();
            List<Departmanlar> departmanlar = new List<Departmanlar>();

            while (dr.Read())
            {
                Departmanlar ent = new Departmanlar();
                ent.ID = int.Parse(dr[0].ToString());
                ent.Ad = dr[1].ToString();

                departmanlar.Add(ent);
            }
            return departmanlar;


        }

        public static int Ekle(Departmanlar x)
        {
            SqlCommand komut = new SqlCommand("insert into TabloDepartmanlar (Ad) values (@p1)",baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            
            komut.Parameters.AddWithValue("@p1", x.Ad);
            return komut.ExecuteNonQuery(); 

        }

        public static int Sil(Departmanlar x)
        {
            SqlCommand komut = new SqlCommand("delete from  TabloDepartmanlar where ID=@p1", baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1", x.ID);
            return komut.ExecuteNonQuery();

        }
        public static int Guncelle(Departmanlar x)
        {
            SqlCommand komut = new SqlCommand("update TabloDepartmanlar set Ad=@p1 where ID=@p2",baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", x.Ad);
            komut.Parameters.AddWithValue("@p2", x.ID);
            return komut.ExecuteNonQuery();
        }
    }
}
