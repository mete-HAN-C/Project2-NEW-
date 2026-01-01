using Microsoft.Maui.Controls;
using Project2;
using Project2.Data;
using Project2.Pages;

namespace Project2
{
    public class App : Application
    {
        // Veritabanı örneğini hafızada tutacak gizli değişken
        static AppDatabase _database;

        // Uygulamanın her yerinden erişilecek 'Musluk' (Singleton Yapısı)
        public static AppDatabase Database
        {
            get
            {
                // Eğer veritabanı henüz oluşturulmadıysa...
                if (_database == null)
                {
                    // Telefonun güvenli klasöründe bir dosya yolu belirle
                    string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Project2.db3");

                    // Veritabanını oluştur ve değişkene ata
                    _database = new AppDatabase(dbPath);
                }
                // Hazır olan veritabanını döndür
                return _database;
            }
        }
        public App()
        {
            // Resource tanımlarını burada yapabilirsin.
            Resources = new ResourceDictionary();
            Resources.MergedDictionaries.Add(AppStyles.Default);
        }

        // Pencere oluşturma işlemi
        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Sayfayı ve NavigationPage'i tam olarak pencere istendiğinde oluşturuyoruz.
            var navigationPage = new NavigationPage(new LoginPage());

            return new Window(navigationPage);
        }
    }
}