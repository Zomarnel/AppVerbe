using System;
using System.Windows;
using System.Collections.Generic;
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
        }
        private void AddVerb_OnClick(object sender, RoutedEventArgs e)
        {
            List<ConjuguatedForm> conjuguatedForms = new List<ConjuguatedForm>();

            for (int i = 0; i < 6; i++)
            {
                switch(i)
                {
                    case 0:
                        conjuguatedForms.Add(new ConjuguatedForm(1, PPS.Text));
                        break;
                    case 1:
                        conjuguatedForms.Add(new ConjuguatedForm(2, DPS.Text));
                        break;
                    case 2:
                        conjuguatedForms.Add(new ConjuguatedForm(3, TPS.Text));
                        break;
                    case 3:
                        conjuguatedForms.Add(new ConjuguatedForm(4, PPP.Text));
                        break;
                    case 4:
                        conjuguatedForms.Add(new ConjuguatedForm(5, DPP.Text));
                        break;
                    case 5:
                        conjuguatedForms.Add(new ConjuguatedForm(6, TPP.Text));
                        break;
                    default:
                        throw new FormatException("Could not find it bro.");
                }
            }

            Verbe verbe = new Verbe(Name.Text, conjuguatedForms);

            _appSession.AppData.Verbes.Add(verbe);
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
    }
}
