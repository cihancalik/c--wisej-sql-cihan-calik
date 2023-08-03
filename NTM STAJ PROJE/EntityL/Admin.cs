using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class Admin


    {
        public int ID { get; set; }
        public string Kullanici { get;set; }

        public Admin admin(int _ID, string _Kullanici)
        {
            _ID=ID;
           Kullanici=Kullanici;
        }






    }
}
