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
                AppData appData = new AppData();
                List<ConjuguatedForm> e = new List<ConjuguatedForm>();
                e.Add(new ConjuguatedForm(1, "mange"));

                appData.Verbes.Add(new Verbe("manger", e));
                File.WriteAllText(fileName,
                                  JsonConvert.SerializeObject(appData, Formatting.Indented));
            }

            return new AppData();

        }
    }
}
