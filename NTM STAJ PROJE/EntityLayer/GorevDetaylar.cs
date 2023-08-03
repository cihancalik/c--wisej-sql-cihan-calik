using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class GorevDetaylari
    {
        public int ID { get; set; }
        public  Gorevler Gorev { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public string Saat { get; set; }

    }
}
