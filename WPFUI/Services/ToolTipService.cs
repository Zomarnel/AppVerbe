using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AppVerbe.Models;

namespace WPFUI
{
    public static class ToolTipService
    {
        public static void CreateToolTip(Verbe verbe, string language)
        {
            string toolTipContent = "";

            foreach (ConjuguatedForm conjuguatedForm in verbe.ConjuguatedForms)
            {
                toolTipContent += LanguageService.Translate(conjuguatedForm.ReturnPersonneInStringFormat(), language);

                toolTipContent += "         ";

                toolTipContent += conjuguatedForm.VerbeConjugué;

                toolTipContent += Environment.NewLine;
            }

            verbe.ToolTipContent = toolTipContent;
        }

        public static void CreateToolTipForEachVerb(List<Verbe> verbes, string language)
        {
            foreach(Verbe verbe in verbes)
            {
                CreateToolTip(verbe, language);
            }
        }
    }
}
