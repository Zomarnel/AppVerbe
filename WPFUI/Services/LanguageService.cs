using System;
using System.Windows;

namespace WPFUI
{
    public static class LanguageService
    {
        public static string LastUsedLanguage = "en";

        public static void ChangeLanguage(System.Windows.Window window, string language)
        {
            LastUsedLanguage = language;

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

        public static string Translate(string phrase, string language)
        {
            LastUsedLanguage = language;

            ResourceDictionary resourceDictionary = new ResourceDictionary();

            resourceDictionary.Source = new Uri("..\\Resources/Resources." + $"{language}" + ".xaml", UriKind.Relative);

            try
            {
                return (string)resourceDictionary[phrase];
            }catch
            {
                throw new NotImplementedException($"Bruh {phrase} cannot be translated!!!");
            }
        }
    }
}
