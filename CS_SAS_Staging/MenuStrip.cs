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
      // "File" section of toolstrip
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
        public static void LusrMgr()
        {
            Process.Start("lusrmgr.msc");
        }
        public static void ControlUpdate()
        {
            Process.Start("Control Update");
        }
        public static void GpEdit()
        {
            Process.Start("gpedit.msc");
        }
        public static void DiskMgmt()
        {
            Process.Start("diskmgmt.msc");
        }
        public static void EventViewer()
        {
            Process.Start("eventvwr.exe");
        }
        public static void PerfMon()
        {
            Process.Start("perfmon.exe");
        }
        public static void DevMgmt()
        {
            Process.Start("devmgmt.msc");
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
