
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
    }
}
