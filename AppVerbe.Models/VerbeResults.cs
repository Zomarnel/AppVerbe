using System.Linq;
using System.Collections.Generic;

namespace AppVerbe.Models
{
    public class VerbeResults
    {
        public List<VerbeResult> Results { get; } = new List<VerbeResult>();
        public string ResultsStringFormat => $"Final result: {Results.Where(r => r.Result == true).Count()}/{Results.Count()}";

    }
}
