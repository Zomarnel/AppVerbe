using System.Collections.Generic;
using System.Linq;

namespace AppVerbe.Models
{
    public class AppData
    {
        public string Name { get; set; }

        public List<Verbe> Verbes { get; }

        public AppData(string name, List<Verbe> verbes)
        {
            Name = name;
            Verbes = verbes;
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
    }
}
