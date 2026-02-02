using CFixer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace CFixer.Views
{
    public partial class SettingsView : UserControl
    {
        private bool _isLoading;
        private List<LanguageOption> _languageOptions;

        private sealed class LanguageOption
        {
            public LanguageOption(string displayName, string cultureName)
            {
                DisplayName = displayName;
                CultureName = cultureName;
            }

            public string DisplayName { get; }
            public string CultureName { get; }

            public override string ToString()
            {
                return DisplayName;
            }
        }

        public SettingsView()
        {
            InitializeComponent();
            InitializeLanguageOptions();
            LoadSettings();
            CheckIfIconsInstalled();
        }

        /// <summary>
        /// Collects and saves all relevant checkbox settings to the INI file.
        /// </summary>
        public void SaveSettings()
        {
            var settings = new Dictionary<string, bool>
    {
        { nameof(checkSaveToINI), checkSaveToINI.Checked },
    };

            IniStateManager.SaveViewSettings("SETTINGS", settings);

            if (comboLanguage.SelectedItem is LanguageOption option)
            {
                LocalizationManager.SaveLanguage(option.CultureName);
            }
        }

        /// <summary>
        /// Loads checkbox settings from the INI file and applies them to the view.
        /// </summary>
        public void LoadSettings()
        {
            _isLoading = true;
            var settings = IniStateManager.LoadViewSettings("SETTINGS");
            checkSaveToINI.Checked = settings.GetValueOrDefault(nameof(checkSaveToINI), false);

            var savedLanguage = LocalizationManager.GetSavedLanguage() ?? string.Empty;
            var selectedOption = _languageOptions.FirstOrDefault(option =>
                string.Equals(option.CultureName, savedLanguage, StringComparison.OrdinalIgnoreCase));

            comboLanguage.SelectedItem = selectedOption ?? _languageOptions.FirstOrDefault();
            _isLoading = false;
        }

        private void SettingsView_Leave(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void CheckIfIconsInstalled()
        {
            string iconFolder = Path.Combine(Application.StartupPath, "icons");
            string[] requiredIcons = { "fixer.png", "options.png", "restore.png" };

            bool allIconsExist = requiredIcons.All(icon => File.Exists(Path.Combine(iconFolder, icon)));

            checkInstallIcons.Enabled = !allIconsExist;
        }

        private async void checkInstallIcons_CheckedChanged(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
            Properties.Resources.ResourceManager.GetString("SettingsView.IconsPackPrompt"),
                                    Properties.Resources.ResourceManager.GetString("SettingsView.IconsPackDetectedTitle"),
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information
                                    );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string iconFolder = Path.Combine(Application.StartupPath, "icons");
                    if (!Directory.Exists(iconFolder))
                        Directory.CreateDirectory(iconFolder);

                    string[] iconFiles = new string[]
                    {
                "fixer.png",
                "options.png",
                "restore.png"
                    };

                    string baseUrl = "https://raw.githubusercontent.com/builtbybel/CrapFixer/main/icons/";

                    using (var wc = new WebClient())
                    {
                        foreach (string fileName in iconFiles)
                        {
                            string url = baseUrl + fileName;
                            string localPath = Path.Combine(iconFolder, fileName);
                            await wc.DownloadFileTaskAsync(new Uri(url), localPath);
                        }
                    }

                    MessageBox.Show(
                        Properties.Resources.ResourceManager.GetString("SettingsView.IconsInstalled"),
                        Properties.Resources.ResourceManager.GetString("SettingsView.IconsInstalledTitle"),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Restart the application to apply changes
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(Properties.Resources.ResourceManager.GetString("SettingsView.IconsDownloadError"), ex.Message),
                        Properties.Resources.ResourceManager.GetString("SettingsView.DownloadFailedTitle"),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void InitializeLanguageOptions()
        {
            _languageOptions = new List<LanguageOption>
            {
                new LanguageOption(Properties.Resources.ResourceManager.GetString("SettingsView.Language.System"), string.Empty),
                new LanguageOption(Properties.Resources.ResourceManager.GetString("SettingsView.Language.English"), "en-US"),
                new LanguageOption(Properties.Resources.ResourceManager.GetString("SettingsView.Language.ChineseSimplified"), "zh-CN")
            };

            comboLanguage.Items.Clear();
            comboLanguage.Items.AddRange(_languageOptions.Cast<object>().ToArray());
        }

        private void comboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            if (comboLanguage.SelectedItem is LanguageOption option)
            {
                LocalizationManager.SaveLanguage(option.CultureName);
                LocalizationManager.ApplyLanguage(option.CultureName);

                var result = MessageBox.Show(
                    Properties.Resources.ResourceManager.GetString("SettingsView.LanguageRestartPrompt"),
                    Properties.Resources.ResourceManager.GetString("SettingsView.LanguageRestartTitle"),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }
    }
}
