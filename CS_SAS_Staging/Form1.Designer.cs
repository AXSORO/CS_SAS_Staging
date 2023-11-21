namespace CS_SAS_Staging
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            csLog = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            tsPsStatLabel = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveReportToolStripMenuItem = new ToolStripMenuItem();
            shellToolStripMenuItem = new ToolStripMenuItem();
            openPSWindowToolStripMenuItem = new ToolStripMenuItem();
            openCMDWindowToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            localUserManagerToolStripMenuItem = new ToolStripMenuItem();
            windowsUpdateToolStripMenuItem = new ToolStripMenuItem();
            groupPolicyEditorToolStripMenuItem = new ToolStripMenuItem();
            diskManagementToolStripMenuItem = new ToolStripMenuItem();
            eventVirewToolStripMenuItem = new ToolStripMenuItem();
            performanceMonitorToolStripMenuItem = new ToolStripMenuItem();
            controlPanelOptionsToolStripMenuItem = new ToolStripMenuItem();
            deviceManagerToolStripMenuItem = new ToolStripMenuItem();
            mSConfigToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tabMain = new TabControl();
            tabNwMenu = new TabPage();
            cHostName = new Label();
            fwOptSet = new Button();
            fwDisableRadio = new RadioButton();
            fwEnableRadio = new RadioButton();
            resetQuery = new Button();
            puFirewallStat = new Label();
            doFirewallStat = new Label();
            pvFirewallStat = new Label();
            fwPubStat = new Label();
            fwDomainStat = new Label();
            fwPrvStat = new Label();
            fwStatLabel = new Label();
            panel1 = new Panel();
            applyNewNwSettings = new Button();
            testCurrentNwSet = new Button();
            nwDns2 = new TextBox();
            nwDns1 = new TextBox();
            deGw = new TextBox();
            snMask = new TextBox();
            ipAddr = new TextBox();
            resetNwSet = new Button();
            wuConnStatus = new Label();
            extConnStatus = new Label();
            wuConnResultLabel = new Label();
            extConnResultLabel = new Label();
            selAdapt = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nwAdapt = new ListBox();
            nicLabel = new Label();
            sep2 = new Panel();
            sep1 = new Panel();
            newHostname = new Button();
            nHostname = new TextBox();
            newHsLabel = new Label();
            currentHSLabel = new Label();
            tabAppMenu = new TabPage();
            tabWinMenu = new TabPage();
            psLogWindow = new Label();
            csLogClear = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            pwrLabel = new Label();
            label6 = new Label();
            pwrScrnOff = new Label();
            pwrSleep = new Label();
            label9 = new Label();
            pwrCurrentPlan = new Label();
            panel2 = new Panel();
            setMaxPwr = new Button();
            stockPwrPlan = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            enableRDP = new Button();
            disableRDP = new Button();
            rdpFwRules = new Button();
            rdpSet1Query = new Label();
            rdpSet2Query = new Label();
            label16 = new Label();
            usrCollect = new ListBox();
            label17 = new Label();
            label18 = new Label();
            usrPwConfirm = new TextBox();
            usrPw = new TextBox();
            usrName = new TextBox();
            label10 = new Label();
            label14 = new Label();
            label15 = new Label();
            isUsrAdmin = new CheckBox();
            isUsrDisabled = new CheckBox();
            openLusrmgr = new Button();
            usrSetPw = new Button();
            resetAllPw = new Button();
            usrApply = new Button();
            isUsrRdp = new CheckBox();
            panel7 = new Panel();
            controlWindowsUpdate = new Button();
            scriptWindowsUpdate = new Button();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tabMain.SuspendLayout();
            tabNwMenu.SuspendLayout();
            tabAppMenu.SuspendLayout();
            tabWinMenu.SuspendLayout();
            SuspendLayout();
            // 
            // csLog
            // 
            csLog.BackColor = SystemColors.GradientInactiveCaption;
            csLog.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            csLog.Location = new Point(522, 51);
            csLog.Name = "csLog";
            csLog.ReadOnly = true;
            csLog.Size = new Size(290, 379);
            csLog.TabIndex = 3;
            csLog.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, tsPsStatLabel });
            statusStrip1.Location = new Point(0, 469);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(825, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // tsPsStatLabel
            // 
            tsPsStatLabel.Name = "tsPsStatLabel";
            tsPsStatLabel.Size = new Size(39, 17);
            tsPsStatLabel.Text = "Ready";
            tsPsStatLabel.Click += toolStripStatusLabel1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, shellToolStripMenuItem, windowsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(825, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveReportToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveReportToolStripMenuItem
            // 
            saveReportToolStripMenuItem.Name = "saveReportToolStripMenuItem";
            saveReportToolStripMenuItem.Size = new Size(180, 22);
            saveReportToolStripMenuItem.Text = "Save Report";
            // 
            // shellToolStripMenuItem
            // 
            shellToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openPSWindowToolStripMenuItem, openCMDWindowToolStripMenuItem });
            shellToolStripMenuItem.Name = "shellToolStripMenuItem";
            shellToolStripMenuItem.Size = new Size(44, 20);
            shellToolStripMenuItem.Text = "Shell";
            // 
            // openPSWindowToolStripMenuItem
            // 
            openPSWindowToolStripMenuItem.Name = "openPSWindowToolStripMenuItem";
            openPSWindowToolStripMenuItem.Size = new Size(180, 22);
            openPSWindowToolStripMenuItem.Text = "Open P/S Window";
            // 
            // openCMDWindowToolStripMenuItem
            // 
            openCMDWindowToolStripMenuItem.Name = "openCMDWindowToolStripMenuItem";
            openCMDWindowToolStripMenuItem.Size = new Size(180, 22);
            openCMDWindowToolStripMenuItem.Text = "Open CMD Window";
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localUserManagerToolStripMenuItem, windowsUpdateToolStripMenuItem, groupPolicyEditorToolStripMenuItem, diskManagementToolStripMenuItem, eventVirewToolStripMenuItem, performanceMonitorToolStripMenuItem, controlPanelOptionsToolStripMenuItem, mSConfigToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(68, 20);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // localUserManagerToolStripMenuItem
            // 
            localUserManagerToolStripMenuItem.Name = "localUserManagerToolStripMenuItem";
            localUserManagerToolStripMenuItem.Size = new Size(200, 22);
            localUserManagerToolStripMenuItem.Text = "Local User Manager";
            // 
            // windowsUpdateToolStripMenuItem
            // 
            windowsUpdateToolStripMenuItem.Name = "windowsUpdateToolStripMenuItem";
            windowsUpdateToolStripMenuItem.Size = new Size(200, 22);
            windowsUpdateToolStripMenuItem.Text = "Windows Update";
            // 
            // groupPolicyEditorToolStripMenuItem
            // 
            groupPolicyEditorToolStripMenuItem.Name = "groupPolicyEditorToolStripMenuItem";
            groupPolicyEditorToolStripMenuItem.Size = new Size(200, 22);
            groupPolicyEditorToolStripMenuItem.Text = "Group Policy Editor";
            // 
            // diskManagementToolStripMenuItem
            // 
            diskManagementToolStripMenuItem.Name = "diskManagementToolStripMenuItem";
            diskManagementToolStripMenuItem.Size = new Size(200, 22);
            diskManagementToolStripMenuItem.Text = "Disk Management";
            // 
            // eventVirewToolStripMenuItem
            // 
            eventVirewToolStripMenuItem.Name = "eventVirewToolStripMenuItem";
            eventVirewToolStripMenuItem.Size = new Size(200, 22);
            eventVirewToolStripMenuItem.Text = "Event Viewer";
            eventVirewToolStripMenuItem.Click += eventVirewToolStripMenuItem_Click;
            // 
            // performanceMonitorToolStripMenuItem
            // 
            performanceMonitorToolStripMenuItem.Name = "performanceMonitorToolStripMenuItem";
            performanceMonitorToolStripMenuItem.Size = new Size(200, 22);
            performanceMonitorToolStripMenuItem.Text = "Performance Monitor";
            // 
            // controlPanelOptionsToolStripMenuItem
            // 
            controlPanelOptionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deviceManagerToolStripMenuItem });
            controlPanelOptionsToolStripMenuItem.Name = "controlPanelOptionsToolStripMenuItem";
            controlPanelOptionsToolStripMenuItem.Size = new Size(200, 22);
            controlPanelOptionsToolStripMenuItem.Text = "Control Panel Options...";
            // 
            // deviceManagerToolStripMenuItem
            // 
            deviceManagerToolStripMenuItem.Name = "deviceManagerToolStripMenuItem";
            deviceManagerToolStripMenuItem.Size = new Size(159, 22);
            deviceManagerToolStripMenuItem.Text = "Device Manager";
            // 
            // mSConfigToolStripMenuItem
            // 
            mSConfigToolStripMenuItem.Name = "mSConfigToolStripMenuItem";
            mSConfigToolStripMenuItem.Size = new Size(200, 22);
            mSConfigToolStripMenuItem.Text = "MSConfig";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(105, 22);
            aboutToolStripMenuItem.Text = "about";
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabNwMenu);
            tabMain.Controls.Add(tabAppMenu);
            tabMain.Controls.Add(tabWinMenu);
            tabMain.Location = new Point(12, 27);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(508, 439);
            tabMain.TabIndex = 2;
            // 
            // tabNwMenu
            // 
            tabNwMenu.Controls.Add(cHostName);
            tabNwMenu.Controls.Add(fwOptSet);
            tabNwMenu.Controls.Add(fwDisableRadio);
            tabNwMenu.Controls.Add(fwEnableRadio);
            tabNwMenu.Controls.Add(resetQuery);
            tabNwMenu.Controls.Add(puFirewallStat);
            tabNwMenu.Controls.Add(doFirewallStat);
            tabNwMenu.Controls.Add(pvFirewallStat);
            tabNwMenu.Controls.Add(fwPubStat);
            tabNwMenu.Controls.Add(fwDomainStat);
            tabNwMenu.Controls.Add(fwPrvStat);
            tabNwMenu.Controls.Add(fwStatLabel);
            tabNwMenu.Controls.Add(panel1);
            tabNwMenu.Controls.Add(applyNewNwSettings);
            tabNwMenu.Controls.Add(testCurrentNwSet);
            tabNwMenu.Controls.Add(nwDns2);
            tabNwMenu.Controls.Add(nwDns1);
            tabNwMenu.Controls.Add(deGw);
            tabNwMenu.Controls.Add(snMask);
            tabNwMenu.Controls.Add(ipAddr);
            tabNwMenu.Controls.Add(resetNwSet);
            tabNwMenu.Controls.Add(wuConnStatus);
            tabNwMenu.Controls.Add(extConnStatus);
            tabNwMenu.Controls.Add(wuConnResultLabel);
            tabNwMenu.Controls.Add(extConnResultLabel);
            tabNwMenu.Controls.Add(selAdapt);
            tabNwMenu.Controls.Add(label5);
            tabNwMenu.Controls.Add(label4);
            tabNwMenu.Controls.Add(label3);
            tabNwMenu.Controls.Add(label2);
            tabNwMenu.Controls.Add(label1);
            tabNwMenu.Controls.Add(nwAdapt);
            tabNwMenu.Controls.Add(nicLabel);
            tabNwMenu.Controls.Add(sep2);
            tabNwMenu.Controls.Add(sep1);
            tabNwMenu.Controls.Add(newHostname);
            tabNwMenu.Controls.Add(nHostname);
            tabNwMenu.Controls.Add(newHsLabel);
            tabNwMenu.Controls.Add(currentHSLabel);
            tabNwMenu.Location = new Point(4, 24);
            tabNwMenu.Name = "tabNwMenu";
            tabNwMenu.Padding = new Padding(3);
            tabNwMenu.Size = new Size(500, 411);
            tabNwMenu.TabIndex = 0;
            tabNwMenu.Text = "Networking";
            tabNwMenu.UseVisualStyleBackColor = true;
            tabNwMenu.Click += tabNwMenu_Click_1;
            // 
            // cHostName
            // 
            cHostName.AutoSize = true;
            cHostName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cHostName.Location = new Point(120, 6);
            cHostName.Name = "cHostName";
            cHostName.Size = new Size(29, 15);
            cHostName.TabIndex = 41;
            cHostName.Text = "N/A";
            // 
            // fwOptSet
            // 
            fwOptSet.Location = new Point(20, 229);
            fwOptSet.Name = "fwOptSet";
            fwOptSet.Size = new Size(70, 23);
            fwOptSet.TabIndex = 40;
            fwOptSet.Text = "Set";
            fwOptSet.UseVisualStyleBackColor = true;
            fwOptSet.Click += fwOptSet_Click;
            // 
            // fwDisableRadio
            // 
            fwDisableRadio.AutoSize = true;
            fwDisableRadio.Location = new Point(20, 204);
            fwDisableRadio.Name = "fwDisableRadio";
            fwDisableRadio.Size = new Size(70, 19);
            fwDisableRadio.TabIndex = 39;
            fwDisableRadio.TabStop = true;
            fwDisableRadio.Text = "Disabled";
            fwDisableRadio.UseVisualStyleBackColor = true;
            // 
            // fwEnableRadio
            // 
            fwEnableRadio.AutoSize = true;
            fwEnableRadio.Location = new Point(20, 182);
            fwEnableRadio.Name = "fwEnableRadio";
            fwEnableRadio.Size = new Size(67, 19);
            fwEnableRadio.TabIndex = 38;
            fwEnableRadio.TabStop = true;
            fwEnableRadio.Text = "Enabled";
            fwEnableRadio.UseVisualStyleBackColor = true;
            // 
            // resetQuery
            // 
            resetQuery.Location = new Point(6, 385);
            resetQuery.Name = "resetQuery";
            resetQuery.Size = new Size(230, 23);
            resetQuery.TabIndex = 37;
            resetQuery.Text = "Re-Run Query";
            resetQuery.UseVisualStyleBackColor = true;
            resetQuery.Click += resetQuery_Click;
            // 
            // puFirewallStat
            // 
            puFirewallStat.AutoSize = true;
            puFirewallStat.Location = new Point(76, 154);
            puFirewallStat.Name = "puFirewallStat";
            puFirewallStat.Size = new Size(29, 15);
            puFirewallStat.TabIndex = 36;
            puFirewallStat.Text = "N/A";
            // 
            // doFirewallStat
            // 
            doFirewallStat.AutoSize = true;
            doFirewallStat.Location = new Point(76, 134);
            doFirewallStat.Name = "doFirewallStat";
            doFirewallStat.Size = new Size(29, 15);
            doFirewallStat.TabIndex = 35;
            doFirewallStat.Text = "N/A";
            // 
            // pvFirewallStat
            // 
            pvFirewallStat.AutoSize = true;
            pvFirewallStat.Location = new Point(76, 114);
            pvFirewallStat.Name = "pvFirewallStat";
            pvFirewallStat.Size = new Size(29, 15);
            pvFirewallStat.TabIndex = 34;
            pvFirewallStat.Text = "N/A";
            // 
            // fwPubStat
            // 
            fwPubStat.AutoSize = true;
            fwPubStat.Location = new Point(6, 154);
            fwPubStat.Name = "fwPubStat";
            fwPubStat.Size = new Size(43, 15);
            fwPubStat.TabIndex = 33;
            fwPubStat.Text = "Public:";
            // 
            // fwDomainStat
            // 
            fwDomainStat.AutoSize = true;
            fwDomainStat.Location = new Point(6, 134);
            fwDomainStat.Name = "fwDomainStat";
            fwDomainStat.Size = new Size(52, 15);
            fwDomainStat.TabIndex = 32;
            fwDomainStat.Text = "Domain:";
            // 
            // fwPrvStat
            // 
            fwPrvStat.AutoSize = true;
            fwPrvStat.Location = new Point(6, 114);
            fwPrvStat.Name = "fwPrvStat";
            fwPrvStat.Size = new Size(46, 15);
            fwPrvStat.TabIndex = 31;
            fwPrvStat.Text = "Private:";
            // 
            // fwStatLabel
            // 
            fwStatLabel.AutoSize = true;
            fwStatLabel.Location = new Point(6, 89);
            fwStatLabel.Name = "fwStatLabel";
            fwStatLabel.Size = new Size(82, 15);
            fwStatLabel.TabIndex = 30;
            fwStatLabel.Text = "Firewall Status";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(6, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1);
            panel1.TabIndex = 29;
            // 
            // applyNewNwSettings
            // 
            applyNewNwSettings.Location = new Point(415, 385);
            applyNewNwSettings.Name = "applyNewNwSettings";
            applyNewNwSettings.Size = new Size(75, 23);
            applyNewNwSettings.TabIndex = 28;
            applyNewNwSettings.Text = "Set";
            applyNewNwSettings.UseVisualStyleBackColor = true;
            applyNewNwSettings.Click += applyNewNwSettings_Click;
            // 
            // testCurrentNwSet
            // 
            testCurrentNwSet.Location = new Point(334, 385);
            testCurrentNwSet.Name = "testCurrentNwSet";
            testCurrentNwSet.Size = new Size(75, 23);
            testCurrentNwSet.TabIndex = 27;
            testCurrentNwSet.Text = "Test";
            testCurrentNwSet.UseVisualStyleBackColor = true;
            testCurrentNwSet.Click += testCurrentNwSet_Click;
            // 
            // nwDns2
            // 
            nwDns2.Location = new Point(376, 356);
            nwDns2.Name = "nwDns2";
            nwDns2.Size = new Size(100, 23);
            nwDns2.TabIndex = 26;
            // 
            // nwDns1
            // 
            nwDns1.Location = new Point(376, 330);
            nwDns1.Name = "nwDns1";
            nwDns1.Size = new Size(100, 23);
            nwDns1.TabIndex = 25;
            // 
            // deGw
            // 
            deGw.Location = new Point(376, 304);
            deGw.Name = "deGw";
            deGw.Size = new Size(100, 23);
            deGw.TabIndex = 24;
            // 
            // snMask
            // 
            snMask.Location = new Point(376, 278);
            snMask.Name = "snMask";
            snMask.Size = new Size(100, 23);
            snMask.TabIndex = 23;
            // 
            // ipAddr
            // 
            ipAddr.Location = new Point(376, 252);
            ipAddr.Name = "ipAddr";
            ipAddr.Size = new Size(100, 23);
            ipAddr.TabIndex = 22;
            // 
            // resetNwSet
            // 
            resetNwSet.Location = new Point(253, 385);
            resetNwSet.Name = "resetNwSet";
            resetNwSet.Size = new Size(75, 23);
            resetNwSet.TabIndex = 19;
            resetNwSet.Text = "Reset";
            resetNwSet.UseVisualStyleBackColor = true;
            resetNwSet.Click += resetNwSet_click;
            // 
            // wuConnStatus
            // 
            wuConnStatus.AutoSize = true;
            wuConnStatus.Location = new Point(428, 234);
            wuConnStatus.Name = "wuConnStatus";
            wuConnStatus.Size = new Size(29, 15);
            wuConnStatus.TabIndex = 18;
            wuConnStatus.Text = "N/A";
            // 
            // extConnStatus
            // 
            extConnStatus.AutoSize = true;
            extConnStatus.Location = new Point(428, 215);
            extConnStatus.Name = "extConnStatus";
            extConnStatus.Size = new Size(29, 15);
            extConnStatus.TabIndex = 17;
            extConnStatus.Text = "N/A";
            // 
            // wuConnResultLabel
            // 
            wuConnResultLabel.AutoSize = true;
            wuConnResultLabel.Location = new Point(253, 234);
            wuConnResultLabel.Name = "wuConnResultLabel";
            wuConnResultLabel.Size = new Size(141, 15);
            wuConnResultLabel.TabIndex = 16;
            wuConnResultLabel.Text = "Windows Update Catalog";
            // 
            // extConnResultLabel
            // 
            extConnResultLabel.AutoSize = true;
            extConnResultLabel.Location = new Point(253, 215);
            extConnResultLabel.Name = "extConnResultLabel";
            extConnResultLabel.Size = new Size(117, 15);
            extConnResultLabel.TabIndex = 15;
            extConnResultLabel.Text = "External Connection:";
            // 
            // selAdapt
            // 
            selAdapt.AutoSize = true;
            selAdapt.Location = new Point(253, 189);
            selAdapt.Name = "selAdapt";
            selAdapt.Size = new Size(115, 15);
            selAdapt.TabIndex = 14;
            selAdapt.Text = "No Adapter Selected";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 359);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 13;
            label5.Text = "DNS Server 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 333);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 12;
            label4.Text = "DNS Server 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 307);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 11;
            label3.Text = "Default Gateway:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 281);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 10;
            label2.Text = "Subnet Mask:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 255);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 9;
            label1.Text = "IP Address:";
            // 
            // nwAdapt
            // 
            nwAdapt.FormattingEnabled = true;
            nwAdapt.ItemHeight = 15;
            nwAdapt.Location = new Point(253, 47);
            nwAdapt.Name = "nwAdapt";
            nwAdapt.Size = new Size(223, 139);
            nwAdapt.TabIndex = 8;
            // 
            // nicLabel
            // 
            nicLabel.AutoSize = true;
            nicLabel.Location = new Point(253, 29);
            nicLabel.Name = "nicLabel";
            nicLabel.Size = new Size(156, 15);
            nicLabel.TabIndex = 7;
            nicLabel.Text = "Available Network Adapters:";
            nicLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // sep2
            // 
            sep2.BackColor = Color.DimGray;
            sep2.Location = new Point(242, 25);
            sep2.Name = "sep2";
            sep2.Size = new Size(1, 376);
            sep2.TabIndex = 6;
            // 
            // sep1
            // 
            sep1.BackColor = Color.DimGray;
            sep1.Location = new Point(6, 25);
            sep1.Name = "sep1";
            sep1.Size = new Size(588, 1);
            sep1.TabIndex = 5;
            // 
            // newHostname
            // 
            newHostname.Location = new Point(161, 47);
            newHostname.Name = "newHostname";
            newHostname.Size = new Size(75, 23);
            newHostname.TabIndex = 3;
            newHostname.Text = "Apply";
            newHostname.UseVisualStyleBackColor = true;
            newHostname.Click += newHostname_Click;
            // 
            // nHostname
            // 
            nHostname.Location = new Point(6, 47);
            nHostname.Name = "nHostname";
            nHostname.Size = new Size(149, 23);
            nHostname.TabIndex = 2;
            // 
            // newHsLabel
            // 
            newHsLabel.AutoSize = true;
            newHsLabel.Location = new Point(6, 29);
            newHsLabel.Name = "newHsLabel";
            newHsLabel.Size = new Size(149, 15);
            newHsLabel.TabIndex = 1;
            newHsLabel.Text = "Change Current Hostname";
            newHsLabel.Click += newHsLabel_Click;
            // 
            // currentHSLabel
            // 
            currentHSLabel.AutoSize = true;
            currentHSLabel.Location = new Point(6, 6);
            currentHSLabel.Name = "currentHSLabel";
            currentHSLabel.Size = new Size(108, 15);
            currentHSLabel.TabIndex = 0;
            currentHSLabel.Text = "Current Hostname:";
            currentHSLabel.Click += currentHSLabel_Click;
            // 
            // tabAppMenu
            // 
            tabAppMenu.Controls.Add(panel3);
            tabAppMenu.Controls.Add(panel4);
            tabAppMenu.Location = new Point(4, 24);
            tabAppMenu.Name = "tabAppMenu";
            tabAppMenu.Padding = new Padding(3);
            tabAppMenu.Size = new Size(500, 411);
            tabAppMenu.TabIndex = 1;
            tabAppMenu.Text = "Applications";
            tabAppMenu.UseVisualStyleBackColor = true;
            // 
            // tabWinMenu
            // 
            tabWinMenu.Controls.Add(scriptWindowsUpdate);
            tabWinMenu.Controls.Add(controlWindowsUpdate);
            tabWinMenu.Controls.Add(panel7);
            tabWinMenu.Controls.Add(isUsrRdp);
            tabWinMenu.Controls.Add(usrApply);
            tabWinMenu.Controls.Add(resetAllPw);
            tabWinMenu.Controls.Add(usrSetPw);
            tabWinMenu.Controls.Add(openLusrmgr);
            tabWinMenu.Controls.Add(isUsrDisabled);
            tabWinMenu.Controls.Add(isUsrAdmin);
            tabWinMenu.Controls.Add(usrPwConfirm);
            tabWinMenu.Controls.Add(usrPw);
            tabWinMenu.Controls.Add(usrName);
            tabWinMenu.Controls.Add(label10);
            tabWinMenu.Controls.Add(label14);
            tabWinMenu.Controls.Add(label15);
            tabWinMenu.Controls.Add(label18);
            tabWinMenu.Controls.Add(label17);
            tabWinMenu.Controls.Add(usrCollect);
            tabWinMenu.Controls.Add(label16);
            tabWinMenu.Controls.Add(rdpSet2Query);
            tabWinMenu.Controls.Add(rdpSet1Query);
            tabWinMenu.Controls.Add(rdpFwRules);
            tabWinMenu.Controls.Add(disableRDP);
            tabWinMenu.Controls.Add(enableRDP);
            tabWinMenu.Controls.Add(label13);
            tabWinMenu.Controls.Add(label12);
            tabWinMenu.Controls.Add(label11);
            tabWinMenu.Controls.Add(stockPwrPlan);
            tabWinMenu.Controls.Add(setMaxPwr);
            tabWinMenu.Controls.Add(panel2);
            tabWinMenu.Controls.Add(pwrCurrentPlan);
            tabWinMenu.Controls.Add(pwrSleep);
            tabWinMenu.Controls.Add(label9);
            tabWinMenu.Controls.Add(pwrScrnOff);
            tabWinMenu.Controls.Add(label6);
            tabWinMenu.Controls.Add(pwrLabel);
            tabWinMenu.Controls.Add(panel5);
            tabWinMenu.Controls.Add(panel6);
            tabWinMenu.Location = new Point(4, 24);
            tabWinMenu.Name = "tabWinMenu";
            tabWinMenu.Size = new Size(500, 411);
            tabWinMenu.TabIndex = 2;
            tabWinMenu.Text = "Windows Config.";
            tabWinMenu.UseVisualStyleBackColor = true;
            tabWinMenu.Click += tabWinMenu_Click;
            // 
            // psLogWindow
            // 
            psLogWindow.AutoSize = true;
            psLogWindow.Location = new Point(526, 33);
            psLogWindow.Name = "psLogWindow";
            psLogWindow.Size = new Size(45, 15);
            psLogWindow.TabIndex = 4;
            psLogWindow.Text = "C# Log";
            // 
            // csLogClear
            // 
            csLogClear.Location = new Point(526, 436);
            csLogClear.Name = "csLogClear";
            csLogClear.Size = new Size(286, 23);
            csLogClear.TabIndex = 42;
            csLogClear.Text = "Clear Log";
            csLogClear.UseVisualStyleBackColor = true;
            csLogClear.Click += csLogClear_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(192, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 376);
            panel3.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Location = new Point(-44, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(588, 1);
            panel4.TabIndex = 31;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.Location = new Point(192, 17);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 376);
            panel5.TabIndex = 32;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DimGray;
            panel6.Location = new Point(-44, 17);
            panel6.Name = "panel6";
            panel6.Size = new Size(588, 1);
            panel6.TabIndex = 31;
            // 
            // pwrLabel
            // 
            pwrLabel.AutoSize = true;
            pwrLabel.Location = new Point(7, 102);
            pwrLabel.Name = "pwrLabel";
            pwrLabel.Size = new Size(112, 15);
            pwrLabel.TabIndex = 33;
            pwrLabel.Text = "Current Power Plan:";
            pwrLabel.Click += pwrLabel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 21);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 34;
            label6.Text = "Screen Off Interval:";
            // 
            // pwrScrnOff
            // 
            pwrScrnOff.AutoSize = true;
            pwrScrnOff.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pwrScrnOff.Location = new Point(7, 36);
            pwrScrnOff.Name = "pwrScrnOff";
            pwrScrnOff.Size = new Size(76, 15);
            pwrScrnOff.TabIndex = 36;
            pwrScrnOff.Text = "Query Failed";
            // 
            // pwrSleep
            // 
            pwrSleep.AutoSize = true;
            pwrSleep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pwrSleep.Location = new Point(7, 77);
            pwrSleep.Name = "pwrSleep";
            pwrSleep.Size = new Size(76, 15);
            pwrSleep.TabIndex = 38;
            pwrSleep.Text = "Query Failed";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 62);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 37;
            label9.Text = "Sleep Interval:";
            // 
            // pwrCurrentPlan
            // 
            pwrCurrentPlan.AutoSize = true;
            pwrCurrentPlan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pwrCurrentPlan.Location = new Point(7, 117);
            pwrCurrentPlan.Name = "pwrCurrentPlan";
            pwrCurrentPlan.Size = new Size(76, 15);
            pwrCurrentPlan.TabIndex = 39;
            pwrCurrentPlan.Text = "Query Failed";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(0, 205);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 1);
            panel2.TabIndex = 32;
            // 
            // setMaxPwr
            // 
            setMaxPwr.Location = new Point(3, 176);
            setMaxPwr.Name = "setMaxPwr";
            setMaxPwr.Size = new Size(183, 23);
            setMaxPwr.TabIndex = 40;
            setMaxPwr.Text = "High Performance Plan";
            setMaxPwr.UseVisualStyleBackColor = true;
            // 
            // stockPwrPlan
            // 
            stockPwrPlan.Location = new Point(3, 147);
            stockPwrPlan.Name = "stockPwrPlan";
            stockPwrPlan.Size = new Size(183, 23);
            stockPwrPlan.TabIndex = 41;
            stockPwrPlan.Text = "Revert to Defaults";
            stockPwrPlan.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 208);
            label11.Name = "label11";
            label11.Size = new Size(145, 15);
            label11.TabIndex = 42;
            label11.Text = "Remote Desktop Protocol:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(29, 321);
            label12.Name = "label12";
            label12.Size = new Size(139, 15);
            label12.TabIndex = 43;
            label12.Text = "Setting 1 (Control Panel):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 364);
            label13.Name = "label13";
            label13.Size = new Size(108, 15);
            label13.TabIndex = 44;
            label13.Text = "Setting 2 (Win10+):";
            // 
            // enableRDP
            // 
            enableRDP.Location = new Point(7, 226);
            enableRDP.Name = "enableRDP";
            enableRDP.Size = new Size(179, 23);
            enableRDP.TabIndex = 45;
            enableRDP.Text = "Enable";
            enableRDP.UseVisualStyleBackColor = true;
            // 
            // disableRDP
            // 
            disableRDP.Location = new Point(7, 255);
            disableRDP.Name = "disableRDP";
            disableRDP.Size = new Size(179, 23);
            disableRDP.TabIndex = 46;
            disableRDP.Text = "Disable";
            disableRDP.UseVisualStyleBackColor = true;
            // 
            // rdpFwRules
            // 
            rdpFwRules.Location = new Point(53, 284);
            rdpFwRules.Name = "rdpFwRules";
            rdpFwRules.Size = new Size(89, 23);
            rdpFwRules.TabIndex = 47;
            rdpFwRules.Text = "Add F/W Rule";
            rdpFwRules.UseVisualStyleBackColor = true;
            // 
            // rdpSet1Query
            // 
            rdpSet1Query.AutoSize = true;
            rdpSet1Query.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdpSet1Query.Location = new Point(58, 341);
            rdpSet1Query.Name = "rdpSet1Query";
            rdpSet1Query.Size = new Size(76, 15);
            rdpSet1Query.TabIndex = 48;
            rdpSet1Query.Text = "Query Failed";
            // 
            // rdpSet2Query
            // 
            rdpSet2Query.AutoSize = true;
            rdpSet2Query.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdpSet2Query.Location = new Point(58, 385);
            rdpSet2Query.Name = "rdpSet2Query";
            rdpSet2Query.Size = new Size(76, 15);
            rdpSet2Query.TabIndex = 49;
            rdpSet2Query.Text = "Query Failed";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(194, 4);
            label16.Name = "label16";
            label16.Size = new Size(106, 15);
            label16.TabIndex = 50;
            label16.Text = "SAM Management";
            // 
            // usrCollect
            // 
            usrCollect.FormattingEnabled = true;
            usrCollect.ItemHeight = 15;
            usrCollect.Location = new Point(199, 47);
            usrCollect.Name = "usrCollect";
            usrCollect.Size = new Size(194, 94);
            usrCollect.TabIndex = 51;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(254, 29);
            label17.Name = "label17";
            label17.Size = new Size(75, 15);
            label17.TabIndex = 52;
            label17.Text = "Users Found:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1, 4);
            label18.Name = "label18";
            label18.Size = new Size(114, 15);
            label18.TabIndex = 53;
            label18.Text = "Power Management";
            // 
            // usrPwConfirm
            // 
            usrPwConfirm.Location = new Point(322, 200);
            usrPwConfirm.Name = "usrPwConfirm";
            usrPwConfirm.Size = new Size(155, 23);
            usrPwConfirm.TabIndex = 61;
            // 
            // usrPw
            // 
            usrPw.Location = new Point(322, 174);
            usrPw.Name = "usrPw";
            usrPw.Size = new Size(155, 23);
            usrPw.TabIndex = 60;
            // 
            // usrName
            // 
            usrName.Location = new Point(322, 148);
            usrName.Name = "usrName";
            usrName.Size = new Size(155, 23);
            usrName.TabIndex = 59;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(199, 203);
            label10.Name = "label10";
            label10.Size = new Size(107, 15);
            label10.TabIndex = 56;
            label10.Text = "Confirm Password:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(199, 177);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 55;
            label14.Text = "Password:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(199, 151);
            label15.Name = "label15";
            label15.Size = new Size(90, 15);
            label15.TabIndex = 54;
            label15.Text = "Account Name:";
            // 
            // isUsrAdmin
            // 
            isUsrAdmin.AutoSize = true;
            isUsrAdmin.Location = new Point(204, 226);
            isUsrAdmin.Name = "isUsrAdmin";
            isUsrAdmin.Size = new Size(99, 19);
            isUsrAdmin.TabIndex = 62;
            isUsrAdmin.Text = "Administrator";
            isUsrAdmin.UseVisualStyleBackColor = true;
            // 
            // isUsrDisabled
            // 
            isUsrDisabled.AutoSize = true;
            isUsrDisabled.Location = new Point(204, 276);
            isUsrDisabled.Name = "isUsrDisabled";
            isUsrDisabled.Size = new Size(71, 19);
            isUsrDisabled.TabIndex = 63;
            isUsrDisabled.Text = "Disabled";
            isUsrDisabled.UseVisualStyleBackColor = true;
            // 
            // openLusrmgr
            // 
            openLusrmgr.Location = new Point(199, 327);
            openLusrmgr.Name = "openLusrmgr";
            openLusrmgr.Size = new Size(122, 23);
            openLusrmgr.TabIndex = 64;
            openLusrmgr.Text = "Local User Manager";
            openLusrmgr.UseVisualStyleBackColor = true;
            // 
            // usrSetPw
            // 
            usrSetPw.Location = new Point(199, 301);
            usrSetPw.Name = "usrSetPw";
            usrSetPw.Size = new Size(122, 23);
            usrSetPw.TabIndex = 65;
            usrSetPw.Text = "Set Password";
            usrSetPw.UseVisualStyleBackColor = true;
            // 
            // resetAllPw
            // 
            resetAllPw.Location = new Point(327, 301);
            resetAllPw.Name = "resetAllPw";
            resetAllPw.Size = new Size(122, 23);
            resetAllPw.TabIndex = 66;
            resetAllPw.Text = "Reset All Passwords";
            resetAllPw.UseVisualStyleBackColor = true;
            // 
            // usrApply
            // 
            usrApply.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            usrApply.Location = new Point(327, 327);
            usrApply.Name = "usrApply";
            usrApply.Size = new Size(122, 23);
            usrApply.TabIndex = 67;
            usrApply.Text = "Apply Changes";
            usrApply.UseVisualStyleBackColor = true;
            // 
            // isUsrRdp
            // 
            isUsrRdp.AutoSize = true;
            isUsrRdp.Location = new Point(204, 251);
            isUsrRdp.Name = "isUsrRdp";
            isUsrRdp.Size = new Size(139, 19);
            isUsrRdp.TabIndex = 68;
            isUsrRdp.Text = "Remote Desktop User";
            isUsrRdp.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DimGray;
            panel7.Location = new Point(192, 364);
            panel7.Name = "panel7";
            panel7.Size = new Size(310, 1);
            panel7.TabIndex = 33;
            // 
            // controlWindowsUpdate
            // 
            controlWindowsUpdate.Location = new Point(347, 367);
            controlWindowsUpdate.Name = "controlWindowsUpdate";
            controlWindowsUpdate.Size = new Size(142, 23);
            controlWindowsUpdate.TabIndex = 70;
            controlWindowsUpdate.Text = "Windows Update";
            controlWindowsUpdate.UseVisualStyleBackColor = true;
            // 
            // scriptWindowsUpdate
            // 
            scriptWindowsUpdate.Location = new Point(199, 367);
            scriptWindowsUpdate.Name = "scriptWindowsUpdate";
            scriptWindowsUpdate.Size = new Size(142, 23);
            scriptWindowsUpdate.TabIndex = 71;
            scriptWindowsUpdate.Text = "Windows Update Script";
            scriptWindowsUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 491);
            Controls.Add(csLogClear);
            Controls.Add(psLogWindow);
            Controls.Add(csLog);
            Controls.Add(tabMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "SAS Configurator";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabMain.ResumeLayout(false);
            tabNwMenu.ResumeLayout(false);
            tabNwMenu.PerformLayout();
            tabAppMenu.ResumeLayout(false);
            tabWinMenu.ResumeLayout(false);
            tabWinMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel tsPsStatLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem shellToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem localUserManagerToolStripMenuItem;
        private ToolStripMenuItem windowsUpdateToolStripMenuItem;
        private ToolStripMenuItem groupPolicyEditorToolStripMenuItem;
        private ToolStripMenuItem diskManagementToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem eventVirewToolStripMenuItem;
        private ToolStripMenuItem saveReportToolStripMenuItem;
        private ToolStripMenuItem openPSWindowToolStripMenuItem;
        private ToolStripMenuItem openCMDWindowToolStripMenuItem;
        private ToolStripMenuItem performanceMonitorToolStripMenuItem;
        private ToolStripMenuItem controlPanelOptionsToolStripMenuItem;
        private ToolStripMenuItem deviceManagerToolStripMenuItem;
        private ToolStripMenuItem mSConfigToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl tabMain;
        private TabPage tabNwMenu;
        private TabPage tabAppMenu;
        private RichTextBox csLog;
        private Label psLogWindow;
        private TabPage tabWinMenu;
        private Label currentHSLabel;
        private TextBox nHostname;
        private Label newHsLabel;
        private Panel sep1;
        private Button newHostname;
        private Label label1;
        private ListBox nwAdapt;
        private Label nicLabel;
        private Panel sep2;
        private Label selAdapt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label wuConnResultLabel;
        private Label extConnResultLabel;
        private TextBox nwDns2;
        private TextBox nwDns1;
        private TextBox deGw;
        private TextBox snMask;
        private TextBox ipAddr;
        private Button resetNwSet;
        private Label wuConnStatus;
        private Label extConnStatus;
        private Button applyNewNwSettings;
        private Button testCurrentNwSet;
        private Label puFirewallStat;
        private Label doFirewallStat;
        private Label pvFirewallStat;
        private Label fwPubStat;
        private Label fwDomainStat;
        private Label fwPrvStat;
        private Label fwStatLabel;
        private Panel panel1;
        private Button fwOptSet;
        private RadioButton fwDisableRadio;
        private RadioButton fwEnableRadio;
        private Button resetQuery;
        private Label cHostName;
        private Button csLogClear;
        private Panel panel3;
        private Panel panel4;
        private Label label6;
        private Label pwrLabel;
        private Panel panel5;
        private Panel panel6;
        private Label pwrCurrentPlan;
        private Label pwrSleep;
        private Label label9;
        private Label pwrScrnOff;
        private Button stockPwrPlan;
        private Button setMaxPwr;
        private Panel panel2;
        private Label rdpSet1Query;
        private Button rdpFwRules;
        private Button disableRDP;
        private Button enableRDP;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label16;
        private Label rdpSet2Query;
        private Label label18;
        private Label label17;
        private ListBox usrCollect;
        private CheckBox isUsrDisabled;
        private CheckBox isUsrAdmin;
        private TextBox usrPwConfirm;
        private TextBox usrPw;
        private TextBox usrName;
        private Label label10;
        private Label label14;
        private Label label15;
        private Button usrSetPw;
        private Button openLusrmgr;
        private Button usrApply;
        private Button resetAllPw;
        private CheckBox isUsrRdp;
        private Panel panel7;
        private Button scriptWindowsUpdate;
        private Button controlWindowsUpdate;
    }
}
