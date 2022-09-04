using Mutex = System.Threading.Mutex;

namespace Taiizor.Essentials.Value
{
    public class External
    {
        public static readonly Mutex Mutex = new(true, $"--[Taiizor.Essentials]--");

        public static readonly string MutexMessage = "Already Open Mutex Exception";
    }
}