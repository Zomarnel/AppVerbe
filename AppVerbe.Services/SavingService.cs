using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AppVerbe.Models;

namespace AppVerbe.Services
{
    public static class SavingService
    {
        public static AppData LoadListOrCreateNewOne(string fileName)
        {
            if(!File.Exists(fileName))
            {
                File.WriteAllText(fileName,
                                  JsonConvert.SerializeObject(new AppData(), Formatting.Indented));
            }

            return new AppData();

        }
    }
}
