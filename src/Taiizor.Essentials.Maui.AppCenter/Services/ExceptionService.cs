using System.Runtime.ExceptionServices;
using Taiizor.Essentials.Maui.Services;

#if WINDOWS

using Application = Microsoft.UI.Xaml.Application;
using Unhandled = Microsoft.UI.Xaml.UnhandledExceptionEventArgs;

#endif

namespace Taiizor.Essentials.Maui.AppCenter.Services
{
    public class ExceptionService
    {
        public static void Set(object sender, FirstChanceExceptionEventArgs e)
        {
            AppDomain.CurrentDomain.FirstChanceException += (sender, error) =>
            {
                AppCenterService.Exception(error);
            };

            AppCenterService.Exception(e);
        }

        public static void Set(object sender, UnhandledExceptionEventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
            {
                AppCenterService.Exception(error);
            };

            AppCenterService.Exception(e);
        }

#if WINDOWS

        public static void Set(object sender, Unhandled e)
        {
            Application.Current.UnhandledException += (sender, error) =>
            {
                AppCenterService.Exception(error);
            };

            AppCenterService.Exception(e);
        }

#endif

        public static void Set(object sender, UnobservedTaskExceptionEventArgs e)
        {
            TaskScheduler.UnobservedTaskException += (sender, error) =>
            {
                AppCenterService.Exception(error);
            };

            AppCenterService.Exception(e);
        }
    }
}