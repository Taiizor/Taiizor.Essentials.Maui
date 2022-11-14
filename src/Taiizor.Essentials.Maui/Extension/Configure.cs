using Microsoft.Maui.LifecycleEvents;
using Taiizor.Essentials.Maui.Enum;
using Taiizor.Essentials.Maui.Value;
using Taiizor.Essentials.Maui.Struct;

#if WINDOWS
using WinRT.Interop;
using Microsoft.UI.Windowing;
using Windows.Graphics;
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
            FullscreenApp(Apps);

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

                            AppWindow appWindow = GetWindow(window);

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
                    .OnCreate((activity, bundle) =>
                    {
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

        public static void UseProperties(this MauiAppBuilder Builder)
        {
            UseProperties(Builder, Internal.AppProperties);
        }

        public static void UseProperties(this MauiAppBuilder Builder, Dictionary<AppEnum, PropertyStruct> Apps)
        {
            PropertiesApp(Apps);

#if WINDOWS
            Builder.ConfigureLifecycleEvents(events =>
            {
                events.AddWindows(windows =>
                {
                    windows.OnWindowCreated(window =>
                    {
                        AppWindow appWindow = GetWindow(window);

                        switch (appWindow.Presenter)
                        {
                            case OverlappedPresenter overlappedPresenter:
                                overlappedPresenter.IsResizable = Internal.AppProperties[AppEnum.Windows].Resizable;
                                overlappedPresenter.IsAlwaysOnTop = Internal.AppProperties[AppEnum.Windows].AlwaysOnTop;
                                overlappedPresenter.IsMaximizable = Internal.AppProperties[AppEnum.Windows].Maximizable;
                                overlappedPresenter.IsMinimizable = Internal.AppProperties[AppEnum.Windows].Minimizable;
                                break;
                        }

                        if (Internal.AppProperties[AppEnum.Windows].MoveAndResize != null && Internal.AppProperties[AppEnum.Windows].MoveAndResize.HasValue)
                        {
                            MovanizeStruct movanize = Internal.AppProperties[AppEnum.Windows].MoveAndResize.Value;

                            appWindow.MoveAndResize(new RectInt32(movanize.X, movanize.Y, movanize.Width, movanize.Height));
                        }
                    });
                });
            });
#endif
        }

#if WINDOWS
        private static AppWindow GetWindow(Microsoft.UI.Xaml.Window Window)
        {
            return AppWindow.GetFromWindowId(Win32Interop.GetWindowIdFromWindow(WindowNative.GetWindowHandle(Window)));
        }
#endif

        private static void FullscreenApp(Dictionary<AppEnum, bool> Apps)
        {
            if (Apps != null && Apps.Keys.Count > 0)
            {
                foreach (AppEnum App in Apps.Keys)
                {
                    Internal.AppFullscreen[App] = Apps[App];
                }
            }
        }

        private static void PropertiesApp(Dictionary<AppEnum, PropertyStruct> Apps)
        {
            if (Apps != null && Apps.Keys.Count > 0)
            {
                foreach (AppEnum App in Apps.Keys)
                {
                    Internal.AppProperties[App] = Apps[App];
                }
            }
        }
    }
}