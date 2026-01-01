using NodaTime;
using Project2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services
{
    internal class SuTakibi : TakvimOgesi
    {
        public LocalDate tarih;
        public int icilenMl;
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
