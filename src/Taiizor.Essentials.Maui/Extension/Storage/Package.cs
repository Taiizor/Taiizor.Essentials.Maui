namespace Taiizor.Essentials.Maui.Extension.Storage
{
    public class Package
    {
        public static async ValueTask<string> Read(string Name)
        {
            if (await Check(Name))
            {
                using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(Name);
                using StreamReader streamReader = new(fileStream);

                return await streamReader.ReadToEndAsync();
            }
            else
            {
                return string.Empty;
            }
        }

        public static async ValueTask<bool> Check(string Name)
        {
            return await FileSystem.Current.AppPackageFileExistsAsync(Name);
        }

        public static async ValueTask<bool> Check(string Name, string Content)
        {
            if (await Read(Name) == Content)
            {
                return true;
            }

            return false;
        }
    }
}