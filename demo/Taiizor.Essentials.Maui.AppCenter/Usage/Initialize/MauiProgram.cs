using Microsoft.Maui.LifecycleEvents;
using Taiizor.Essentials.Maui.AppCenter.Enum;
using Taiizor.Essentials.Maui.AppCenter.Services;
using Taiizor.Essentials.Maui.Cross;

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
			        .OnLaunching((window, args) => Initialize()));
#elif ANDROID
                events.AddAndroid(android => android
                    .OnCreate((activity, bundle) => Initialize()));
#elif IOS || MACCATALYST
                events.AddiOS(ios => ios
                    .FinishedLaunching((app, dict) => Initialize()));
#endif

            });

            return builder.Build();
        }

        private static bool Initialize()
        {
            AppCenterService.Engine(new()
            {
                { AppEnum.iOS, "96d269eb-2c51-49e6-bdda-72ec977c3769" },
                { AppEnum.macOS, "b2ec4587-0ecf-41a5-8109-ddf028bd0c1f" },
                { AppEnum.Android, "86acdee1-f5f9-4512-bd5c-5c54f77dc48c" },
                { AppEnum.Windows, "40d6b7c6-0d0a-4e5a-94d3-faec48873da1" }
            });

            // ======================================================================= \\
            
            //Taiizor.Essentials.Maui.AppCenter - Basic usage
            
            AppDomain.CurrentDomain.FirstChanceException += ExceptionService.Set;
            AppDomain.CurrentDomain.UnhandledException += ExceptionService.Set;
            TaskScheduler.UnobservedTaskException += ExceptionService.Set;

#if WINDOWS
            Application.Current.UnhandledException += ExceptionService.Set;
#endif

            //Taiizor.Essentials.Maui.AppCenter - Basic usage


            // ========================== Use only 1 method ========================== \\


            //Taiizor.Essentials.Maui - Basic usage

            CrossException.UnhandledException += (sender, args) =>
            {
                AppCenterService.Exception(args);
            };

            //Taiizor.Essentials.Maui - Basic usage

            // ======================================================================= \\

            return true;
        }
    }
}