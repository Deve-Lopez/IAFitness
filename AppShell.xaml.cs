namespace IAFitness
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("RegistratePage", typeof(Views.RegistratePage));
            Routing.RegisterRoute("IniciarSesionPage", typeof(Views.IniciarSesionPage));
        }
    }
}
