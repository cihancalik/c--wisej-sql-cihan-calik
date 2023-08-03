using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityLayer;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data.Sql;

namespace DataAccessLayer
{
    public class  Personelİslemler
    {
        public static SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS;initial catalog=NTMSTAJPROJE;integrated security=true;MultipleActiveResultSets=True");


        public static List<Departmanlar> cmbxverigetir()
        {
             
            SqlCommand komut = new SqlCommand("select *from TabloDepartmanlar", baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();
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
        public static List<Personel> Listele()
        {
            SqlCommand komut = new SqlCommand("select *from TabloPersonel", baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();
            List<Personel> personeller = new List<Personel>();

            while (dr.Read())
            {
                Personel ent = new Personel();
                ent.ID = int.Parse(dr[0].ToString());
                ent.Ad = dr[1].ToString();
                ent.Soyad = dr[2].ToString();
                ent.Mail = dr[3].ToString();
                ent.Telefon = dr[4].ToString();
                ent.Gorsel = dr[5].ToString();
                ent.DepartmanID = int.Parse(dr[6].ToString());

                personeller.Add(ent);
            }
            return personeller;


        }
        public static int Ekle(Personel x)
        {
            SqlCommand komut = new SqlCommand("insert into TabloPersonel (Ad,Soyad,Mail,Telefon,Gorsel,Departman) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }


            komut.Parameters.AddWithValue("@p1", x.Ad);
            komut.Parameters.AddWithValue("@p2", x.Soyad);
            komut.Parameters.AddWithValue("@p3", x.Mail);
            komut.Parameters.AddWithValue("@p4", x.Telefon);
            komut.Parameters.AddWithValue("@p5", x.Gorsel);
            komut.Parameters.AddWithValue("@p6", x.DepartmanID);
            return komut.ExecuteNonQuery();

        }

        public static int Sil(Personel x)
        {
            SqlCommand komut = new SqlCommand("delete from  TabloPersonel where ID=@p1", baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1", x.ID);
            return komut.ExecuteNonQuery();

        }

        public static int Guncelle(Personel x)
        {
            SqlCommand komut = new SqlCommand("update TabloPersonel set Ad=@p1 ,Soyad=@p2,Mail=@p3," +
                "Telefon=@p4,Gorsel=@p5,Departman=@p6 where ID=@p7", baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", x.Ad);
            komut.Parameters.AddWithValue("@p2", x.Soyad);
            komut.Parameters.AddWithValue("@p3", x.Mail);
            komut.Parameters.AddWithValue("@p4", x.Telefon);
            komut.Parameters.AddWithValue("@p5", x.Gorsel);
            komut.Parameters.AddWithValue("@p6", x.DepartmanID);
            komut.Parameters.AddWithValue("@p7", x.ID);
            return komut.ExecuteNonQuery();
        }







    }
}
