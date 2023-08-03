using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
     public class Gorevler
    {
        public int ID { get; set; }
        public Personel GorevVeren { get; set; }
        public Personel GorevAlan { get; set; }

        public string Aciklama { get; set; }
        public string Durum { get; set; }
        public DateTime Tarih { get; set; }
    }
}
