using System;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace OSHelper
{
    internal class OSHelper
    {
        public static async Task<string> GetWindowsVersion()
        {
            return await Task.Run(() =>
            {
                try
                {
                    using (PowerShell ps = PowerShell.Create())
                    {
                        ps.AddScript("Get-CimInstance -ClassName Win32_OperatingSystem");
                        var results = ps.Invoke();

                        foreach (var result in results)
                        {
                            if (result == null) continue;

                            string caption = result.Properties["Caption"]?.Value?.ToString();
                            string version = result.Properties["Version"]?.Value?.ToString();
                            string build = result.Properties["BuildNumber"]?.Value?.ToString();

                            string displayVersion = Registry.GetValue(
                                @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion",
                                "DisplayVersion", "")?.ToString();

                            // UBR = Update Build Revision
                            string ubr = Registry.GetValue(
                                @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion",
                                "UBR", 0)?.ToString();

                            bool isInsider = false;
                            string ring = null;

                            using (var insiderKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\UpdateOrchestrator"))
                            {
                                if (insiderKey != null)
                                {
                                    object enabled = insiderKey.GetValue("EnableInsiderBuilds");
                                    if (enabled != null && Convert.ToInt32(enabled) == 1)
                                    {
                                        isInsider = true;
                                        ring = insiderKey.GetValue("Ring")?.ToString();
                                    }
                                }
                            }

                            string osName = caption?.Contains("Windows 11") == true ? "Windows 11" :
                                            caption?.Contains("Windows 10") == true ? "Windows 10" :
                                            caption ?? "Unknown OS";

                            string fullBuild = !string.IsNullOrEmpty(build) && !string.IsNullOrEmpty(ubr)
                                ? $"{build}.{ubr}"
                                : build ?? "unknown";

                            string insiderInfo = isInsider ? $" (Insider: {ring})" : "";

                            return $"{osName} {displayVersion}{insiderInfo} (Build {fullBuild})";
                        }
                    }
                }
                catch (Exception ex)
                {
                    return string.Format(Properties.Resources.ResourceManager.GetString("OSHelper.OsInfoUnavailable"), ex.Message);
                }

                return Properties.Resources.ResourceManager.GetString("OSHelper.OsNotSupported");
            });
        }
    }
}