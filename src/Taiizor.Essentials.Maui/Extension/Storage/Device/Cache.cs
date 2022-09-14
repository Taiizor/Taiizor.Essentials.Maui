﻿using Taiizor.Essentials.Maui.Value;
using Taiizor.Essentials.Maui.Helper;

namespace Taiizor.Essentials.Maui.Extension.Storage.Device
{
    public class Cache
    {
        public static async Task Save(string Name, string Content)
        {
            using FileStream fileStream = File.OpenWrite(Combine.FullPath(Internal.CacheDirectory, Name, Internal.StorageExtension));
            
            using StreamWriter streamWriter = new(fileStream);

            await streamWriter.WriteAsync(Content);
        }
        
        public static async ValueTask<string> Read(string Name)
        {
            if (Check(Name))
            {
                using FileStream fileStream = File.OpenRead(Combine.FullPath(Internal.CacheDirectory, Name, Internal.StorageExtension));

                using StreamReader streamReader = new(fileStream);

                return await streamReader.ReadToEndAsync();
            }
            else
            {
                return string.Empty;
            }
        }

        public static bool Check(string Name)
        {
            return File.Exists(Combine.FullPath(Internal.CacheDirectory, Name, Internal.StorageExtension));
        }

        public static void Delete(string Name, bool Execute = false)
        {
            if (Check(Name) || Execute)
            {
                try
                {
                    File.Delete(Combine.FullPath(Internal.CacheDirectory, Name, Internal.StorageExtension));
                }
                catch
                {
                    //
                }
            }
        }
    }
}