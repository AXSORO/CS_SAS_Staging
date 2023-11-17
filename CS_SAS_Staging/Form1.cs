// including dependencies 
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using NetFwTypeLib;
using System.Collections.Generic;
using static CS_SAS_Staging.NetworkAdapter;
using System.Net.Sockets;

namespace CS_SAS_Staging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LogToCsLog("C# Logging Initialized\n");
            LogToCsLog("\n");
            Load += Form1_Load;

            // Display selected adapter below the listBox
            nwAdapt.SelectedIndexChanged += nwAdapt_SelectedIndexChanged;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // more useless but cool stuff to be put into the log 
            await Task.Delay(500);
            LogToCsLog("System.Diagnostics Library Loaded\n");
            await Task.Delay(250);
            LogToCsLog("System.Net.Sockets Library Loaded\n");
            await Task.Delay(250);
            LogToCsLog("FirewallAPI Loaded\n \n");
            await Task.Delay(250);
            LogToCsLog("Running Queries...\n");
            await Task.Delay(1000);
            LogToCsLog("Complete. Starting application.");
            await Task.Delay(250);
            LogToCsLog(".");
            await Task.Delay(250);
            LogToCsLog(".\n");
            await Task.Delay(100);
            csLog.Clear();
            // Seperate function to run queries after launch, makes it open much faster
            RunQueries();
        }

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

        private void RunQueries()
        {
            csLog.Clear();
            QueryMachineInfo();
            QueryNetworkAdapters();
            QueryFirewallStatus();
        }

        // This code relates to logging and querying mostly for the first few blocks.
        // Hostname Query Function
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

        // Query Network Adapters

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

        // Query Firewall Status Function

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
        // Logging Functions for querying.
        private void LogToCsLog(string logText)
        {
            // Append the log text to the "csLog" rich text box
            csLog.AppendText($"{logText}");
            csLog.ScrollToCaret();
        }
        private void nwAdapt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected in the ListBox
            if (nwAdapt.SelectedItem != null)
            {
                // Ensure the selected item is of type NetworkAdapter
                if (nwAdapt.SelectedItem is NetworkAdapter selectedAdapter)
                {
                    // Update the "selAdapt" label with the selected adapter's name
                    selAdapt.Text = $"{selectedAdapter.Name}";

                    // Display the adapter's information
                    DisplayAdapterInfo(selectedAdapter);
                }
            }
        }
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
        // Helper methods to get adapter information
        private string GetFirstIPv4Address(NetworkInterface adapter)
        {
            var ipv4Addresses = adapter.GetIPProperties().UnicastAddresses
                .Where(addr => addr.Address.AddressFamily == AddressFamily.InterNetwork)
                .Select(addr => addr.Address.ToString());

            return ipv4Addresses.FirstOrDefault() ?? "N/A";
        }

        private string GetSubnetMask(NetworkInterface adapter)
        {
            var subnetMasks = adapter.GetIPProperties().UnicastAddresses
                .Where(addr => addr.Address.AddressFamily == AddressFamily.InterNetwork)
                .Select(addr => addr.IPv4Mask.ToString());

            return subnetMasks.FirstOrDefault() ?? "N/A";
        }

        private string GetDefaultGateway(NetworkInterface adapter)
        {
            var gateways = adapter.GetIPProperties().GatewayAddresses
                .Where(gw => gw.Address.AddressFamily == AddressFamily.InterNetwork)
                .Select(gw => gw.Address.ToString());

            return gateways.FirstOrDefault() ?? "N/A";
        }

        private string GetPrimaryDNS(NetworkInterface adapter)
        {
            var dnsServers = adapter.GetIPProperties().DnsAddresses
                .Where(dns => dns.AddressFamily == AddressFamily.InterNetwork)
                .Select(dns => dns.ToString());

            return dnsServers.FirstOrDefault() ?? "N/A";
        }

        private string GetSecondaryDNS(NetworkInterface adapter)
        {
            var dnsServers = adapter.GetIPProperties().DnsAddresses
                .Where(dns => dns.AddressFamily == AddressFamily.InterNetwork)
                .Select(dns => dns.ToString());

            // Skip the first DNS server to get the secondary one
            return dnsServers.Skip(1).FirstOrDefault() ?? "N/A";
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void eventVirewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void currentHSLabel_Click(object sender, EventArgs e)
        {

        }

        private void newHsLabel_Click(object sender, EventArgs e)
        {

        }

        private void tabNwMenu_Click(object sender, EventArgs e)
        {

        }

        private void resetNwSet_Click(object sender, EventArgs e)
        {

        }

        private void tabNwMenu_Click_1(object sender, EventArgs e)
        {

        }

        private void fwOptSet_Click(object sender, EventArgs e)
        {
        }

        private void resetQuery_Click(object sender, EventArgs e) 
        {
            nwAdapt.Items.Clear();
            ReloadQueries();
        }
        private void csLogClear_Click(object sender, EventArgs e)
        {
            csLog.Clear();
        }

    }
}
