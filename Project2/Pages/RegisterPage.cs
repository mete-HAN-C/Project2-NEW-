using FmgLib.MauiMarkup;
using Microsoft.Maui.Controls;
using Project2.Data;
using Project2.WiewModels;
using Microsoft.Maui.Controls.Shapes;
namespace Project2.Pages;

public class RegisterPage : ContentPage
{
    // 1. Entry'leri burada tanımlıyoruz (Erişilebilir olsunlar diye)
    private readonly Entry _nameEntry;
    private readonly Entry _surnameEntry;
    private readonly Entry _emailEntry;
    private readonly Entry _passwordEntry;
    private readonly Entry _passwordAgainEntry;
    private readonly CheckBox _checkBox;

    public RegisterPage()
    {
        BindingContext = new RegisterWiewModel();
        this.BackgroundColor(Color.FromArgb("#23222E"));

        // 2. Entry'leri Oluştur ve ViewModel'e Bağla (Binding)
        _nameEntry = new Entry().Placeholder("Adınız").TextColor(Colors.White);
        _nameEntry.Bind(Entry.TextProperty, nameof(RegisterWiewModel.Name));

        _surnameEntry = new Entry().Placeholder("Soyadınız").TextColor(Colors.White);
        _surnameEntry.Bind(Entry.TextProperty, nameof(RegisterWiewModel.Surname));

        _emailEntry = new Entry().Placeholder("E-Posta").TextColor(Colors.White);
        _emailEntry.Bind(Entry.TextProperty, nameof(RegisterWiewModel.Email));

        _passwordEntry = new Entry().Placeholder("Şifre").IsPassword(true).TextColor(Colors.White);
        _passwordEntry.Bind(Entry.TextProperty, nameof(RegisterWiewModel.Password));

        _passwordAgainEntry = new Entry().Placeholder("Şifre Tekrar").IsPassword(true).TextColor(Colors.White);
        _passwordAgainEntry.Bind(Entry.TextProperty, nameof(RegisterWiewModel.PasswordAgain));



        _checkBox = new CheckBox().Color(Colors.White);
        // Not: ViewModel'de 'IsAgreed' gibi bir bool varsa buraya bağlayabilirsin.
        _checkBox.Bind(CheckBox.IsCheckedProperty, nameof(RegisterWiewModel.Agreed));

        // 3. Ekran Tasarımı (ScrollView kullandık ki ekran küçükse kaydırılabilsin)
        Content = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(30, 40),
                Spacing = 15, // Elemanlar arası boşluk
                Children =
                {
                    // BAŞLIK
                    new Label()
                        .Text("KAYIT OL")
                        .TextColor(Colors.White)
                        .FontSize(28)
                        .FontAttributes(FontAttributes.Bold)
                        .CenterHorizontal()
                        .Margin(new Thickness(0, 0, 0, 20)),

                    // KUTULAR (Senin kodunda buralar eksikti)
                    CreateInputGroup("Ad", _nameEntry),
                    CreateInputGroup("Soyad", _surnameEntry),
                    CreateInputGroup("E-Posta", _emailEntry),
                    CreateInputGroup("Şifre", _passwordEntry),
                    CreateInputGroup("Şifre Tekrar", _passwordAgainEntry),

                    // SÖZLEŞME ONAYI
                    new HorizontalStackLayout
                    {
                        Spacing = 10,
                        Margin = new Thickness(0, 10, 0, 10),
                        Children =
                        {
                            _checkBox,
                            new Label()
                                .Text("Tüm metinleri okudum ve onaylıyorum")
                                .TextColor(Colors.White)
                                .FontSize(12)
                                .VerticalOptions(LayoutOptions.Center)
                        }
                    },

                    // KAYIT OL BUTONU
                    new Button()
                        .Text("Kayıt Ol")
                        .TextColor(Colors.White)
                        .BackgroundColor(Color.FromArgb("#1A00B0"))
                        .BorderColor(Colors.White)
                        .BorderWidth(1)
                        .HeightRequest(50)
                        .CornerRadius(10)
                        .Margin(new Thickness(0, 10, 0, 0))
                        .Bind(Button.CommandProperty, nameof(RegisterWiewModel.RegisterCommand)),

                    // ZATEN HESABIN VAR MI?
                    new HorizontalStackLayout
                    {
                        Spacing = 5,
                        HorizontalOptions = LayoutOptions.Center,
                        Margin = new Thickness(0, 20, 0, 0),
                        Children =
                        {
                            new Label().Text("Zaten hesabınız var mı?").TextColor(Colors.White).FontSize(13),
                            new Label()
                                .Text("GİRİŞ YAPIN")
                                .TextColor(Color.FromArgb("#3F63FF"))
                                .FontSize(13)
                                .FontAttributes(FontAttributes.Bold)
                                .GestureRecognizers(new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await Navigation.PopAsync())
                                })
                        }
                    }
                }
            }
        };
    }

    // Yardımcı Metot: Kod tekrarını önler, tasarımı standartlaştırır.
    private View CreateInputGroup(string title, Entry entry)
    {
        return new VerticalStackLayout
        {
            Spacing = 5,
            Children =
            {
                new Label().Text(title).TextColor(Colors.White).FontSize(13),
                new Border
                {
                    Stroke = Colors.White,
                    StrokeThickness = 1,
                    BackgroundColor = Colors.Transparent,
                    Padding = new Thickness(10, 0),
                    StrokeShape = new RoundRectangle { CornerRadius = new CornerRadius(10) },
                    Content = entry.BackgroundColor(Colors.Transparent).HeightRequest(45)
                }
            }
        };
    }
}