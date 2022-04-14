using System.Linq;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Input;
using AppVerbe.ViewModels;
using AppVerbe.Models;

namespace WPFUI
{
    public partial class AddVerbWindow : System.Windows.Window
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
                Temps,
                PPS,
                DPS,
                TPS,
                PPP,
                DPP,
                TPP
            };

            DataContext = _appSession;

            Name.Focus();

            LanguageService.ChangeLanguage(this, _appSession.AppData.App_Language);
        }

        #region Events

        private void AddVerb_OnClick(object sender, RoutedEventArgs e)
        {
            if(ValidateVerb())
            {
                AddVerb();

                ResetCurrentVerb_OnClick(this, new RoutedEventArgs());

                Name.Focus();

                MessageBroker.CreateNewMessage(this, "Successfully_added_a_verb_to_the_current_list!", _appSession.AppData.App_Language);
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

            if (e.Key == Key.Up || e.Key == Key.Back)
            {
                if(e.Key == Key.Back && (((FrameworkElement)sender) as System.Windows.Controls.TextBox).Text != "")
                {
                    return;
                }

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

        #endregion Events

        #region Functions
        private void AddVerb()
        {
            Verbe verbe = BuildVerb();

            _appSession.AppData.Verbes.Add(verbe);
        }

        private Verbe BuildVerb()
        {
            List<ConjuguatedForm> conjuguatedForms = new List<ConjuguatedForm>();

            for (int i = 2; i <= 7; i++)
            {

                if(textBoxes[i].Text != "")
                {
                    conjuguatedForms.Add(new ConjuguatedForm(i-1, textBoxes[i].Text));
                }
            }

            return new Verbe(Name.Text, Temps.Text, conjuguatedForms);
        }

        private bool ValidateVerb()
        {
            Verbe verbe = BuildVerb();

            if(Name.Text == "")
            {
                MessageBroker.CreateNewMessage(this, "Missing_Name", _appSession.AppData.App_Language);
                return false;
            }

            if (Temps.Text == "")
            {
                MessageBroker.CreateNewMessage(this, "Missing_Time", _appSession.AppData.App_Language);
                return false;
            }

            if (!textBoxes.Any(tb => tb != Name && tb.Text != "" && tb != Temps))
            {
                MessageBroker.CreateNewMessage(this, "Missing_Conjuguated_Form", _appSession.AppData.App_Language);
                return false;
            }

            if(_appSession.AppData.CheckIfVerbeInsideList(verbe))
            {
                MessageBroker.CreateNewMessage(this, "Verb_Already_Existing_In_Current_List", _appSession.AppData.App_Language);
                return false;
            }

            return true;
        }

        #endregion Functions
    }
}
