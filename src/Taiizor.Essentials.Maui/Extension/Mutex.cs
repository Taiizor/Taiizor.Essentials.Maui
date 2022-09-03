using Taiizor.Essentials.Maui.Value;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Mutex
    {
        public static bool Check()
        {
            return Control();
        }

        public static MauiApp Check(MauiApp App)
        {
            if (Control())
            {
                return App;
            }
            else
            {
                throw new Exception(External.MutexMessage);
            }
        }

        private static bool Control()
        {
            try
            {
                if (External.Mutex.WaitOne(TimeSpan.Zero, true))
                {
                    External.Mutex.ReleaseMutex();

                    return true;
                }
            }
            catch
            {
                throw new Exception(External.MutexMessage);
            }

            throw new Exception(External.MutexMessage);
        }
    }
}