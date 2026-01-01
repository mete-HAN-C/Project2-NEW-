using Microsoft.Extensions.Logging;
using Project2.Data;
using Project2.Pages;

namespace Project2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Logging.AddDebug();

            // ✅ DB dosya yolu (her platformda doğru yer)
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "app.db");

            builder.Services
                // ✅ App + sayfalar
                .AddSingleton<App>()
                .AddSingleton<AppShell>()
                .AddScoped<LoginPage>()
                .AddScoped<RegisterPage>() // varsa ekle

                // ✅ Database
                .AddSingleton(new AppDatabase(dbPath));

            return builder.Build();
        }
    }
}
