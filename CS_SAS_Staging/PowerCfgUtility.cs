using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CS_SAS_Staging
{
    internal class PowerCfgUtility
    {
        public string GetPowerSettings()
        {
            string activePowerScheme = GetActivePowerScheme();
            string screenTimeout = GetScreenTimeout();
            string sleepTimeout = GetSleepTimeout();

            var settings = new Dictionary<string, string>
            {
                { "Active Power Scheme", activePowerScheme },
                { "Screen Timeout", screenTimeout },
                { "Sleep Timeout", sleepTimeout }
            };

            return JsonConvert.SerializeObject(settings, Newtonsoft.Json.Formatting.Indented);
        }

        private string ExecutePowerCfgCommand(string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "powercfg",
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();

                StringBuilder output = new StringBuilder();
                while (!process.StandardOutput.EndOfStream)
                {
                    string line = process.StandardOutput.ReadLine();
                    output.AppendLine(line);
                }

                return output.ToString();
            }
        }

        private string GetActivePowerScheme()
        {
            string output = ExecutePowerCfgCommand("-getactivescheme");
            Regex regex = new Regex(@"Power Scheme GUID: .+  \((?<name>.+)\)");
            Match match = regex.Match(output);

            if (match.Success)
            {
                return match.Groups["name"].Value.Trim();
            }

            return "Error: Data Parse Failure";
        }

        private string GetScreenTimeout()
        {
            string output = ExecutePowerCfgCommand("-query SCHEME_CURRENT SUB_VIDEO VIDEOIDLE");
            return ParseSetting(output, "Power Setting GUID: 3c0bc021-c8a8-4e07-a973-6b14cbcb2b7e");
        }

        private string GetSleepTimeout()
        {
            string output = ExecutePowerCfgCommand("-query SCHEME_CURRENT SUB_SLEEP STANDBYIDLE");
            return ParseSetting(output, "Power Setting GUID: 29f6c1db-86da-48c5-9fdb-f2b67b1f44da");
        }

        private string ParseSetting(string output, string settingName)
        {
            // Adjust the regex to match the 'Current AC Power Setting Index' line
            Regex regex = new Regex(settingName + @"[\s\S]+?Current AC Power Setting Index: (?<value>\d+)");
            Match match = regex.Match(output);

            if (match.Success)
            {
                int seconds = int.Parse(match.Groups["value"].Value, System.Globalization.NumberStyles.HexNumber);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                return time.ToString(@"hh\:mm\:ss");
            }

            return "Error: Data Parse Failure";
        }
    }
}
