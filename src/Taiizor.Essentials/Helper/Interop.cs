using EI = Taiizor.Essentials.Extension.Interop;
using Microsoft.JSInterop;

namespace Taiizor.Essentials.Helper
{
    internal class Interop
    {
        public static void CheckRuntime()
        {
            if (EI.JS is null)
            {
                throw new ArgumentNullException(nameof(EI.JS));
            }
        }
        
        public static void CheckRuntime(IJSRuntime JSR)
        {
            if (JSR is null)
            {
                throw new ArgumentNullException(nameof(JSR));
            }
        }
        
        public static void CheckScript(string Script)
        {
            if (Script is null)
            {
                throw new ArgumentNullException(nameof(Script));
            }
        }
    }
}