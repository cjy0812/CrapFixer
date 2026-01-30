using Microsoft.Win32;
using System;
using System.Threading.Tasks;
using CrapFixer;

namespace Settings.UI
{
    /// <summary>
    /// Disables the Click to Do feature, which also removes its entry from the right-click context menu.
    /// Only available on Copilot+ PCs running Windows 11 24H2 or newer.
    /// Requires a PC with an NPU (Neural Processing Unit).
    /// </summary>
    internal class ClickToDo: FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\Shell\ClickToDo";
        private const string valueName = "DisableClickToDo";
        private const int recommendedValue = 1; // 1 = fully disabled, including context menu

        public override string GetFeatureDetails()
        {
            return L("GetFeatureDetails", "{0} | Value: {1} | Set to: {2} (disables Click to Do, removing it from context menus). \r\nNote: This setting only applies on Copilot+ PCs with Windows 11 24H2 or newer.", keyName, valueName, recommendedValue);
        }



        public override string ID()
        {
            return L("ID", "Disable Click to Do (Only Copilot+ PCs)");
        }

        public override string Info()
        {
            return L("Info", "Disables Click to Do entirely, including its context menu entry which uses on-device AI to suggest actions based on screen content. Only available on Copilot+ PCs with Windows 11 24H2 or newer.");
        }

        public override Task<bool> CheckFeature()
        {
            return Task.FromResult(Utils.IntEquals(keyName, valueName, recommendedValue));
        }

        public override Task<bool> DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, recommendedValue, RegistryValueKind.DWord);
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Logger.Log("Error disabling Click to Do: " + ex.Message, LogLevel.Error);
                return Task.FromResult(false);
            }
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, RegistryValueKind.DWord);
                return true;
            }
            catch (Exception ex)
            {
                Logger.Log("Error re-enabling Click to Do: " + ex.Message, LogLevel.Error);
                return false;
            }
        }
    }
}