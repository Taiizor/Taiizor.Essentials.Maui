using Taiizor.Essentials.Maui.Extension;
using Mutex = System.Threading.Mutex;

namespace Taiizor.Essentials.Maui.Value
{
    public class External
    {
        public static readonly Mutex Mutex = new(true, $"--[{Project.Name}]--");

        public static readonly string MutexMessage = "Already Open Mutex Exception";
    }
}