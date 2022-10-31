using Microsoft.Maui.LifecycleEvents;
using Taiizor.Essentials.Maui.Enum;
using Taiizor.Essentials.Maui.Value;

#if WINDOWS
using Microsoft.UI.Windowing;
using Microsoft.UI;
#elif MACCATALYST || IOS
using UIKit;
using Foundation;
#elif ANDROID
using Android.Views;
#endif

namespace Taiizor.Essentials.Maui.Extension
{
    public static class Configure
    {
        public static void UseFullscreen(this MauiAppBuilder Builder)
        {
            UseFullscreen(Builder, Internal.AppFullscreen);
        }

        public static void UseFullscreen(this MauiAppBuilder Builder, Dictionary<AppEnum, bool> Apps)
        {
            App(Apps);
            
            Builder.ConfigureLifecycleEvents(events =>
            {
#if WINDOWS
                events.AddWindows(windows =>
                {
                    windows.OnWindowCreated(window =>
                    {
                        if (Internal.AppFullscreen[AppEnum.Windows])
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
                        }
                    });
                });
#elif ANDROID
                events.AddAndroid(android => android
                    .OnCreate((activity, bundle) => {
                        if (Internal.AppFullscreen[AppEnum.Android])
                        {
                            activity.Window?.AddFlags(WindowManagerFlags.Fullscreen);
                        }
                    })
                );
#elif IOS || MACCATALYST
                events.AddiOS(ios => ios
                    .FinishedLaunching((app, dict) =>
                    {
                        if (Internal.AppFullscreen[AppEnum.iOS] || Internal.AppFullscreen[AppEnum.macOS])
                        {
                            app.KeyWindow.RootViewController.ModalPresentationCapturesStatusBarAppearance = false;

                            app.SetStatusBarHidden(true, UIStatusBarAnimation.None);
                            UIApplication.SharedApplication.SetStatusBarHidden(true, UIStatusBarAnimation.None);

                            static UIView GetStatusBar()
                            {
                                UIView? statusBar;

                                if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
                                {
                                    int tag = 123; //Customize this tag as you want so we don't create it over and over

                                    UIWindow window = UIApplication.SharedApplication.Windows.FirstOrDefault();

                                    statusBar = window.ViewWithTag(tag);

                                    if (statusBar == null)
                                    {
                                        statusBar = new UIView(UIApplication.SharedApplication.StatusBarFrame);
                                        statusBar.Tag = tag;
                                        statusBar.BackgroundColor = UIColor.Red; //Customize the view

                                        window.AddSubview(statusBar);
                                    }
                                }
                                else
                                {
                                    statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
                                }

                                return statusBar;
                            }

                            GetStatusBar().Hidden = true;
                        }

                        return true;
                    })
                );
#endif
            });
        }
        
        private static void App(Dictionary<AppEnum, bool> Apps)
        {
            if (Apps != null && Apps.Keys.Count > 0)
            {
                foreach (AppEnum App in Apps.Keys)
                {
                    Internal.AppFullscreen[App] = Apps[App];
                }
            }
        }
    }
}