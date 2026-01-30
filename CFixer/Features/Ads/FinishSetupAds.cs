using Microsoft.Win32;
using System;
using CrapFixer;
using System.Threading.Tasks;

namespace Settings.Ads
{
    internal class FinishSetupAds : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\UserProfileEngagement";
        private const string valueName = "ScoobeSystemSettingEnabled";
        private const int recommendedValue = 0;

        public override string ID()
        {
            return L("ID", "Disable Finish Setup Ads");
        }

        public override string Info()
        {
            return L("Info", "This feature will disable the \"Lets finish setting up your device\" and other advertising.");
        }

n        public override string GetFeatureDetails()
        {
            return L("GetFeatureDetails", "{0} | Value: {1} | Recommended Value: {2}", keyName, valueName, recommendedValue);
        }

        public override Task<bool> CheckFeature()
        {
            return
                Task.FromResult(Utils.IntEquals(keyName, valueName, 0));
        }

        public override Task<bool> DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, valueName, 1, Microsoft.Win32.RegistryValueKind.DWord);

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