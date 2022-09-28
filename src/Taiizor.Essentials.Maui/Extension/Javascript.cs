using System.Reflection;
using System.Text;
using Taiizor.Essentials.Maui.Enum;
using HJ = Taiizor.Essentials.Maui.Helper.Javascript;

namespace Taiizor.Essentials.Maui.Extension
{
    internal class Javascript
    {
        public static string File(JavascriptEnum Javascript)
        {
            return LoadFileAsync(Javascript);
        }

        public static string FileScript(JavascriptEnum Javascript)
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine("<script type=\"text/javascript\">");

            stringBuilder.AppendLine(File(Javascript));

            stringBuilder.AppendLine("</script>");

            return stringBuilder.ToString();
        }

        private static string LoadFileAsync(JavascriptEnum Javascript)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = HJ.GetFile(Javascript);

            using Stream? stream = assembly.GetManifestResourceStream(resourceName);

            using StreamReader reader = new(stream);

            return reader.ReadToEnd();
        }
    }
}