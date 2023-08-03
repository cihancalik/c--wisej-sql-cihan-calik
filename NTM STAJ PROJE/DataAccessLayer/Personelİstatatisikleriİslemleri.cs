using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Personelİstatatisikleriİslemleri
    {
        public static SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS;initial catalog=NTMSTAJPROJE;integrated security=true;MultipleActiveResultSets=True");

        public static int ToplamPersonel()
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(ID) FROM TabloPersonel", baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            int count = (int)komut.ExecuteScalar();
            return count;
        }

        public static int ToplamDepartman()
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(ID) FROM TabloDepartmanlar", baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            int count = (int)komut.ExecuteScalar();
            return count;
        }
    }
}
