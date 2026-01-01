using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Project2.Data;
using Project2.Models;
using Microsoft.Maui.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Project2.WiewModels;
partial class ForgotPasswordPageWiewModel : ObservableObject
{
    [ObservableProperty]
    private string email = " ";
    [RelayCommand]
    private async Task Find() { 
        if(string.IsNullOrWhiteSpace(Email))
        {
            await Application.Current.MainPage.DisplayAlert("Hata", "Lütfen Eposta adresinizi giriniz.", "Tamam");
            return;
        }

        var user = await App.Database.GetByEmailAsync(Email);
        if(user == null)
        {
            await Application.Current.MainPage.DisplayAlert("Hata", "Böyle bir kullanıcı bulunamadı.", "Tamam");
            return;
        }
        else
        {
            await Application.Current.MainPage.DisplayAlert("Güzel", "Böyle bir kullanıcı var.", "Devam");
            return;
        }
    }

}