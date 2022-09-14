using Microsoft.JSInterop;

namespace Taiizor.Essentials.Maui.Helper
{
    internal class Interop
    {
        public static void CheckRuntime(IJSRuntime JSR)
        {
            if (JSR is null)
            {
                throw new ArgumentNullException(nameof(JSR));
            }
        }
    }
}