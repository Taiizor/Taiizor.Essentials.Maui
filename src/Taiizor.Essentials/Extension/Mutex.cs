using Taiizor.Essentials.Value;

namespace Taiizor.Essentials.Extension
{
    public class Mutex
    {
        public static bool Check()
        {
            return Control();
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