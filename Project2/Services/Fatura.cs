using NodaTime;
using Project2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services
{
    internal class Fatura : TakvimOgesi
    {
        public string kurumAdi;
        public double tutar;
        public LocalDate sonOdomeTarihi;

        public Fatura(string kurumAdi, double tutar, LocalDate sonOdomeTarihi)
        {
            this.kurumAdi = kurumAdi;
            this.tutar = tutar;
            this.sonOdomeTarihi = sonOdomeTarihi;
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
