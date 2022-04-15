using System;
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
                throw new FileNotFoundException($"Filename: {fileName}");
            }

            JObject data = JObject.Parse(File.ReadAllText(fileName));

            return CreateAppData(data);

        }

        public static void SaveList(AppData appData, string fileName)
        {
            File.WriteAllText(fileName,
                              JsonConvert.SerializeObject(appData, Formatting.Indented));
        }
        private static AppData CreateAppData(JObject data)
        {
            List<Verbe> verbes = new List<Verbe>();

            foreach(JToken verbToken in (JArray)data[nameof(AppData.Verbes)])
            {
                List<ConjuguatedForm> conjuguatedForms = new List<ConjuguatedForm>();

                foreach(JToken conjuguationToken in (JArray)verbToken[nameof(Verbe.ConjuguatedForms)])
                {
                    conjuguatedForms.Add(new ConjuguatedForm((int)conjuguationToken[nameof(ConjuguatedForm.Personne)],
                                                              (string)conjuguationToken[nameof(ConjuguatedForm.VerbeConjugué)]));
                }

                verbes.Add(new Verbe((string)verbToken[nameof(Verbe.Name)],
                                     (string)verbToken[nameof(Verbe.Temps)],
                                     conjuguatedForms));
            }

            AppData appData = new AppData((string)data[nameof(AppData.Name)], verbes);

            appData.App_Language = (string)data[nameof(AppData.App_Language)];
            return appData;
        }
    }
}