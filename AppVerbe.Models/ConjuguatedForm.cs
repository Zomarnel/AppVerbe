using System;
using System.Windows;

namespace AppVerbe.Models
{
    public class ConjuguatedForm
    {
        public int Personne { get; init; }

        public string VerbeConjugué { get; init; }

        public ConjuguatedForm(int personne, string verbeConjugué)
        {
            Personne = personne;
            VerbeConjugué = verbeConjugué;
        }

        public string ReturnPersonneInStringFormat()
        {
            

            switch(Personne)
            {
                case 1:
                    return "Je";
                case 2:
                    return "Tu";
                case 3:
                    return "Il/Elle";
                case 4:
                    return "Nous";
                case 5:
                    return "Vous";
                case 6:
                    return "Ils/Elles";
                default:
                    throw new InvalidCastException();
            }
        }
    }
}
