namespace IAFitness.Views;
using IAFitness.ViewModels;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginPageViewModel();
	}
}