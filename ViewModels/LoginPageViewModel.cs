using CommunityToolkit.Mvvm.ComponentModel;  // Para ObservableObject y MVVM helpers
using System.Windows.Input;                    // Para ICommand
using Microsoft.Maui.Controls;                 // Para Command y Shell

namespace IAFitness.ViewModels
{
    // ViewModel para la página de Login que implementa INotifyPropertyChanged a través de ObservableObject
    public partial class LoginPageViewModel : ObservableObject
    {
        // Comando público que enlazamos desde la vista para ejecutar la navegación a RegistratePage
        public ICommand RegistrateAsyncCommand { get; }

        // Comando público que enlazamos desde la vista para ejecutar la navegación a IniciarSesionPage
        public ICommand IniciarSesionAsyncCommand { get; }


        // Constructor donde inicializamos el comando
        public LoginPageViewModel()
        {
            // Crear el comando que ejecuta la navegación asincrónica a la página "RegistratePage"
            RegistrateAsyncCommand = new Command(async () =>
            {
                // Navega a la ruta "RegistratePage" definida en AppShell
                await Shell.Current.GoToAsync("RegistratePage");
            });
            // Crear el comando que ejecuta la navegación asincrónica a la página "IniciarSesionPage"
            IniciarSesionAsyncCommand = new Command(async () =>
            {
                // Navega a la ruta "IniciarSesionPage" definida en AppShell
                await Shell.Current.GoToAsync("IniciarSesionPage");
            });
        }
    }
}
