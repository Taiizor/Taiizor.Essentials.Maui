using Microsoft.Maui.LifecycleEvents;
using Taiizor.Essentials.Maui.AppCenter.Enum;
using Taiizor.Essentials.Maui.AppCenter.Services;

#if WINDOWS

using Application = Microsoft.UI.Xaml.Application;

#endif

namespace Initialize
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
#endif
            builder.ConfigureLifecycleEvents(events =>
            {

#if WINDOWS
			    events.AddWindows(windows => windows
			        .OnLaunching((window, args) => AppCenter()));
#elif ANDROID
                events.AddAndroid(android => android
                    .OnCreate((activity, bundle) => AppCenter()));
#elif IOS || MACCATALYST
                events.AddiOS(ios => ios
                    .FinishedLaunching((app, dict) => AppCenter()));
#endif

            });

            return builder.Build();
        }

        private static bool AppCenter()
        {
            AppCenterService.Engine(new()
            {
                { AppEnum.iOS, "{Your iOS App secret here}" },
                { AppEnum.macOS, "{Your macOS App secret here}" },
                { AppEnum.Android, "{Your Android App secret here}" },
                { AppEnum.Windows, "{Your Windows App secret here}" }
            });

            AppDomain.CurrentDomain.FirstChanceException += ExceptionService.Set;
            AppDomain.CurrentDomain.UnhandledException += ExceptionService.Set;
            TaskScheduler.UnobservedTaskException += ExceptionService.Set;

#if WINDOWS
            Application.Current.UnhandledException += ExceptionService.Set;
#endif

            return true;
        }
    }
}