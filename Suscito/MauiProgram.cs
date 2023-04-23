using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using Suscito.Data;
using Suscito.Modules.AT;

namespace Suscito;

public static class MauiProgram
{
	/// <summary>
	/// 
	/// </summary>
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddLocalization();

        builder.Services.AddLogging(logging =>
        {
            // logging.AddFilter("Microsoft.AspNetCore.Components.WebView", LogLevel.Trace);
            logging.SetMinimumLevel(LogLevel.Trace);
            logging.AddDebug();
        });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif


        builder
            .UseMauiApp<App>()
            .ConfigureLifecycleEvents(events =>
            {
#if WINDOWS
                // HACK: hack due to https://github.com/dotnet/maui/issues/7227
                events.AddWindows(windows => windows
                    .OnWindowCreated(window =>
                    {
                        window.SizeChanged += OnSizeChanged;
                    }));
#endif
            });

        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<IATProfileProvider, TestATProfileProvider>();

        return builder.Build();
	}

#if WINDOWS
    static void OnSizeChanged(object sender, Microsoft.UI.Xaml.WindowSizeChangedEventArgs args)
    {
        Shell.Current.FlyoutBehavior = (args.Size.Width > 800 ? FlyoutBehavior.Locked : FlyoutBehavior.Flyout);
    }
#endif
}
