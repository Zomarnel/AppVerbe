using System.ComponentModel;
using System;

namespace AppVerbe.Models
{
    public class CheckedVerbe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Verbe Verbe { get; init; }

        public bool IsChecked { get; set; }

        public string ToolTipContent => GetToolTipContent();

        public CheckedVerbe(Verbe verbe)
        {
            Verbe = verbe;
        }

        private string GetToolTipContent()
        {
            string toolTipContent = "";

            foreach(ConjuguatedForm conjuguatedForm in Verbe.ConjuguatedForms)
            {
                toolTipContent += conjuguatedForm.ReturnPersonneInStringFormat();

                toolTipContent += "         ";

                toolTipContent += conjuguatedForm.VerbeConjugué;

                toolTipContent += Environment.NewLine;
            }

            return toolTipContent;
        }
    }
}
