using NodaTime;
using Project2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services
{
    internal class Islem : TakvimOgesi
    {
        public string aciklama;
        public double miktar;
        public LocalDate islemTarihi;
        public int tip;//burada garip birşeyler var 

        public Islem(string aciklama, double miktar, LocalDate islemTarihi, int tip)
        {
            this.aciklama = aciklama;
            this.miktar = miktar;
            this.islemTarihi = islemTarihi;
            this.tip = tip;
        }

        public string getBaslik()
        {
            throw new NotImplementedException();
        }

        public string getDetayBilgisi()
        {
            throw new NotImplementedException();
        }

        public LocalDateTime getTarihBaslangic()
        {
            throw new NotImplementedException();
        }
    }
}
