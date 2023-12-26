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
        public delegate void Logger(string message);
        private readonly Logger _logger;
        public PowerCfgUtility(Logger logger)
        {
            _logger = logger;
        }
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
            Regex regex = new Regex(settingName + @"[\s\S]*?Current AC Power Setting Index:\s*(?<value>0x[0-9A-Fa-f]+)");
            Match match = regex.Match(output);

            if (match.Success)
            {
                string hexValue = match.Groups["value"].Value.Trim();

                try
                {
                    int seconds = Convert.ToInt32(hexValue, 16);  // Parsing the hexadecimal value
                    if (seconds == 0)
                    {
                        return "Never";
                    }
                    return ConvertSecondsToFriendlyDuration(seconds);
                }
                catch (FormatException ex)
                {
                    _logger?.Invoke($"FormatException: Unable to parse '{hexValue}'. Error: {ex.Message}");
                    return "Error: Parsing Failed";
                }
            }
            else
            {
                return "Error: No Data";
            }
        }
        private string ConvertSecondsToFriendlyDuration(int seconds)
        {
            if (seconds == 0)
            {
                return "Never";
            }

            TimeSpan time = TimeSpan.FromSeconds(seconds);

            if (time.TotalHours >= 1)
            {
                return $"{time.Hours} Hour{(time.Hours > 1 ? "s" : "")}";
            }
            else if (time.TotalMinutes >= 1)
            {
                return $"{time.Minutes} Minute{(time.Minutes > 1 ? "s" : "")}";
            }
            else
            {
                return $"{time.Seconds} Second{(time.Seconds > 1 ? "s" : "")}";
            }
        }
    }
}
