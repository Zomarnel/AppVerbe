using System.Linq;
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

        private List<System.Windows.Controls.TextBox> textBoxes;
        public AddVerbWindow(AppSession appSession)
        {
            InitializeComponent();

            _appSession = appSession;

            textBoxes = new List<System.Windows.Controls.TextBox>
            {
                Name,
                PPS,
                DPS,
                TPS,
                PPP,
                DPP,
                TPP
            };

            DataContext = _appSession;
        }
        private void AddVerb_OnClick(object sender, RoutedEventArgs e)
        {
            if(textBoxes.Any(tb => tb != Name && tb.Text != "") && Name.Text != "")
            {
                AddVerb();

                ResetCurrentVerb_OnClick(this, new RoutedEventArgs());

                Name.Focus();

                MessageBroker.CreateNewMessage(this, "Successfully added a verb to the current list!");
            }else
            {
                MessageBroker.CreateNewMessage(this, "Gotta put atleast a name and a conjuguated form, bro.");
            }

        }
        private void ResetCurrentVerb_OnClick(object sender, RoutedEventArgs e)
        {
            textBoxes.ConvertAll(tb => tb.Text = "");
        }
        private void MoveToTheNextTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Down)
            {
                int index = textBoxes.FindIndex(tb => tb.Name == ((FrameworkElement)sender).Name)+1;
                
                if(index < textBoxes.Count())
                {
                    textBoxes[index].Focus();
                }else
                {
                    AddVerb_OnClick(this, new RoutedEventArgs());
                }
            }

            if (e.Key == Key.Up)
            {
                int index = textBoxes.FindIndex(tb => tb.Name == ((FrameworkElement)sender).Name)-1;

                if(index >= 0)
                {
                    textBoxes[index].Focus();
                }else
                {
                    return;
                }
            }
        }
        private void AddVerb()
        {
            List<ConjuguatedForm> conjuguatedForms = new List<ConjuguatedForm>();

            for (int i = 1; i < 7; i++)
            {
                conjuguatedForms.Add(new ConjuguatedForm(i, textBoxes[i].Text));
            }

            Verbe verbe = new Verbe(Name.Text, conjuguatedForms);

            _appSession.AppData.Verbes.Add(verbe);
        }
    }
}
