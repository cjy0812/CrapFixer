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
        public SettingsView()
        {
            InitializeComponent();
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
        }

        /// <summary>
        /// Loads checkbox settings from the INI file and applies them to the view.
        /// </summary>
        public void LoadSettings()
        {
            var settings = IniStateManager.LoadViewSettings("SETTINGS");
            checkSaveToINI.Checked = settings.GetValueOrDefault(nameof(checkSaveToINI), false);
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
    }
}