using Microsoft.Win32;
using System;
using CrapFixer;
using System.Threading.Tasks;

namespace Settings.System
{
    internal class MenuShowDelay : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Control Panel\Desktop";
        private const string valueName = "MenuShowDelay";
        private const string recommendedValue = "10";

        public override string GetFeatureDetails()
        {
            return L("GetFeatureDetails", "{0} | Value: {1} | Recommended Value: \"{2}\" (faster menu response)", keyName, valueName, recommendedValue);
        }

        public override string ID()
        {
            return L("ID", "Speed Up Menu Show Delay");
        }

        public override string Info()
        {
            return L("Info", "Speeds up the appearance of menus and submenus by lowering the default delay. This improves the perceived responsiveness of the UI.");
        }

        public override Task<bool> CheckFeature()
        {
            return Task.FromResult(Utils.StringEquals(keyName, valueName, recommendedValue));
        }

        public override Task<bool> DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, recommendedValue, RegistryValueKind.String);
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Logger.Log("Code red in " + ex.Message, LogLevel.Error);
            }

            return Task.FromResult(false);
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, "400", RegistryValueKind.String); // Default is 400 on Windows 11
                return true;
            }
            catch (Exception ex)
            {
                Logger.Log("Code red in " + ex.Message, LogLevel.Error);
            }

            return false;
        }
    }
}
