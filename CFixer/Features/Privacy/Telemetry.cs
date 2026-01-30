using Microsoft.Win32;
using System;
using CrapFixer;
using System.Threading.Tasks;

namespace Settings.Privacy
{
    public class Telemetry : FeatureBase
    {
        private const string dataCollection = @"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\DataCollection";
        private const string diagTrack = @"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\DiagTrack";

        public override string ID()
        {
            return L("ID", "Turn off Telemetry data collection");
        }

        public override string Info()
        {
            return L("Info", "This feature will turn off telemetry data collection and prevent the data from being sent to Microsoft.");
        }

        public override string GetFeatureDetails()
        {
            return L("GetFeatureDetails", "{0} | {1}", dataCollection, diagTrack);
        }

        public override Task<bool> CheckFeature()
        {
            return Task.FromResult(
               Utils.IntEquals(dataCollection, "AllowTelemetry", 0) &&
                Utils.IntEquals(diagTrack, "Start", 4)

           );
        }

        public override Task<bool> DoFeature()
        {
            try
            {
                Registry.SetValue(dataCollection, "AllowTelemetry", 0, RegistryValueKind.DWord);
                Registry.SetValue(diagTrack, "Start", 4, RegistryValueKind.DWord);
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
                Registry.SetValue(dataCollection, "AllowTelemetry", 1, RegistryValueKind.DWord);
                Registry.SetValue(diagTrack, "Start", 2, RegistryValueKind.DWord);

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