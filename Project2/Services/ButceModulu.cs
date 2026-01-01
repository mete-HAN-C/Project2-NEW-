using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services
{
    internal class ButceModulu
    {
        public double aylikSinir;
        public double toplamGelir;
        public double toplamGider;

        public ButceModulu(double aylikSinir, double toplamGelir, double toplamGider)
        {
            this.aylikSinir = aylikSinir;
            this.toplamGelir = toplamGelir;
            this.toplamGider = toplamGider;
        }

        public void islemEkle(Islem islem)
        {

        }

        public double bakiyeHesapla(Fatura fatura)
        {
            return 0.0;
        }
    }
}
