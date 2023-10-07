using Microsoft.Extensions.Logging;
using SQLiteDataAcessLibrary.Services;

namespace Finance_Control
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

                    fonts.AddFont("Font-Awesome-Brands-Regular-400.otf", "FontAwesomeBR");
                    fonts.AddFont("Font-Awesome-Free-Regular-400.otf", "FontAwesomeFR");
                    fonts.AddFont("Font-Awesome-Free-Solid-900.otf", "FontAwesomeFS");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<ITransactionService, TransactionService>();

            return builder.Build();
        }
    }
}