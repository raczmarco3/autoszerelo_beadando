using AutoSzerelo_Szerver.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AutoSzerelo_Szerver.Repositories
{
    public static class WorkRepository
    {
        //Beolvassuk a json fájlt és a tartalmát beletesszük egy Work típusú listába. 
        //Ha a fájl nem létezik akkor egy üres listát adunk vissza.
        public static IList<Work> GetWork()
        {
            var appDataPath = GetAppDataPath();

            if (File.Exists(appDataPath))
            {
                var rawContent = File.ReadAllText(appDataPath);
                var work = JsonSerializer.Deserialize<IList<Work>>(rawContent);

                return work;
            }

            return new List<Work>();
        }

        public static void StoreWork(IList<Work> work)
        {
            var appDataPath = GetAppDataPath();
            var rawContent = JsonSerializer.Serialize(work);

            File.WriteAllText(appDataPath, rawContent);
        }

        //Megnézi az AppData/Local mappában,hogy létezik-e az "AutoSzerelo_Szerver" mappa, ha nem akkor létrehozza
        public static string GetLocalFolder()
        {
           var localAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
           var localAppFolder = Path.Combine(localAppDataFolder, "AutoSzerelo_Szerver");

            if (!Directory.Exists(localAppFolder))
            {
                Directory.CreateDirectory(localAppFolder);
            }

            return localAppFolder;
        }

        //A munkákat tároló json fájl elérése
        public static string GetAppDataPath()
        {
            var localAppFolder = GetLocalFolder();
            var appDataPath = Path.Combine(localAppFolder, "Work.json");

            return appDataPath;
        }
    }
}
