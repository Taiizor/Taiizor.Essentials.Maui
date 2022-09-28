namespace Taiizor.Essentials.Maui.Extension.Storage
{
    public class Package
    {
        public static async ValueTask<string> Read(string Name)
        {
            bool Exists = await Check(Name);

            if (Exists)
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
    }
}