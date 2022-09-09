using System.Reflection;
using System.Text;

namespace Taiizor.Essentials.Maui.Extension
{
    public class Javascript
    {
        public static string File => LoadFileAsync;
        
        public static string FileScript
        {
            get
            {
                StringBuilder stringBuilder = new();

                stringBuilder.AppendLine("\t<script type=\"text/javascript\">");

                stringBuilder.AppendLine(File);

                stringBuilder.AppendLine("\t</script>");

                return stringBuilder.ToString();
            }
        }

        private static string LoadFileAsync
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "Taiizor.Essentials.Maui.Resources.Raw.taiizor.blazor.js";

                using var stream = assembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var result = reader.ReadToEnd();

                return result;
            }
        }
    }
}