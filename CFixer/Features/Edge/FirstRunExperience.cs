using Microsoft.Win32;
using System;
using CrapFixer;
using System.Threading.Tasks;

namespace Settings.Edge
{
    public class FirstRunExperience : FeatureBase
    {
        private const string keyName = @"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Edge";
        private const string valueName = "HideFirstRunExperience";
        private const int recommendedValue = 1;

        public override string GetFeatureDetails()
        {
            return L("GetFeatureDetails", "{0} | Value: {1} | Recommended Value: {2}", keyName, valueName, recommendedValue);
        }

        public override string ID()
        {
            return L("ID", "Don't Show First Run Experience");
        }

        public override string Info()
        {
            return L("Info", "Hide home screen and 'Getting Started' on initial launch (from version 80 onwards)");
        }

        public override Task<bool> CheckFeature()
        {
            return Task.FromResult(Utils.IntEquals(keyName, valueName, recommendedValue));
        }

        public override Task<bool> DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 1, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, valueName, 0, Microsoft.Win32.RegistryValueKind.DWord);

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