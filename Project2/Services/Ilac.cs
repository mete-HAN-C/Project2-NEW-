using NodaTime;
using Project2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services 
{
    internal class Ilac : TakvimOgesi
    {
        public string ilacAdi;
        public double dozajMg;
        public LocalTime almaZamanii;

        public Ilac(string ilacAdi, double dozajMg, LocalTime almaZamanii)
        {
            this.ilacAdi = ilacAdi;
            this.dozajMg = dozajMg;
            this.almaZamanii = almaZamanii;
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
