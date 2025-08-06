using IAFitness.ViewModels;

namespace IAFitness.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new LoginPageViewModel();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        string fullText = "La revolución del fitness está en la IA";
        EsloganLabel.Text = "";
        EsloganLabel.Opacity = 1;

        foreach (char c in fullText)
        {
            EsloganLabel.Text += c;
            await Task.Delay(80);
        }
    }
}
