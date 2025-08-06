using IAFitness.ViewModels;

namespace IAFitness.Views
{
    public partial class RegistratePage : ContentPage
    {
        public RegistratePage()
        {
            InitializeComponent();
            BindingContext = new RegistrateViewModel();
        }
    }
}
