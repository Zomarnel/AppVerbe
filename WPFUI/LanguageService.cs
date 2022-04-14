using System;
using System.Windows;

namespace WPFUI
{
    public class LanguageService
    {
        public static void ChangeLanguage(System.Windows.Window window, string language)
        {
            ResourceDictionary resourceDictionary = new ResourceDictionary();

            switch (language)
            {
                case "en":
                    resourceDictionary.Source = new Uri("..\\Resources/Resources.en.xaml", UriKind.Relative);
                    break;
                case "fr":
                    resourceDictionary.Source = new Uri("..\\Resources/Resources.fr.xaml", UriKind.Relative);
                    break;
                case "de":
                    resourceDictionary.Source = new Uri("..\\Resources/Resources.de.xaml", UriKind.Relative);
                    break;
                default:
                    resourceDictionary.Source = new Uri("..\\Resources/Resources.en.xaml", UriKind.Relative);
                    break;
            }

            window.Resources.MergedDictionaries.Add(resourceDictionary);
        }
    }
}
