using System.Collections.Generic;

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
    }
}
