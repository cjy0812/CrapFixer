using Microsoft.Win32;
using System;
using CrapFixer;
using System.Threading.Tasks;

namespace Settings.System
{
    internal class BSODDetails : FeatureBase
    {
        private const string keyName = @"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\CrashControl";
        private const string valueName1 = "DisplayParameters";
        private const string valueName2 = "DisableEmoticon";
        private const int recommendedValue = 1;

        public override string GetFeatureDetails()
        {
            return L("GetFeatureDetails", "{0} | Values: {1}, {2} | Recommended Value: {3}", keyName, valueName1, valueName2, recommendedValue);
        }

        public override string ID()
        {
            return L("ID", "Show BSOD details instead of sad smiley");
        }

        public override string Info()
        {
            return L("Info", "This method displays the full classic BSOD with technical error details instead of the simplified sad face version.");
        }

        public override Task<bool> CheckFeature()
        {
            return Task.FromResult(
                Utils.IntEquals(keyName, valueName1, recommendedValue) &&
                Utils.IntEquals(keyName, valueName2, recommendedValue)
            );
        }

        public override Task<bool> DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName1, recommendedValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName, valueName2, recommendedValue, RegistryValueKind.DWord);
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
                Registry.SetValue(keyName, valueName1, 0, RegistryValueKind.DWord);
                Registry.SetValue(keyName, valueName2, 0, RegistryValueKind.DWord);
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
