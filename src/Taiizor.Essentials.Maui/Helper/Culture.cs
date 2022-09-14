using System.Globalization;
using Taiizor.Essentials.Maui.Value;

namespace Taiizor.Essentials.Maui.Helper
{
    internal class Culture
    {
        public static CultureInfo ConvertCulture(string Culture, bool Override = false)
        {
            try
            {
                return new CultureInfo(Culture, Override);
            }
            catch
            {
                return new CultureInfo(Internal.DefaultCulture, Override);
            }
        }
    }
}