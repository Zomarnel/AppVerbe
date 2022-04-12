using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AppVerbe.Models;

namespace WPFUI.Window.CustomizationWindows
{

    public partial class VerbModificationWindow : System.Windows.Window
    {
        private Verbe _verbe;

        private List<System.Windows.Controls.TextBox> _textBoxes;

        public VerbModificationWindow(Verbe verbe)
        {
            InitializeComponent();

            _verbe = verbe;

            _textBoxes = new List<System.Windows.Controls.TextBox>
            {
                PPS,
                DPS,
                TPS,
                PPP,
                DPP,
                TPP
            };

            SetTextBoxes();

            DataContext = _verbe;
        }

        private void MoveToTheNextTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Down)
            {
                int index = _textBoxes.FindIndex(tb => tb.Name == ((FrameworkElement)sender).Name) + 1;

                if (index < _textBoxes.Count())
                {
                    _textBoxes[index].Focus();
                }
                else
                {
                    ModifyVerb_OnClick(this, new RoutedEventArgs());
                }
            }

            if (e.Key == Key.Up || e.Key == Key.Back)
            {
                if (e.Key == Key.Back && (((FrameworkElement)sender) as System.Windows.Controls.TextBox).Text != "")
                {
                    return;
                }

                int index = _textBoxes.FindIndex(tb => tb.Name == ((FrameworkElement)sender).Name) - 1;

                if (index >= 0)
                {
                    _textBoxes[index].Focus();
                }
                else
                {
                    return;
                }
            }
        }

        private void SetTextBoxes()
        {
            Name.Text = _verbe.Name;
            Temps.Text = _verbe.Temps;

            foreach(ConjuguatedForm cf in _verbe.ConjuguatedForms)
            {
                _textBoxes[cf.Personne - 1].Text = cf.VerbeConjugué;
            }

        }

        private void ModifyVerb_OnClick(object sender, RoutedEventArgs e)
        {
            _verbe.ConjuguatedForms = new List<ConjuguatedForm>();

            _verbe.Name = Name.Text;
            _verbe.Temps = Temps.Text;

            foreach (TextBox textBox in _textBoxes)
            {
                if(textBox.Text == "")
                {
                    continue;
                }

                _verbe.ConjuguatedForms.Add(new ConjuguatedForm(_textBoxes.IndexOf(textBox) + 1, textBox.Text));
            }

            Close();
        }
    }
}
