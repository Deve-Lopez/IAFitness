using IAFitness.ViewModels; // Importamos el ViewModel para enlazarlo a la vista

namespace IAFitness.Views;

public partial class IniciarSesionPage : ContentPage
{
	public IniciarSesionPage()
	{
		InitializeComponent();
        BindingContext = new IniciarSesionPageViewModel();
    }
}