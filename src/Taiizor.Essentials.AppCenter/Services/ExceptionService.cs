using System.Runtime.ExceptionServices;
using Taiizor.Essentials.Services;

namespace Taiizor.Essentials.AppCenter.Services
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