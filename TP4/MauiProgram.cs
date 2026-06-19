using Microsoft.Extensions.Logging;

namespace TP4
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            //configuración de HttpClient para DummyJson
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://dummyjson.com/") });

            builder.Services.AddScoped<ProductService>();


            return builder.Build();
        }
    }
}
