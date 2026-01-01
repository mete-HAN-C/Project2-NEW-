using NodaTime;
using Project2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services
{
    internal class MiniTakvim: TakvimOgesi
    {
        private List<TakvimOgesi> takvimListesi = new List<TakvimOgesi>();

        public MiniTakvim(List<TakvimOgesi> takvimListesi)
        {
            this.takvimListesi = takvimListesi;
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

        public void gunlukGoster(LocalDate tarih)
        {
            throw new NotImplementedException();
        }

        public void aylikGoster(int ay,int yil)
        {
            throw new NotImplementedException();
        }
    }
}
