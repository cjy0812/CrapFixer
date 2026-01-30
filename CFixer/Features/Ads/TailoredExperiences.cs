using Microsoft.Win32;
using System;
using CrapFixer;
using System.Threading.Tasks;

namespace Settings.Ads
{
    internal class TailoredExperiences : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Privacy";
        private const string valueName = "TailoredExperiencesWithDiagnosticDataEnabled";
        private const int recommendedValue = 0;

        public override string GetFeatureDetails()
        {
            return L("GetFeatureDetails", "{0} | Value: {1} | Recommended Value: {2}", keyName, valueName, recommendedValue);
        }

        public override string ID()
        {
            return L("ID", "Disable Tailored experiences");
        }

        public override string Info()
        {
            return L("Info", "Tailored Experiences allows Microsoft to get information from you to deliver personalized tips, ads, and recommendations. Many people would call this telemetry, or even spying.");
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
                Logger.Log("Code red in " + ex.Message, LogLevel.Error);
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
                Logger.Log("Code red in " + ex.Message, LogLevel.Error);
            }

            return false;
        }
    }
}