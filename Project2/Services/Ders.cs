using NodaTime;
using Project2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services
{
    internal class Ders : TakvimOgesi
    {
        public string dersKodu;
        public string derslik;
        public LocalTime baslangicSaati;
        public LocalTime bitisSaati;

        public Ders(string dersKodu, string derslik, LocalTime baslangicSaati, LocalTime bitisSaati)
        {
            this.dersKodu = dersKodu;
            this.derslik = derslik;
            this.baslangicSaati = baslangicSaati;
            this.bitisSaati = bitisSaati;
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
