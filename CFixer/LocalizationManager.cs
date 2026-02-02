using CFixer.Properties;
using System;
using System.Globalization;
using System.Threading;

namespace CFixer
{
    public static class LocalizationManager
    {
        private const string SettingsSection = "APP";
        private const string LanguageKey = "Language";

        public static string GetSavedLanguage()
        {
            return IniStateManager.LoadSetting(SettingsSection, LanguageKey);
        }

        public static void SaveLanguage(string cultureName)
        {
            IniStateManager.SaveSetting(SettingsSection, LanguageKey, cultureName ?? string.Empty);
        }

        public static void ApplySavedLanguage()
        {
            var cultureName = GetSavedLanguage();
            ApplyLanguage(cultureName);
        }

        public static void ApplyLanguage(string cultureName)
        {
            if (string.IsNullOrWhiteSpace(cultureName))
            {
                Resources.Culture = null;
                Thread.CurrentThread.CurrentUICulture = CultureInfo.InstalledUICulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CurrentCulture;
                return;
            }

            var culture = new CultureInfo(cultureName);
            Resources.Culture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
        }
    }
}
