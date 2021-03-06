using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System;
using System.Linq;
using AppVerbe.Models;
using AppVerbe.ViewModels;

namespace WPFUI
{
    public partial class RandomVerbWindow : System.Windows.Window
    {
        #region Properties
        private Verbe _verbe;

        private List<Verbe> _verbes;

        private AppSession _appSession;

        private VerbeResults _finalResults = new VerbeResults();

        private List<System.Windows.Controls.TextBox> textBoxes;

        private List<System.Windows.Controls.Label> labels;

        #endregion Properties

        public RandomVerbWindow(AppSession appSession)
        {
            InitializeComponent();

            _verbes = appSession.AppData.CloneVerbs();

            _appSession = appSession;

            LanguageService.ChangeLanguage(this, _appSession.AppData.App_Language);

            textBoxes = new List<System.Windows.Controls.TextBox>
            {
                PPS,
                DPS,
                TPS,
                PPP,
                DPP,
                TPP
            };

            labels = new List<System.Windows.Controls.Label>
            {
                LBPPS,
                LBDPS,
                LBTPS,
                LBPPP,
                LBDPP,
                LBTPP
            };

            GetNewVerb();

            DataContext = _verbe;

            textBoxes.First(tb => tb.Visibility == Visibility.Visible).Focus();
        }

        private void MoveToTheNextTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            List<int> indexes = new List<int>();

            // Find index of the textbox sender
            int index = textBoxes.FindIndex(tb => tb.Name == ((FrameworkElement)sender).Name);

            // Find all indexes of visible textboxes
            foreach (System.Windows.Controls.TextBox tb in textBoxes.Where(tb => tb.Visibility == Visibility.Visible))
            {
                indexes.Add(textBoxes.IndexOf(tb));
            }

            if (e.Key == Key.Enter || e.Key == Key.Down)
            {
                // Iterations through the indexes in search of a greater index than the sender
                foreach(int i in indexes)
                {
                    if(i > index)
                    {
                        textBoxes[i].Focus();
                        return;
                    }
                }

                // If no greater value than validate
                ValidateVerbes(this, new RoutedEventArgs());

                PPS.Focus();
            }

            if(e.Key == Key.Up || e.Key == Key.Back)
            {
                if (e.Key == Key.Back && (((FrameworkElement)sender) as System.Windows.Controls.TextBox).Text != "")
                {
                    return;
                }

                for (int i = index-1; i >= 0; i--)
                {
                    if(indexes.Contains(i))
                    {
                        textBoxes[i].Focus();
                        return;
                    }
                }
            }
        }

        private void ValidateVerbes(object sender, RoutedEventArgs e)
        {
            if (_verbe.ConjuguatedForms.All(cf => cf.VerbeConjugué == textBoxes[cf.Personne - 1].Text))
            {
                if (!_finalResults.Results.Any(r => r.Verbe == _verbe))
                {
                    _finalResults.Results.Add(new VerbeResult(_verbe, true));
                }

                GetNewVerb();
            }
            else
            {
                if (!_finalResults.Results.Any(r => r.Verbe == _verbe))
                {
                    _finalResults.Results.Add(new VerbeResult(_verbe, false));
                }

                GetNewVerb();
            }
        }

        private void GetNewVerb()
        {
            Random random = new Random();

            if(_verbe != null)
            {
                _verbes.Remove(_verbe);
            }

            if (_verbes.Any())
            {
                _verbe = _verbes[random.Next(_verbes.Count())];

                DataContext = _verbe;
            }else
            {
                MessageBroker.CreateNewMessage(this, "You_Did_It!", _appSession.AppData.App_Language);

                ResultsWindow resultsWindow = new ResultsWindow(_finalResults, _appSession.AppData.App_Language);

                resultsWindow.Owner = this;


                resultsWindow.ShowDialog();

                Close();
            }

            textBoxes.ConvertAll(tb => tb.Text = "");

            ChangeVisibility();
        }

        private void ChangeVisibility()
        {
            textBoxes.ConvertAll(tb => tb.Visibility = Visibility.Collapsed);
            labels.ConvertAll(lb => lb.Visibility = Visibility.Collapsed);

            foreach (ConjuguatedForm cf in _verbe.ConjuguatedForms)
            {
                textBoxes[cf.Personne - 1].Visibility = Visibility.Visible;
                labels[cf.Personne - 1].Visibility = Visibility.Visible;
            }
        }
    }
}
