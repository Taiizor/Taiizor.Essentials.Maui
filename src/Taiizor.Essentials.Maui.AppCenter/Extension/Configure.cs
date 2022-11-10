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
                    .OnActivated((window, args) => Feedback("OnActivated", $"{args}"))
                    .OnClosed((window, args) => Feedback("OnClosed", $"{args}")) //End
                    .OnLaunched((window, args) => Feedback("OnLaunched", $"{args}"))
                    .OnLaunching((window, args) => AppCenterService.Engine(Keys, Watch)) //Start //Feedback("OnLaunching", $"{args}")
                    .OnWindowCreated((window) => Feedback("OnWindowCreated"))
                    .OnResumed((window) => Feedback("OnResumed"))
                    .OnVisibilityChanged((window, args) => Feedback("OnVisibilityChanged", $"{args}")));
#elif ANDROID
                events.AddAndroid(android => android
                    .OnActivityResult((activity, requestCode, resultCode, data) => Feedback("OnActivityResult", $"{requestCode}, {resultCode}, {data}"))
                    .OnStart((activity) => Feedback("OnStart"))
                    .OnCreate((activity, bundle) => AppCenterService.Engine(Keys, Watch)) //Start //Feedback("OnCreate", $"{bundle}")
                    .OnBackPressed((activity) => Feedback("OnBackPressed"))
                    .OnStop((activity) => Feedback("OnStop"))); //End
#elif IOS || MACCATALYST
                events.AddiOS(ios => ios
                    .OnActivated((app) => Feedback("OnActivated"))
                    .OnResignActivation((app) => Feedback("OnResignActivation"))
                    .DidEnterBackground((app) => Feedback("DidEnterBackground"))
                    .FinishedLaunching((app, dict) => AppCenterService.Engine(Keys, Watch)) //Start //Feedback("FinishedLaunching", $"{dict}")
                    .WillTerminate((app) => Feedback("WillTerminate"))); //End
#endif
            });
        }

        private static bool Feedback(string eventName, string type = null)
        {
            Debug.WriteLine($"Lifecycle Event: {eventName}{(type == null ? string.Empty : $" ({type})")}");

            return true;
        }
    }
}