
namespace AppVerbe.Models
{
    public class VerbeResult
    {
        public Verbe Verbe { get; init; }
        public bool Result { get; init; }

        public VerbeResult(Verbe verbe, bool result)
        {
            Verbe = verbe;
            Result = result;
        }
    }
}
