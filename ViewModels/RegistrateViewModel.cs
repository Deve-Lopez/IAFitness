using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace IAFitness.ViewModels
{
    public partial class RegistrateViewModel : ObservableObject
    {
        // Navega a la página anterior
        [RelayCommand]
        private async Task VolverAtrasAsync()
        {
            await Shell.Current.GoToAsync("..");
        }

        //Display Alert Ayuda
        [RelayCommand]
        private async Task AyudaAsync()
        {
            await Shell.Current.DisplayAlert("", "Crea una cuenta para guardar tus entrenamientos y acceder al historial de entrenamientos en varios dispositivos", "Ok");
        }
    }
}
