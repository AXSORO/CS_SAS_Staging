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
            Regex regex = new Regex(@"Power Scheme GUID: (?<guid>.+)  \(.*\)\s+Name: (?<name>.+)\s+", RegexOptions.Multiline);
            Match match = regex.Match(output);

            if (match.Success)
            {
                return $"{match.Groups["name"].Value.Trim()} (GUID: {match.Groups["guid"].Value.Trim()})";
            }

            return "N/A";
        }

        private string GetScreenTimeout()
        {
            string output = ExecutePowerCfgCommand("-query SCHEME_CURRENT SUB_VIDEO VIDEOIDLE"); // GUIDs may vary
            return ParseSetting(output, "VIDEOIDLE");
        }

        private string GetSleepTimeout()
        {
            string output = ExecutePowerCfgCommand("-query SCHEME_CURRENT SUB_SLEEP STANDBYIDLE"); // GUIDs may vary
            return ParseSetting(output, "STANDBYIDLE");
        }

        private string ParseSetting(string output, string settingName)
        {
            Regex regex = new Regex(settingName + @"\s+\(.*\)\s+\s+Power Setting Index: (?<value>\d+)", RegexOptions.Multiline);
            Match match = regex.Match(output);

            if (match.Success)
            {
                int seconds = int.Parse(match.Groups["value"].Value);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                return time.ToString(@"hh\:mm\:ss");
            }

            return "N/A";
        }
    }
}
