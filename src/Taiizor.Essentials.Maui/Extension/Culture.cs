using System.Globalization;
using Taiizor.Essentials.Maui.Enum;
using Taiizor.Essentials.Maui.Value;
using HC = Taiizor.Essentials.Maui.Helper.Culture;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Culture
    {
        public static void Set(string Culture, bool Override = false)
        {
            Set(HC.ConvertCulture(Culture, Override));
        }

        public static void Set(CultureInfo Culture)
        {
            Set(SetCultureEnum.Culture, Culture);
            Set(SetCultureEnum.UICulture, Culture);
            Set(SetCultureEnum.ThreadCulture, Culture);
            Set(SetCultureEnum.ThreadUICulture, Culture);
        }

        public static void Set(SetCultureEnum Type, string Culture, bool Override = false)
        {
            Set(Type, HC.ConvertCulture(Culture, Override));
        }

        public static void Set(SetCultureEnum Type, CultureInfo Culture)
        {
            switch (Type)
            {
                case SetCultureEnum.UICulture:
                    CultureInfo.CurrentUICulture = Culture;
                    break;
                case SetCultureEnum.ThreadCulture:
                    Thread.CurrentThread.CurrentCulture = Culture;
                    CultureInfo.DefaultThreadCurrentCulture = Culture;
                    break;
                case SetCultureEnum.ThreadUICulture:
                    Thread.CurrentThread.CurrentUICulture = Culture;
                    CultureInfo.DefaultThreadCurrentUICulture = Culture;
                    break;
                default:
                    CultureInfo.CurrentCulture = Culture;
                    break;
            }
        }

        public static CultureInfo Get(GetCultureEnum Type, bool Override = false)
        {
            CultureInfo? Info = Type switch
            {
                GetCultureEnum.UICulture => CultureInfo.CurrentUICulture,
                GetCultureEnum.ThreadCulture => CultureInfo.DefaultThreadCurrentCulture,
                GetCultureEnum.ThreadUICulture => CultureInfo.DefaultThreadCurrentUICulture,
                GetCultureEnum.InvariantCulture => CultureInfo.InvariantCulture,
                GetCultureEnum.InstalledUICulture => CultureInfo.InstalledUICulture,
                _ => CultureInfo.CurrentCulture,
            };

            if (Info == null)
            {
                return HC.ConvertCulture(Internal.DefaultCulture, Override);
            }
            else
            {
                return Info;
            }
        }
    }
}