using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Personel
    {



        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Gorsel { get; set; }

        public int DepartmanID { get; set; }
    }
}
