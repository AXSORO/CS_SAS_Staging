using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SAS_Staging
{
    internal class MenuStrip
    {
        public static void OpenMSCFile(string mscFileName)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "mmc.exe",
                Arguments = mscFileName,
                UseShellExecute = false
            };

            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                // For example, log the error message
                Console.WriteLine("Error launching MSC file: " + ex.Message);
            }
        }
        // Logic used to launch the settings that rely on MMC to run
        public static void OpenControlPanelSection(string controlPanelCommand)
        {
            try
            {
                Process.Start("control", controlPanelCommand);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"Error opening Control Panel section: {ex.Message}");
            }
        }
        // Logic used to launch the control panel-based toolstrip option(s)
        //
        // "File" section of toolstrip
        //
        public static void SaveReport()
        {

        }
      //
      // "Shell" section of toolstrip
      //
        public static void OpenPowershell()
        {
            Process.Start("powershell.exe");
        }
        public static void OpenCMD()
        {
            Process.Start("cmd.exe");
        }
      //
      // "Windows" section of toolstrip
      //
        public static void EventViewer()
        {
            Process.Start("eventvwr.exe");
        }
        public static void PerfMon()
        {
            Process.Start("perfmon.exe");
        }
        public static void MsConfig()
        {
            Process.Start("msconfig.exe");
        }
        //
        // "Help" section of toolstrip 
        //
        public static void HelpButton()
        {

        }
        
    }
}
