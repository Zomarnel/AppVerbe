using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Input;
using AppVerbe.ViewModels;
using AppVerbe.Models;

namespace WPFUI
{
    public partial class AddVerbWindow : Window
    {
        private AppSession _appSession = new AppSession();
        public AddVerbWindow(AppSession appSession)
        {
            InitializeComponent();

            _appSession = appSession;

            DataContext = _appSession;
        }
        private void AddVerb_OnClick(object sender, RoutedEventArgs e)
        {
            if(CheckIfTheTextBoxesHaveAnyValue() && Name.Text != "")
            {
                AddVerb();
                Close();
            }else
            {
                MessageBox.Show("Gotta put atleast a name and a conjuguated form, bro.");
            }
            
        }
        private void ResetCurrentVerb_OnClick(object sender, RoutedEventArgs e)
        {
            Name.Text = "";
            PPS.Text = "";
            DPS.Text = "";
            TPS.Text = "";
            PPP.Text = "";
            DPP.Text = "";
            TPP.Text = "";
        }
        private bool CheckIfTheTextBoxesHaveAnyValue()
        {
            string information = PPS.Text + DPS.Text + TPS.Text + PPP.Text + DPP.Text + TPP.Text;

            if(information == "")
            {
                return false;
            }

            return true;
        }
        private void AddVerb()
        {
            List<ConjuguatedForm> conjuguatedForms = new List<ConjuguatedForm>();

            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        AddConjuguatedFormToCurrentList(conjuguatedForms, 1, PPS.Text);
                        break;
                    case 1:
                        AddConjuguatedFormToCurrentList(conjuguatedForms, 2, DPS.Text);
                        break;
                    case 2:
                        AddConjuguatedFormToCurrentList(conjuguatedForms, 3, TPS.Text);
                        break;
                    case 3:
                        AddConjuguatedFormToCurrentList(conjuguatedForms, 4, PPP.Text);
                        break;
                    case 4:
                        AddConjuguatedFormToCurrentList(conjuguatedForms, 5, DPP.Text);
                        break;
                    case 5:
                        AddConjuguatedFormToCurrentList(conjuguatedForms, 6, TPP.Text);
                        break;
                    default:
                        throw new FormatException("Could not find it bro.");
                }
            }

            Verbe verbe = new Verbe(Name.Text, conjuguatedForms);

            _appSession.AppData.Verbes.Add(verbe);
        }
        private void AddConjuguatedFormToCurrentList(List<ConjuguatedForm> conjuguatedForms, int personne, string text)
        {
            if(text != "")
            {
                conjuguatedForms.Add(new ConjuguatedForm(personne, text));
            }
        }

        private void MoveToTheNextTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                switch(((FrameworkElement)sender).Name)
                {
                    case "Name":
                        PPS.Focus();
                        break;
                    case "PPS":
                        DPS.Focus();
                        break;
                    case "DPS":
                        TPS.Focus();
                        break;
                    case "TPS":
                        PPP.Focus();
                        break;
                    case "PPP":
                        DPP.Focus();
                        break;
                    case "DPP":
                        TPP.Focus();
                        break;
                    default:
                        throw new FormatException("Bruh could not find key input, gotta go bald.");
                }
            }
        }
    }
}
