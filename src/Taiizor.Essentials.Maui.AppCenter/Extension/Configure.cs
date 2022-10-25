using Microsoft.Maui.LifecycleEvents;
using System.Diagnostics;
using Taiizor.Essentials.Maui.AppCenter.Enum;
using Taiizor.Essentials.Maui.AppCenter.Services;
using Taiizor.Essentials.Maui.AppCenter.Struct;
using Taiizor.Essentials.Maui.AppCenter.Value;

namespace Taiizor.Essentials.Maui.AppCenter.Extension
{
    public static class Configure
    {
        public static void UseAppCenter(this MauiAppBuilder Builder, Dictionary<AppEnum, string> Keys)
        {
            UseAppCenter(Builder, Keys, Internal.AppCenterWatch);
        }

        public static void UseAppCenter(this MauiAppBuilder Builder, Dictionary<AppEnum, string> Keys, WatchStruct Watch)
        {
            Builder.ConfigureLifecycleEvents(events =>
            {
#if WINDOWS
                events.AddWindows(windows => windows
                    .OnActivated((window, args) => LogEvent("OnActivated", $"{args}"))
                    .OnClosed((window, args) => LogEvent("OnClosed", $"{args}")) //End
                    .OnLaunched((window, args) => LogEvent("OnLaunched", $"{args}"))
                    .OnLaunching((window, args) => AppCenterService.Engine(Keys, Watch)) //Start //LogEvent("OnLaunching", $"{args}")
                    .OnWindowCreated((window) => LogEvent("OnWindowCreated"))
                    .OnResumed((window) => LogEvent("OnResumed"))
                    .OnVisibilityChanged((window, args) => LogEvent("OnVisibilityChanged", $"{args}")));
#elif ANDROID
                events.AddAndroid(android => android
                    .OnActivityResult((activity, requestCode, resultCode, data) => LogEvent("OnActivityResult", $"{requestCode}, {resultCode}, {data}"))
                    .OnStart((activity) => LogEvent("OnStart"))
                    .OnCreate((activity, bundle) => AppCenterService.Engine(Keys, Watch)) //Start //LogEvent("OnCreate", $"{bundle}")
                    .OnBackPressed((activity) => LogEvent("OnBackPressed"))
                    .OnStop((activity) => LogEvent("OnStop"))); //End
#elif IOS || MACCATALYST
                events.AddiOS(ios => ios
                    .OnActivated((app) => LogEvent("OnActivated"))
                    .OnResignActivation((app) => LogEvent("OnResignActivation"))
                    .DidEnterBackground((app) => LogEvent("DidEnterBackground"))
                    .FinishedLaunching((app, dict) => AppCenterService.Engine(Keys, Watch)) //Start //LogEvent("FinishedLaunching", $"{dict}")
                    .WillTerminate((app) => LogEvent("WillTerminate"))); //End
#endif
            });
        }

        private static bool LogEvent(string eventName, string type = null)
        {
            if (Internal.AppCenterDebug)
            {
                Debug.WriteLine($"Lifecycle Event: {eventName}{(type == null ? string.Empty : $" ({type})")}");
            }

            return true;
        }
    }
}