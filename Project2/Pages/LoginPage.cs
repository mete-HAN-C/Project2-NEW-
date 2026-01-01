// Kütüphaneler
using Microsoft.Maui.Controls;
using FmgLib.MauiMarkup;
using Project2.Data;
using Project2.WiewModels;

namespace Project2.Pages;

public class LoginPage : ContentPage
{

    private readonly Entry _emailEntry;
    private readonly Entry _passwordEntry;

    public LoginPage()
    {

        BindingContext = new LoginViewModel();

        this.BackgroundColor(Color.FromArgb("#23222E"));

        // ✅ Entry'leri burada oluşturup saklıyoruz
        _emailEntry = CreateBoundEntry(nameof(LoginViewModel.Email), isPassword: false);
        _passwordEntry = CreateBoundEntry(nameof(LoginViewModel.Password), isPassword: true);

        // DİKKAT: Buradaki 'new Button' kodu silindi ve aşağıya taşındı. 👇

        Content = new Grid
        {
            Padding = new Thickness(30, 60),
            Children =
            {
                new VerticalStackLayout
                {
                    Spacing = 20,
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label()
                            .Text("GİRİŞ YAP")
                            .TextColor(Colors.White)
                            .FontSize(32)
                            .FontAttributes(FontAttributes.Bold)
                            .CenterHorizontal()
                            .Margin(new Thickness(0, 0, 0, 30)),

                        // ✅ E-posta alanı
                        CreateInputGroup("E-posta", _emailEntry),

                        // ✅ Şifre alanı
                        CreateInputGroup("Şifre", _passwordEntry),

                        // Şifremi Unuttum
                        new Label()
                            .Text("Şifremi Unuttum")
                            .TextColor(Color.FromArgb("#3F63FF"))
                            .FontSize(13)
                            .HorizontalOptions(LayoutOptions.End)
                            .InputTransparent(false)
                            .GestureRecognizers(new TapGestureRecognizer
                            {
                                Command = new Command(async () =>
                                {
                                    await Navigation.PushAsync(new ForgotPasswordPage());
                                })
                            }),

                        // ✅ DÜZELTME BURADA: Butonu Children listesinin içine taşıdık!
                        new Button()
                            .Text("Giriş Yap")
                            .TextColor(Colors.White)
                            .BackgroundColor(Color.FromArgb("#1A00B0"))
                            .BorderColor(Colors.White)
                            .BorderWidth(1)
                            .HeightRequest(55)
                            .CornerRadius(20)
                            .Margin(new Thickness(0, 25, 0, 0))
                            .Bind(Button.CommandProperty, nameof(LoginViewModel.LoginCommand)),

                        // Kayıt Ol Linki
                        new HorizontalStackLayout
                        {
                            Spacing = 5,
                            HorizontalOptions = LayoutOptions.Center,
                            Margin = new Thickness(0, 40, 0, 0),
                            Children =
                            {
                                new Label()
                                    .Text("Hesabınız yok mu ?")
                                    .TextColor(Colors.White)
                                    .FontSize(14),

                                new Label()
                                    .Text("KAYDOLUN")
                                    .TextColor(Color.FromArgb("#3F63FF"))
                                    .FontSize(14)
                                    .FontAttributes(FontAttributes.Bold)
                                    .GestureRecognizers(new TapGestureRecognizer
                                    {
                                        Command = new Command(async () =>
                                            await Navigation.PushAsync(new RegisterPage()))
                                    })
                            }
                        }
                    }
                }
            }
        };
    }

    private Entry CreateBoundEntry(string vmPropertyName, bool isPassword)
    {
        var entry = new Entry()
            .IsPassword(isPassword)
            .TextColor(Colors.White)
            .BackgroundColor(Colors.Transparent)
            .HeightRequest(45);

        entry.SetBinding(Entry.TextProperty, vmPropertyName);

        return entry;
    }

    private View CreateInputGroup(string title, Entry entry)
    {
        return new VerticalStackLayout
        {
            Spacing = 8,
            Children =
            {
                new Label()
                    .Text(title)
                    .TextColor(Colors.White)
                    .FontSize(14),

                new Border()
                    .Stroke(Colors.White)
                    .StrokeThickness(1)
                    .BackgroundColor(Colors.Transparent)
                    .Padding(new Thickness(10, 2))
                    .Content(entry)
            }
        };
    }
}