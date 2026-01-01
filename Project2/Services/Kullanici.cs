using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services
{
    internal class Kullanici
    {
        public string email;
        public string sifre;
        public double boyCm;
        public double kiloKg;
        public int yas;
        public string cinsiyet;

        public Kullanici(string email, string sifre, double boyCm, double kiloKg, int yas, string cinsiyet)
        {
            this.email = email;
            this.sifre = sifre;
            this.boyCm = boyCm;
            this.kiloKg = kiloKg;
            this.yas = yas;
            this.cinsiyet = cinsiyet;
        }

        public bool girisYap()
        { 
            return true;  
        }

        public bool kayitOl() 
        { 
            return true;  
        }

        public void profilGuncelle()
        {

        }
    }
}
