using Microsoft.Extensions.Logging;

namespace IAFitness
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons");
                    fonts.AddFont("FontAwesomeBrands-Regular.ttf", "FABrands");
                    fonts.AddFont("PlayfairDisplay-Italic-VariableFont_wght.ttf", "PlayfairItalic");
                    fonts.AddFont("PlayfairDisplay-VariableFont_wght.ttf", "Playfair");
                    fonts.AddFont("jumpshot.regular.ttf", "Jumpshot");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
