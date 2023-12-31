﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CS_SAS_Staging
{
    internal class CheckRemoteAccess
    {
        public static async Task CheckRDPStatusAsync(Label rdpStatusLabel)
        {
            await Task.Run(() =>
            {
                string command = "powershell -Command \"if ((Get-ItemProperty 'hklm:\\System\\CurrentControlSet\\Control\\Terminal Server').fDenyTSConnections -eq 0) { write-host 'enabled' } else { write-host 'disabled' }\"";
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + command,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    rdpStatusLabel.Invoke(new Action(() =>
                    {
                        if (output.Trim().Equals("enabled", StringComparison.OrdinalIgnoreCase))
                        {
                            rdpStatusLabel.Text = "RDP Active";
                            rdpStatusLabel.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            rdpStatusLabel.Text = "RDP Inactive";
                            rdpStatusLabel.ForeColor = System.Drawing.Color.Red;
                        }
                    }));
                }
            });
        }
        public static async Task ChgRemoteAccessAsync(bool enableRDP, Logger logger)
        {
            string value = enableRDP ? "0" : "1"; // 0 to enable RDP, 1 to disable
            string command = $"reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Terminal Server\" /v fDenyTSConnections /t REG_DWORD /d {value} /f";

            await Task.Run(() =>
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + command,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (!string.IsNullOrEmpty(error))
                    {
                        logger?.Invoke($"Error changing RDP setting: {error}");
                    }
                    else
                    {
                        string status = enableRDP ? "enabled" : "disabled";
                        logger?.Invoke($"Remote Access: RDP successfully {status}.\n");
                    }
                }
            });
        }

        public delegate void Logger(string message);
    }
}


