using System.Text;
using Taiizor.Essentials.Maui.Enum;
using HJ = Taiizor.Essentials.Maui.Helper.Javascript;

namespace Taiizor.Essentials.Maui.Extension
{
    internal class Javascript
    {
        public static string File(JavascriptEnum Javascript)
        {
            return HJ.LoadFile(Javascript);
        }

        public static string FileScript(JavascriptEnum Javascript)
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine("<script type=\"text/javascript\">");

            stringBuilder.AppendLine(HJ.LoadFile(Javascript));

            stringBuilder.AppendLine("</script>");

            return stringBuilder.ToString();
        }
    }
}