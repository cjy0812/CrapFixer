using Microsoft.Win32;
using System;
using CrapFixer;
using System.Threading.Tasks;

namespace Settings.Personalization
{
    internal class Transparency : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        private const string valueName = "EnableTransparency";
        private const int recommendedValue = 0;

        public override string GetFeatureDetails()
        {
            return L("GetFeatureDetails", "{0} | Value: {1} | Suggestion: {2} (No transparency – smoother performance, still stylish)", keyName, valueName, recommendedValue);
        }


        public override string ID()
        {
            return L("ID", "Disable Transparency Effects");
        }

        public override string Info()
        {
            return L("Info", "This feature disables transparency effects for Start menu, taskbar, and other surfaces.");
        }

        public override Task<bool> CheckFeature()
        {
            return Task.FromResult(
                   Utils.IntEquals(keyName, valueName, recommendedValue)
             );
        }

        public override Task<bool> DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, RegistryValueKind.DWord);
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Logger.Log("Error in DisableTransparency: " + ex.Message, LogLevel.Error);
            }

            return Task.FromResult(false);
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 1, RegistryValueKind.DWord);
                return true;
            }
            catch (Exception ex)
            {
                Logger.Log("Error in DisableTransparency (Undo): " + ex.Message, LogLevel.Error);
            }

            return false;
        }
    }
}
