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

        public bool CheckIfVerbeInsideList(Verbe verbe)
        {
            string forms1 = "";
            verbe.ConjuguatedForms.ForEach(cf => forms1 += cf.VerbeConjugué);

            foreach (Verbe item in Verbes)
            {
                string forms = "";

                item.ConjuguatedForms.ForEach(cf => forms += cf.VerbeConjugué);

                if(forms == forms1 && verbe.Name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
