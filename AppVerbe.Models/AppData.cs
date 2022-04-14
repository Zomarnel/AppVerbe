using System.Collections.Generic;
using System.Linq;

namespace AppVerbe.Models
{
    public class AppData
    {
        public string Name { get; set; }

        public List<Verbe> Verbes { get; }

        public string App_Language { get; set; }

        public AppData(string name, List<Verbe> verbes)
        {
            Name = name;
            Verbes = verbes;

            App_Language = "en";
        }

        public bool CheckIfVerbeInsideList(Verbe verbe)
        {

            foreach (Verbe item in Verbes)
            {

                if (verbe.Name == item.Name && verbe.Temps == item.Temps)
                {
                    return true;
                }
            }

            return false;
        }

        public List<Verbe> CloneVerbs()
        {
            return new List<Verbe>(Verbes);
        }

        public List<CheckedVerbe> ConvertVerbesToChecked()
        {
            List<CheckedVerbe> checkedVerbes = new List<CheckedVerbe>();

            foreach(Verbe verbe in Verbes)
            {
                checkedVerbes.Add(new CheckedVerbe(verbe));
            }

            return checkedVerbes;
        }
    }
}
