// Dependencies being called 
using System;
using System.Text; // assisting with StringBuilder for calling command line apps (batch)
using System.Collections.ObjectModel;
using System.Diagnostics; // Assisting with system management 
using System.Net.NetworkInformation; // Assisting with network information queries 
using System.Windows.Forms; // Calling for WinForms designer and assets
using NetFwTypeLib; // FirewallAPI for assistance of querying and grabbing info of the firewall 
using System.Collections.Generic; // Assisting with querying actions
using System.Net.Sockets; // Assisting with the querying of current networking information 
using Microsoft.VisualBasic.Devices; // Assisting with calling Batch/CMD commands
using System.Management; // Assisting with system changes 
using System.DirectoryServices; // Using directory services to pull local user accounts for display 
using System.DirectoryServices.AccountManagement; // Using account management services to pull more minute accounr details
using System.Runtime.InteropServices; // Assisting with system management cases
using Newtonsoft.Json; // Json extension for data management used by the PowerCfgUtility class
using static CS_SAS_Staging.NetworkAdapter; // This is calling a secondary class I created to help parsing of the Network Adapter information 
using static CS_SAS_Staging.PowerCfgUtility; // Another internal class made that helps collect and parse the data using powercfg - WMI is unreliable 

//Start main application
namespace CS_SAS_Staging
{
    public partial class Form1 : Form
    {   // Appplication init
        public Form1()
        {
            InitializeComponent();
            LogToCsLog("C# Logging Initialized\n");
            LogToCsLog("\n");
            Load += Form1_Load;

            // Display selected adapter below the listBox
            nwAdapt.SelectedIndexChanged += nwAdapt_SelectedIndexChanged; // Handling the event of changes in the networking listbox
        }
        // Log init - the text being displayed is for fun and for show
        private async void Form1_Load(object sender, EventArgs e)
        {
            // more useless but cool stuff to be put into the log 
            await Task.Delay(200);
            LogToCsLog("VisualBasic Scripting Initalized.\n");
            await Task.Delay(250);
            LogToCsLog("System.Diagnostics Library Loaded.\n");
            await Task.Delay(100);
            LogToCsLog("InteropServices Library Loaded.\n");
            await Task.Delay(250);
            LogToCsLog("System.Net.Sockets Library Loaded.\n");
            await Task.Delay(250);
            LogToCsLog("FirewallAPI Loaded.\n \n");
            await Task.Delay(250);
            LogToCsLog("Running Queries...\n");
            await Task.Delay(1000);
            LogToCsLog("Primary Queries Complete.\n");
            await Task.Delay(250);
            LogToCsLog("Starting application.");
            await Task.Delay(250);
            LogToCsLog(".");
            await Task.Delay(250);
            LogToCsLog(".\n");
            await Task.Delay(100);
            csLog.Clear();
            // Seperate function to run queries after launch, makes it open much faster
            RunQueries();
        }
        // Action for re-running queries when the associated button is clicked (resetQuery_Click action)
        private async void ReloadQueries()
        {
            csLog.Clear();
            LogToCsLog("Restarting Queries.");
            await Task.Delay(250);
            LogToCsLog(".");
            await Task.Delay(250);
            LogToCsLog(".\n");
            await Task.Delay(100);
            RunQueries();
        }
        // Run queries on hardware for main page
        private void RunQueries()
        {
            csLog.Clear();
            QueryMachineInfo();
            QueryNetworkAdapters();
            QueryFirewallStatus();
            QueryPowerSettings();
            QueryRDPSettings();
            QueryUsers();
        }
        // Action for pulling machine hostname and displaying it in appropriate label
        private void QueryMachineInfo()
        {
            try
            {

                // Query and display current machine hostname
                string hostname = System.Net.Dns.GetHostName();
                cHostName.Text = hostname;

                // Log the command and its output
                LogToCsLog($"Query: Machine Hostname\n");
            }
            catch (Exception ex)
            {
                // Handle exceptions and log errors
                LogToCsLog($"Error querying machine hostname: {ex.Message}\n");
            }
        }
        // Action for collecting local user information - asyncronized 
        private async Task<List<string>> GetUsersAsync()
        {
            List<string> users = new List<string>();

            try
            {
                // Set up the Directory Entry
                using (DirectoryEntry localMachine = new DirectoryEntry("WinNT://" + Environment.MachineName))
                {
                    // Iterate through the user entries
                    await Task.Run(() =>
                    {
                        foreach (DirectoryEntry user in localMachine.Children)
                        {
                            if (user.SchemaClassName == "User")
                            {
                                string username = user.Name;
                                users.Add(username);
                            }
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions or log errors
                csLog.AppendText($"Error querying user information: {ex.Message}\n");
            }

            // Simulate some delay to represent the query process

            return users;
        }
        // Function of parsing information grabbed from user query, avoiding application hangs while it runs
        private async void QueryUsers()
        {
            csLog.AppendText("Query: WinNT:// In Progress...\n");

            List<string> users = await GetUsersAsync();

            UpdateUserListBox(users);

            csLog.AppendText("Query: Userlist Complete.\n");
        }
        //Display users found from query in proper ListBox
        private void UpdateUserListBox(List<string> users)
        {
            // Clear existing items
            usrCollect.Items.Clear();

            // Add new items
            foreach (string user in users)
            {
                usrCollect.Items.Add(user);
            }
        }
        // Query network adapter information - display it in proper listbox
        private void QueryNetworkAdapters()
        {
            try
            {
                // Query and display all enabled and active network adapters
                NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

                foreach (NetworkInterface adapter in networkInterfaces)
                {
                    if (adapter.NetworkInterfaceType != NetworkInterfaceType.Loopback && adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        // Create a NetworkAdapter instance and populate its properties
                        NetworkAdapter networkAdapter = new NetworkAdapter
                        {
                            Name = adapter.Description,
                            ActName = adapter.Name, // Added to help support the NetSh commands, now the selected adapter internal name will display under the Textbox. 
                            IPAddress = GetFirstIPv4Address(adapter),
                            SubnetMask = GetSubnetMask(adapter),
                            DefaultGateway = GetDefaultGateway(adapter),
                            PrimaryDNS = GetPrimaryDNS(adapter),
                            SecondaryDNS = GetSecondaryDNS(adapter),
                        };

                        // Add the adapter instance to the "nwAdapt" listbox
                        nwAdapt.Items.Add(networkAdapter);

                        // Log the command and its output
                        LogToCsLog($"Query: Configuration for {adapter.Description}\n");
                    }
                }

                // Log the command and its output for the entire query
                LogToCsLog($"Query: Active Network Adapters\n");
            }
            catch (Exception ex)
            {
                // Handle exceptions and log errors
                LogToCsLog($"Error listing network adapters: {ex.Message} \n");
            }
        }
        // Firewall profile gathering 
        private (string Status, System.Drawing.Color StatusColor) QueryFirewallStatus(NET_FW_PROFILE_TYPE2_ profileType)
        {
            try
            {
                Type netFwMgrType = Type.GetTypeFromProgID("HNetCfg.FwMgr", false);
                dynamic fwMgr = Activator.CreateInstance(netFwMgrType);

                dynamic profile = fwMgr.LocalPolicy.CurrentProfile;
                bool isEnabled = profile.FirewallEnabled;

                // Determine the status and color based on the firewall status
                string status = isEnabled ? "Active" : "Disabled";
                System.Drawing.Color statusColor = isEnabled ? System.Drawing.Color.Green : System.Drawing.Color.Red;

                return (status, statusColor);
            }
            catch (Exception ex)
            {
                // Handle exceptions and log errors
                LogToCsLog($"Error querying firewall status: {ex.Message}");
                return ("Error", System.Drawing.Color.Red);
            }
        }
        // Querying info on the firewall status for all 3 profiles
        private void QueryFirewallStatus()
        {
            try
            {
                // Query and display Private network firewall status
                var privateFirewallStatus = QueryFirewallStatus(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE);
                pvFirewallStat.Text = privateFirewallStatus.Status;
                pvFirewallStat.ForeColor = privateFirewallStatus.StatusColor;
                LogToCsLog($"Query: Private firewall status\n");

                // Query and display Domain network firewall status
                var domainFirewallStatus = QueryFirewallStatus(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_DOMAIN);
                doFirewallStat.Text = domainFirewallStatus.Status;
                doFirewallStat.ForeColor = domainFirewallStatus.StatusColor;
                LogToCsLog($"Query: Domain firewall status\n");

                // Query and display Public network firewall status
                var publicFirewallStatus = QueryFirewallStatus(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PUBLIC);
                puFirewallStat.Text = publicFirewallStatus.Status;
                puFirewallStat.ForeColor = publicFirewallStatus.StatusColor;
                LogToCsLog($"Query: Public firewall status\n");
            }
            catch (Exception ex)
            {
                // Handle exceptions and log errors
                LogToCsLog($"Error querying firewall statuses: {ex.Message}");
            }
        }
        // Assistance with logging
        private async void QueryRDPSettings()
        {
            await CheckRemoteAccess.CheckRDPStatusAsync(rdpSetQuery);
            LogToCsLog("Query: RDP State returned.\n");
        }
        // Use CheckRemoteAccess class for checking state of RDP - then print to label
        private void LogToCsLog(string logText)
        {
            // Append the log text to the "csLog" rich text box
            csLog.AppendText($"{logText}");
            csLog.ScrollToCaret();
        }
        // Changing appropriate label and listed information when a new adapter is selected
        private void nwAdapt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected in the ListBox
            if (nwAdapt.SelectedItem != null)
            {
                // Ensure the selected item is of type NetworkAdapter
                if (nwAdapt.SelectedItem is NetworkAdapter selectedAdapter)
                {
                    // Update the "selAdapt" label with the selected adapter's name
                    selAdapt.Text = $"Internal Name: {selectedAdapter.ActName}";

                    // Display the adapter's information
                    DisplayAdapterInfo(selectedAdapter);
                }
            }
        }
        // Action for displaying the pre-stored adapter info, grabbed in the QueryNetworkAdapters function
        private void DisplayAdapterInfo(NetworkAdapter adapter)
        {
            try
            {
                // Display IP Address
                ipAddr.Text = adapter.IPAddress ?? "N/A";

                // Display Subnet Mask
                snMask.Text = adapter.SubnetMask ?? "N/A";

                // Display Default Gateway
                deGw.Text = adapter.DefaultGateway ?? "N/A";

                // Display Primary DNS Server
                nwDns1.Text = adapter.PrimaryDNS ?? "N/A";

                // Display Secondary DNS Server
                nwDns2.Text = adapter.SecondaryDNS ?? "N/A";

                // Log the command and its output
                LogToCsLog($"Query: {adapter.Name} Configuration\n");
            }
            catch (Exception ex)
            {
                // Handle exceptions and log errors
                LogToCsLog($"Error displaying adapter information: {ex.Message} \n");
            }
        }
        // Grabbing / storing IP information for display. 
        private string GetFirstIPv4Address(NetworkInterface adapter)
        {
            var ipv4Addresses = adapter.GetIPProperties().UnicastAddresses
                .Where(addr => addr.Address.AddressFamily == AddressFamily.InterNetwork)
                .Select(addr => addr.Address.ToString());

            return ipv4Addresses.FirstOrDefault() ?? "N/A";
        }
        // Grabbing / storing IP information for display. 
        private string GetSubnetMask(NetworkInterface adapter)
        {
            var subnetMasks = adapter.GetIPProperties().UnicastAddresses
                .Where(addr => addr.Address.AddressFamily == AddressFamily.InterNetwork)
                .Select(addr => addr.IPv4Mask.ToString());

            return subnetMasks.FirstOrDefault() ?? "N/A";
        }
        // Grabbing / storing IP information for display. 
        private string GetDefaultGateway(NetworkInterface adapter)
        {
            var gateways = adapter.GetIPProperties().GatewayAddresses
                .Where(gw => gw.Address.AddressFamily == AddressFamily.InterNetwork)
                .Select(gw => gw.Address.ToString());

            return gateways.FirstOrDefault() ?? "N/A";
        }
        // Grabbing / storing IP information for display. 
        private string GetPrimaryDNS(NetworkInterface adapter)
        {
            var dnsServers = adapter.GetIPProperties().DnsAddresses
                .Where(dns => dns.AddressFamily == AddressFamily.InterNetwork)
                .Select(dns => dns.ToString());

            return dnsServers.FirstOrDefault() ?? "N/A";
        }
        // Grabbing / storing IP information for display. 
        private string GetSecondaryDNS(NetworkInterface adapter)
        {
            var dnsServers = adapter.GetIPProperties().DnsAddresses
                .Where(dns => dns.AddressFamily == AddressFamily.InterNetwork)
                .Select(dns => dns.ToString());

            // Skip the first DNS server to get the secondary one
            return dnsServers.Skip(1).FirstOrDefault() ?? "N/A";
        }
        // Grabbing / storing IP information for display. 
        private void QueryPowerSettings()
        {
            try
            {
                LogToCsLog("Query: Power Settings\n");
                PowerCfgUtility configUtility = new PowerCfgUtility(LogToCsLog);
                string jsonOutput = configUtility.GetPowerSettings();
                var powerSettings = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonOutput);

                // Update labels
                pwrScrnOff.Text = powerSettings.ContainsKey("Screen Timeout") ? powerSettings["Screen Timeout"] : "None";
                pwrSleep.Text = powerSettings.ContainsKey("Sleep Timeout") ? powerSettings["Sleep Timeout"] : "None";
                pwrCurrentPlan.Text = powerSettings.ContainsKey("Active Power Scheme") ? powerSettings["Active Power Scheme"] : "None";
            }
            catch (Exception ex)
            {
                LogToCsLog($"Error querying power settings: {ex.Message}\n");
            }
        }
        // Use the PowerCfgUtility class to query the power settings and display them in the appropriate labels
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        // WIP or Unused
        private void eventVirewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // WIP or Unused
        private void currentHSLabel_Click(object sender, EventArgs e)
        {

        }
        // WIP or Unused
        private void newHsLabel_Click(object sender, EventArgs e)
        {

        }
        // WIP or Unused
        private void tabNwMenu_Click_1(object sender, EventArgs e)
        {

        }
        // Function for checking which radio button is selected when the "Set" button for the firewall state is clicked
        private void fwOptSet_Click(object sender, EventArgs e)
        {
            // Check which radio button is selected
            if (fwEnableRadio.Checked)
            {
                // Enable the firewall
                EnableFirewall();
            }
            else if (fwDisableRadio.Checked)
            {
                // Disable the firewall
                DisableFirewall();
            }
        }
        // When the "enable" radio button is selected when the Set button is clicked, run this function - Calls CMD then PowerShell
        private void EnableFirewall()
        {
            try
            {
                // Build the PowerShell command to enable the firewall
                string command = "powershell -Command \"Set-NetFirewallProfile -Enabled True\"";

                // Start a process to execute the command
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                LogToCsLog($"PowerShell: Set-NetFireWallProfile -Enabled True\n");
                process.StartInfo = startInfo;
                process.Start();

                // Pass the command to the command prompt
                process.StandardInput.WriteLine(command);
                process.StandardInput.WriteLine("exit");

                // Wait for the process to finish
                process.WaitForExit();
                // Re-Load queries and write success 
                nwAdapt.Items.Clear(); // To avoid NIC list duplication 
                ReloadQueries();
                LogToCsLog($"PowerShell: Enable firewall\nOutput: Success\n");
            }
            catch (Exception ex)
            {
                // Handle exceptions and log errors
                LogToCsLog($"Error enabling firewall: {ex.Message}\n");
            }
        }
        // When the "disable" radio button is selected when the Set button is clicked, run this function - Calls CMD then PowerShell
        private void DisableFirewall()
        {
            try
            {
                // Build the PowerShell command to enable the firewall
                string command = "powershell -Command \"Set-NetFirewallProfile -Enabled False\"";

                // Start a process to execute the command
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                LogToCsLog($"PowerShell: Set-NetFireWallProfile -Enabled False\n");
                process.StartInfo = startInfo;
                process.Start();

                // Pass the command to the command prompt
                process.StandardInput.WriteLine(command);
                process.StandardInput.WriteLine("exit");

                // Wait for the process to finish
                process.WaitForExit();
                // Re-Load queries and write success 
                nwAdapt.Items.Clear();
                ReloadQueries();
                LogToCsLog($"PowerShell: Disable firewall\nOutput: Success\n");
            }
            catch (Exception ex)
            {
                // Handle exceptions and log errors
                LogToCsLog($"Error Disabling firewall: {ex.Message}\n");
            }
        }
        // Calling the ReloadQueries function, also clearing the network adapter list to avoid duplication in the list 
        private void resetQuery_Click(object sender, EventArgs e)
        {
            nwAdapt.Items.Clear();
            ReloadQueries();
        }
        // Clearing the C# log that all functions write to 
        private void csLogClear_Click(object sender, EventArgs e)
        {
            csLog.Clear();
        }
        // Function for changing hostname w/ error checking, as well as restart dialog
        // This section utilized internal Batch commands, as I was unable to find simpler methods within native C#
        private void newHostname_Click(object sender, EventArgs e)
        {
            // Get the new hostname from the textbox
            string newHostname = nHostname.Text.Trim();

            // Check if the new hostname is not empty
            if (!string.IsNullOrEmpty(newHostname))
            {
                try
                {
                    // Build the WMIC command to change the hostname
                    string command = $"wmic computersystem where caption=\"%COMPUTERNAME%\" call rename \"{newHostname}\"";

                    // Start a process to execute the command
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    process.StartInfo = startInfo;
                    process.Start();

                    // Pass the command to the command prompt
                    process.StandardInput.WriteLine(command);
                    process.StandardInput.WriteLine("exit");

                    // Wait for the process to finish
                    process.WaitForExit();

                    // Update the UI with the new hostname
                    cHostName.Text = newHostname;

                    // Log the command and its output
                    LogToCsLog($"Command: Set machine hostname to {newHostname}\nOutput: Success");

                    // Ask the user if they want to reboot
                    DialogResult result = MessageBox.Show("Hostname changed successfully. Do you want to reboot now?", "Hostname Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Reboot the machine
                        Process.Start("shutdown", "/r /t 0");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions and log errors
                    LogToCsLog($"Error setting machine hostname: {ex.Message}");
                }
            }
            else
            {
                // Display an error message if the new hostname is empty
                MessageBox.Show("Please enter a valid hostname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Action to send variables in the address textboxes to the ApplyNetworkSettings command 
        private void applyNewNwSettings_Click(object sender, EventArgs e)
        {
            // Check if any item is selected in the ListBox
            if (nwAdapt.SelectedItem != null)
            {
                // Ensure the selected item is of type NetworkAdapter
                if (nwAdapt.SelectedItem is NetworkAdapter selectedAdapter)
                {
                    try
                    {
                        // Get the new network settings from the text boxes
                        string newIPAddress = ipAddr.Text.Trim();
                        string newSubnetMask = snMask.Text.Trim();
                        string newDefaultGateway = deGw.Text.Trim();
                        string newPrimaryDNS = nwDns1.Text.Trim();
                        string newSecondaryDNS = nwDns2.Text.Trim();

                        // Apply the new network settings to the selected adapter
                        ApplyNetworkSettings(selectedAdapter, newIPAddress, newSubnetMask, newDefaultGateway, newPrimaryDNS, newSecondaryDNS);

                        // Log the command and its output
                        LogToCsLog($"Command: Set network settings for {selectedAdapter.Name}\nOutput: Success\n");
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions and log errors
                        LogToCsLog($"Error setting network settings: {ex.Message}\n");
                    }
                }
            }
        }
        // Building and parsing the data to be sent to the Execute command 
        private void ApplyNetworkSettings(NetworkAdapter adapter, string ipAddress, string subnetMask, string defaultGateway, string primaryDNS, string secondaryDNS)
        {
            try
            {
                // Build netsh commands
                string setIPAddressCommand = $"netsh interface ipv4 set address name=\"{adapter.ActName}\" static {ipAddress} {subnetMask} {defaultGateway} 1";
                string setDNSCommand = $"netsh interface ipv4 set dns name=\"{adapter.ActName}\" static {primaryDNS} validate=no";
                string addDNSCommand = $"netsh interface ipv4 add dns name=\"{adapter.ActName}\" {secondaryDNS} index=2 validate=no";

                // Execute netsh commands one by one
                csLog.Clear();
                LogToCsLog($"Applying new configuration to {adapter.Name}\n \n");
                ExecuteNetshCommand(setIPAddressCommand, "Setting IP Address");
                LogToCsLog($"IP address has been set to {ipAddress}\n");
                LogToCsLog($"Subnet Mask has been set to {subnetMask} \n");
                LogToCsLog($"Gateway has been set to {defaultGateway} \n");
                ExecuteNetshCommand(setDNSCommand, "Setting Primary DNS");
                LogToCsLog($"Primary DNS Server has been set to {primaryDNS} \n");
                ExecuteNetshCommand(addDNSCommand, "Adding Secondary DNS");
                LogToCsLog($"Secondary DNS Server has been set to {secondaryDNS}\n \n");
            }
            catch (Exception ex)
            {
                // Handle exceptions and log errors
                LogToCsLog($"Error applying network settings: {ex.Message}");
            }
        }
        // Executing the network changes defined in applyNewNwSettings function, after they have been parsed and built by ApplyNetworkSettings
        private void ExecuteNetshCommand(string command, string actionDescription)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    // Pass the command to the command prompt
                    process.StandardInput.WriteLine(command);
                    process.StandardInput.WriteLine("exit");

                    // Wait for the process to finish
                    process.WaitForExit();

                    // Log the command and its output
                    // LogToCsLog($"{actionDescription}:\nCommand: {command}\n"); // to avoid redundant errors, making room for more consise action logging
                }
            }
            catch (Exception ex)
            {
                // Log errors for failed commands
                LogToCsLog($"{actionDescription}:\nCommand: {command}\nOutput: {ex.Message}");
            }
        }
        // Resets the network configuration text boxes with their last queried data
        private void resetNwSet_click(object sender, EventArgs e)
        {
            if (nwAdapt.SelectedItem != null)
            {
                // Ensure the selected item is of type NetworkAdapter
                if (nwAdapt.SelectedItem is NetworkAdapter selectedAdapter)
                {
                    // Update the textboxes with the selected adapter's configuration
                    ipAddr.Text = selectedAdapter.IPAddress ?? "N/A";
                    snMask.Text = selectedAdapter.SubnetMask ?? "N/A";
                    deGw.Text = selectedAdapter.DefaultGateway ?? "N/A";
                    nwDns1.Text = selectedAdapter.PrimaryDNS ?? "N/A";
                    nwDns2.Text = selectedAdapter.SecondaryDNS ?? "N/A";

                    // Log the command and its output
                    LogToCsLog($"Reset: {selectedAdapter.Name} Configuration\n");
                }
            }
            else
            {
                // Display an error message if no adapter is selected
                MessageBox.Show("Please select a network adapter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // testCurrentNwSet button to trigger a command that natively uses C# to run a ping test 
        private void testCurrentNwSet_Click(object sender, EventArgs e)
        {
            LogToCsLog("\nPing Test Complete\n");
            // Set the host names for ping tests
            string googleHostName = "www.google.com";
            string microsoftCatalogHostName = "catalog.update.microsoft.com";

            // Perform ping tests
            bool googlePingSuccess = PerformPingTest(googleHostName);
            bool microsoftCatalogPingSuccess = PerformPingTest(microsoftCatalogHostName);

            // Update UI based on ping test results

            UpdatePingTestResultLabel(extConnStatus, googlePingSuccess);
            UpdatePingTestResultLabel(wuConnStatus, microsoftCatalogPingSuccess, "Catalog OK");
        }
        // Action of the ping test itself
        private bool PerformPingTest(string hostName)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(hostName);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch (Exception ex)
            {
                LogToCsLog($"Error performing ping test for {hostName}: {ex.Message}");
                return false;
            }

        }
        // Action of taking the result of the ping test, and printing it to the appropriate labels 
        private void UpdatePingTestResultLabel(Label label, bool success, string successText = "Success")
        {
            label.Text = success ? successText : "Failure";
            label.ForeColor = success ? Color.Green : Color.Red;
        }
        // Update labels after pingtest is ran
        private void setZeroTimeout_Click(object sender, EventArgs e)
        {
            string[] commands = { "-Change monitor-timeout-ac 0", "-Change standby-timeout-ac 0" };
            bool isError = false;

            foreach (var command in commands)
            {
                string result = ExecutePowerCfgCommand(command);
                if (result.Contains("Invalid Parameters -- try \"/?\" for help"))
                {
                    isError = true;
                    break;
                }
            }

            if (isError)
            {
                LogToCsLog("Error: Failure applying power settings.\n");
            }
            else
            {
                LogToCsLog("Monitor and standby timeouts set to zero.\n");
                QueryPowerSettings();
            }
        }
        // When button is clicked, set sleep / monitor timeouts to 0 - using ExecutePowerCfgCommand method
        private void setToHp_Click(object sender, EventArgs e)
        {
            string highPerformancePowerSchemeGuid = "8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c";
            string command = $"/s {highPerformancePowerSchemeGuid}";

            string result = ExecutePowerCfgCommand(command);

            if (result.Contains("Invalid Parameters -- try \"/?\" for help"))
            {
                LogToCsLog("Power Plan: High Performance not found.\n");
            }
            else
            {
                LogToCsLog("Power Plan: Set to High Performance.\n");
                QueryPowerSettings();
            }
        }
        // When button is clicked, set power plan to High performance - using ExecutePowerCfgCommand method
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
        // invoked when changing power settings
        private async void enableRDP_Click(object sender, EventArgs e)
        {
            await CheckRemoteAccess.ChgRemoteAccessAsync(true, LogToCsLog);
            await CheckRemoteAccess.CheckRDPStatusAsync(rdpSetQuery);
        }
        // when button is clicked - enable rdp using CheckRemoteAccess class and requery
        private async void disableRDP_Click(object sender, EventArgs e)
        {
            await CheckRemoteAccess.ChgRemoteAccessAsync(false, LogToCsLog);
            await CheckRemoteAccess.CheckRDPStatusAsync(rdpSetQuery);
        }
        // when button is clicked - disable rdp using CheckRemoteAccess class and requery
        private void pwrLabel_Click(object sender, EventArgs e)
        {

        }
        // WIP or Unused
        private void tabWinMenu_Click(object sender, EventArgs e)
        {

        }
        // WIP or unused
        #region ToolStripMenu Click Events
        
        private void lusrmgrLaunch_Click(object sender, EventArgs e)
        {
            MenuStrip.LusrMgr();
        }
        private void controlUpdateLaunch_Click(object sender, EventArgs e)
        {
            MenuStrip.ControlUpdate();
        }
        private void gpeditLaunch_Click(object sender, EventArgs e)
        {
            MenuStrip.GpEdit();
        }
        private void diskmgmtLaunch_Click(object sender, EventArgs e)
        {
            MenuStrip.DiskMgmt();
        }
        private void eventvwrLaunch_Click(object sender, EventArgs e)
        {
            MenuStrip.EventViewer();
        }
        private void psLaunch_Click(object sender, EventArgs e)
        {
            MenuStrip.OpenPowershell();
        }
        private void cmdLaunch_Click(object sender, EventArgs e)
        {
            MenuStrip.OpenCMD();
        }
        private void perfmonLaunch_Click(object sender, EventArgs e)
        {
            MenuStrip.PerfMon();
        }
        private void devmgmtLaunch_Click(object sender, EventArgs e)
        {
            MenuStrip.DevMgmt();
        }
        private void msconfigLaunch_Click(object sender, EventArgs e)
        {
            MenuStrip.MsConfig();
        }
        
        #endregion
    }
}
