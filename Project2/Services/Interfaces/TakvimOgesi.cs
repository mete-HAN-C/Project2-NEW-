
using NodaTime;

namespace Project2.Services.Interfaces
{
    internal interface TakvimOgesi
    {
        public LocalDateTime getTarihBaslangic();
        public string getBaslik();
        public string getDetayBilgisi();
    }
}
