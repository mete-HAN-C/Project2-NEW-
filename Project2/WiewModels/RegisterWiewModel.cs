using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using Project2.Services;


namespace Project2.WiewModels;


public partial class RegisterWiewModel : ObservableObject
{
    [ObservableProperty]
    private string name = "";
    [ObservableProperty]
    private string surname = "";
    [ObservableProperty]
    private string email = "";
    [ObservableProperty]
    private string password = "";
    [ObservableProperty]
    private string passwordAgain = "";
    [ObservableProperty]
    private bool agreed;

    [RelayCommand]
    private async Task Register()
    {
        
        if (Password != PasswordAgain)
        {
            if (Microsoft.Maui.Controls.Application.Current?.MainPage != null)
                await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Hata", "Şifreler eşleşmiyor.", "Tamam");
            return;
        }

        
        var newUser = new Models.Person
        {
            Name = Name?.Trim() ?? "", 
            Surname = Surname?.Trim() ?? "",
            Email = Email?.Trim() ?? "",
            Password = Password,
           
            Age = 0,//25 di
            Gender = 2//1 di
        };

        try
        {
            PersonValidator.Validate(newUser);
            

            // C. Başarılı Mesajı ve Yönlendirme
            if (Microsoft.Maui.Controls.Application.Current?.MainPage != null)
            {
                if (Agreed == true)
                {
                    await App.Database.AddPersonAsync(newUser);
                    UserSeassion.CurrentUser = newUser;
                    await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Başarılı", "Kayıt başarılı! Profil oluşturmaya yönlendiriliyorsunuz.", "Tamam");

                    // CreateProfilePage sayfasına git
                    await Microsoft.Maui.Controls.Application.Current.MainPage.Navigation.PushAsync(new CreateProfilePage());
                }
                else if (Agreed == false)
                {
                    await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Uyarı", "Lütfen bilgileri doğruladığınızı onaylayın.", "Tamam");
                }
            }
        }
        catch (ArgumentException ex)
        {
            // D. VALIDATOR HATASI YAKALAMA 🥅
            // Örneğin: "Şifre en az 1 büyük harf içermeli" hatası burada yakalanır.
            if (Microsoft.Maui.Controls.Application.Current?.MainPage != null)
                await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Uyarı", ex.Message, "Tamam");
        }
        catch (Exception ex)
        {
            // E. GENEL HATA (Veritabanı hatası vs.)
            if (Microsoft.Maui.Controls.Application.Current?.MainPage != null)
                await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Hata", "Bir sorun oluştu: " + ex.Message, "Tamam");
        }
    }
}