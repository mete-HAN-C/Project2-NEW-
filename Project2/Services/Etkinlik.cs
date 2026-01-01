using NodaTime;
using Project2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services
{
    internal class Etkinlik : TakvimOgesi
    {
        public string baslik;
        public string aciklama;
        public LocalDateTime baslangicZamani;
        public LocalDateTime bitisZamani;

        public Etkinlik(string baslik, string aciklama, LocalDateTime baslangicZamani, LocalDateTime bitisZamani)
        {
            this.baslik = baslik;
            this.aciklama = aciklama;
            this.baslangicZamani = baslangicZamani;
            this.bitisZamani = bitisZamani;
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
