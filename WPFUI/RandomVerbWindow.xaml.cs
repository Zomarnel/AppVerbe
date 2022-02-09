using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System;
using System.Linq;
using AppVerbe.Models;

namespace WPFUI
{
    public partial class RandomVerbWindow : Window
    {
        private Verbe _verbe;

        private List<Verbe> _verbes;

        private List<System.Windows.Controls.TextBox> textBoxes;

        private List<System.Windows.Controls.Label> labels;

        private Random _random = new Random();

        private List<Verbe> _usedVerbes = new List<Verbe>();
        public RandomVerbWindow(List<Verbe> verbes)
        {
            InitializeComponent();

            _verbes = verbes;

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
        }
        private void MoveToTheNextTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                int index = textBoxes.FindIndex(tb => tb.Name == ((FrameworkElement)sender).Name) + 1;
                if(index >= textBoxes.Count())
                {
                    ValidateVerbes(this, new RoutedEventArgs());

                    PPS.Focus();
                }else
                {
                    textBoxes[index].Focus();
                }
            }
        }
        private void ValidateVerbes(object sender, RoutedEventArgs e)
        {

            string inputs = "";

            string allVerbes = "";

            foreach (System.Windows.Controls.TextBox tb in textBoxes)
            {
                inputs += tb.Text;
            }

            foreach(ConjuguatedForm cf in _verbe.ConjuguatedForms)
            {
                allVerbes += cf.VerbeConjugué;
            }

            if(inputs == allVerbes)
            {

                MessageBox.Show("Correct!");

                GetNewVerb();
            }else
            {
                MessageBox.Show("Incorrect! Dumbass.");
            }
        }
        private void GetNewVerb()
        {   
            if(_verbe != null)
            {
                _usedVerbes.Add(_verbe);
            }

            if (_usedVerbes.Count() != _verbes.Count())
            {
                _verbe = null;

                while(_verbe == null)
                {
                    Verbe verbe = _verbes[_random.Next(_verbes.Count())];

                    if(_usedVerbes.Count() == 0)
                    {
                        _verbe = verbe;
                        break;
                    }

                    if (!_usedVerbes.Contains(verbe) && _usedVerbes.Last() != verbe)
                    {
                        _verbe = verbe;
                    }
                } 

                DataContext = _verbe;
            }else
            {
                MessageBox.Show("You did it!");

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
