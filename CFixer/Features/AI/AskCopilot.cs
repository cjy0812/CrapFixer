using Microsoft.Win32;
using System;
using CrapFixer;
using System.Threading.Tasks;

namespace Settings.AI
{
    internal class AskCopilot : FeatureBase
    {
        private const string keyPath = @"Software\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked";
        private const string fullKeyPath = @"HKEY_CURRENT_USER\" + keyPath;
        private const string valueName = "{CB3B0003-8088-4EDE-8769-8B354AB2FF8C}";
        private const string displayValue = "Ask Copilot";

        public override string GetFeatureDetails()
        {
            return L("GetFeatureDetails", "{0} | Value: {1} = \"{2}\" | Blocks Copilot context menu entry.", fullKeyPath, valueName, displayValue);
        }

        public override string ID()
        {
            return L("ID", "Remove Ask Copilot from context menu");
        }

        public override string Info()
        {
            return L("Info", "Blocks the 'Ask Copilot' entry in the Windows 11 context menu by disabling its Shell Extension.");
        }

        public override Task<bool> CheckFeature()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath))
            {
                if (key == null) return Task.FromResult(false);
                object value = key.GetValue(valueName);
                return Task.FromResult(value != null && value.ToString() == displayValue);
            }
        }

        public override Task<bool> DoFeature()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(keyPath))
                {
                    key.SetValue(valueName, displayValue, RegistryValueKind.String);
                }

                Logger.Log("'Ask Copilot' context menu entry has been blocked.", LogLevel.Info);
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Logger.Log("Error blocking Copilot context menu: " + ex.Message, LogLevel.Error);
                return Task.FromResult(false);
            }
        }

        public override bool UndoFeature()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, writable: true))
                {
                    key?.DeleteValue(valueName, false);
                }

                Logger.Log("'Ask Copilot' context menu entry has been restored.", LogLevel.Info);
                return true;
            }
            catch (Exception ex)
            {
                Logger.Log("Error restoring Copilot context menu: " + ex.Message, LogLevel.Error);
                return false;
            }
        }
    }
}
