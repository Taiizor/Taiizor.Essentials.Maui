using Microsoft.Maui.LifecycleEvents;

#if WINDOWS
using Microsoft.UI.Windowing;
using Microsoft.UI;
#elif ANDROID
using Android.Views;
#endif

namespace Taiizor.Essentials.Maui.Extension
{
    public static class Configure
    {
        public static void UseFullscreen(this MauiAppBuilder Builder)
        {
            Builder.ConfigureLifecycleEvents(events =>
            {
#if WINDOWS
                events.AddWindows(windows =>
                {
                    windows.OnWindowCreated(window =>
                    {
                        window.ExtendsContentIntoTitleBar = false;
                        
                        var handle = WinRT.Interop.WindowNative.GetWindowHandle(window);
                        var id = Win32Interop.GetWindowIdFromWindow(handle);
                        var appWindow = AppWindow.GetFromWindowId(id);
                        
                        switch (appWindow.Presenter)
                        {
                            case OverlappedPresenter overlappedPresenter:
                                overlappedPresenter.SetBorderAndTitleBar(false, false);
                                overlappedPresenter.Maximize();
                                break;
                        }
                    });
                });
#elif ANDROID
                events.AddAndroid(android => android
                    .OnCreate((activity, bundle) => {
                        activity.Window?.AddFlags(WindowManagerFlags.Fullscreen);
                    })
                );
//#elif IOS || MACCATALYST
//                events.AddiOS(ios => ios
//                    .OnActivated((app) => LogEvent("OnActivated"))
//                    .OnResignActivation((app) => LogEvent("OnResignActivation"))
//                    .DidEnterBackground((app) => LogEvent("DidEnterBackground"))
//                    .FinishedLaunching((app, dict) => AppCenterService.Engine(Keys, Watch)) //Start //LogEvent("FinishedLaunching", $"{dict}")
//                    .WillTerminate((app) => LogEvent("WillTerminate"))); //End
#endif
            });
        }
    }
}