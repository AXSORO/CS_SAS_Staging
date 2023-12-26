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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveReport = new ToolStripMenuItem();
            shellToolStripMenuItem = new ToolStripMenuItem();
            psLaunch = new ToolStripMenuItem();
            cmdLaunch = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            lusrmgrLaunch = new ToolStripMenuItem();
            controlUpdateLaunch = new ToolStripMenuItem();
            gpeditLaunch = new ToolStripMenuItem();
            diskmgmtLaunch = new ToolStripMenuItem();
            eventvwrLaunch = new ToolStripMenuItem();
            perfmonLaunch = new ToolStripMenuItem();
            devmgmtLaunch = new ToolStripMenuItem();
            msconfigLaunch = new ToolStripMenuItem();
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
            panel3 = new Panel();
            panel4 = new Panel();
            tabWinMenu = new TabPage();
            button1 = new Button();
            scriptWindowsUpdate = new Button();
            controlWindowsUpdate = new Button();
            panel7 = new Panel();
            isUsrRdp = new CheckBox();
            usrApply = new Button();
            resetAllPw = new Button();
            usrSetPw = new Button();
            openLusrmgr = new Button();
            isUsrDisabled = new CheckBox();
            isUsrAdmin = new CheckBox();
            usrPwConfirm = new TextBox();
            usrPw = new TextBox();
            usrName = new TextBox();
            label10 = new Label();
            label14 = new Label();
            label15 = new Label();
            label18 = new Label();
            label17 = new Label();
            usrCollect = new ListBox();
            label16 = new Label();
            rdpSetQuery = new Label();
            disableRDP = new Button();
            enableRDP = new Button();
            label12 = new Label();
            label11 = new Label();
            setToHp = new Button();
            setZeroTimeout = new Button();
            panel2 = new Panel();
            pwrCurrentPlan = new Label();
            pwrSleep = new Label();
            label9 = new Label();
            pwrScrnOff = new Label();
            label6 = new Label();
            pwrLabel = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            psLogWindow = new Label();
            csLogClear = new Button();
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveReport });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveReport
            // 
            saveReport.Name = "saveReport";
            saveReport.Size = new Size(180, 22);
            saveReport.Text = "Save Report";
            // 
            // shellToolStripMenuItem
            // 
            shellToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { psLaunch, cmdLaunch });
            shellToolStripMenuItem.Name = "shellToolStripMenuItem";
            shellToolStripMenuItem.Size = new Size(44, 20);
            shellToolStripMenuItem.Text = "Shell";
            // 
            // psLaunch
            // 
            psLaunch.Name = "psLaunch";
            psLaunch.Size = new Size(180, 22);
            psLaunch.Text = "Open P/S Window";
            // 
            // cmdLaunch
            // 
            cmdLaunch.Name = "cmdLaunch";
            cmdLaunch.Size = new Size(180, 22);
            cmdLaunch.Text = "Open CMD Window";
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lusrmgrLaunch, controlUpdateLaunch, gpeditLaunch, diskmgmtLaunch, eventvwrLaunch, perfmonLaunch, devmgmtLaunch, msconfigLaunch });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(68, 20);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // lusrmgrLaunch
            // 
            lusrmgrLaunch.Name = "lusrmgrLaunch";
            lusrmgrLaunch.Size = new Size(188, 22);
            lusrmgrLaunch.Text = "Local User Manager";
            // 
            // controlUpdateLaunch
            // 
            controlUpdateLaunch.Name = "controlUpdateLaunch";
            controlUpdateLaunch.Size = new Size(188, 22);
            controlUpdateLaunch.Text = "Windows Update";
            // 
            // gpeditLaunch
            // 
            gpeditLaunch.Name = "gpeditLaunch";
            gpeditLaunch.Size = new Size(188, 22);
            gpeditLaunch.Text = "Group Policy Editor";
            // 
            // diskmgmtLaunch
            // 
            diskmgmtLaunch.Name = "diskmgmtLaunch";
            diskmgmtLaunch.Size = new Size(188, 22);
            diskmgmtLaunch.Text = "Disk Management";
            // 
            // eventvwrLaunch
            // 
            eventvwrLaunch.Name = "eventvwrLaunch";
            eventvwrLaunch.Size = new Size(188, 22);
            eventvwrLaunch.Text = "Event Viewer";
            eventvwrLaunch.Click += eventVirewToolStripMenuItem_Click;
            // 
            // perfmonLaunch
            // 
            perfmonLaunch.Name = "perfmonLaunch";
            perfmonLaunch.Size = new Size(188, 22);
            perfmonLaunch.Text = "Performance Monitor";
            // 
            // devmgmtLaunch
            // 
            devmgmtLaunch.Name = "devmgmtLaunch";
            devmgmtLaunch.Size = new Size(188, 22);
            devmgmtLaunch.Text = "Device Manager";
            // 
            // msconfigLaunch
            // 
            msconfigLaunch.Name = "msconfigLaunch";
            msconfigLaunch.Size = new Size(188, 22);
            msconfigLaunch.Text = "MSConfig";
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
            aboutToolStripMenuItem.Size = new Size(180, 22);
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
            // tabWinMenu
            // 
            tabWinMenu.Controls.Add(button1);
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
            tabWinMenu.Controls.Add(rdpSetQuery);
            tabWinMenu.Controls.Add(disableRDP);
            tabWinMenu.Controls.Add(enableRDP);
            tabWinMenu.Controls.Add(label12);
            tabWinMenu.Controls.Add(label11);
            tabWinMenu.Controls.Add(setToHp);
            tabWinMenu.Controls.Add(setZeroTimeout);
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
            // button1
            // 
            button1.Location = new Point(7, 385);
            button1.Name = "button1";
            button1.Size = new Size(179, 23);
            button1.TabIndex = 72;
            button1.Text = "Re-Run Query";
            button1.UseVisualStyleBackColor = true;
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
            // controlWindowsUpdate
            // 
            controlWindowsUpdate.Location = new Point(347, 367);
            controlWindowsUpdate.Name = "controlWindowsUpdate";
            controlWindowsUpdate.Size = new Size(142, 23);
            controlWindowsUpdate.TabIndex = 70;
            controlWindowsUpdate.Text = "Windows Update";
            controlWindowsUpdate.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DimGray;
            panel7.Location = new Point(192, 364);
            panel7.Name = "panel7";
            panel7.Size = new Size(310, 1);
            panel7.TabIndex = 33;
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
            // resetAllPw
            // 
            resetAllPw.Location = new Point(327, 301);
            resetAllPw.Name = "resetAllPw";
            resetAllPw.Size = new Size(122, 23);
            resetAllPw.TabIndex = 66;
            resetAllPw.Text = "Reset All Passwords";
            resetAllPw.UseVisualStyleBackColor = true;
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
            // openLusrmgr
            // 
            openLusrmgr.Location = new Point(199, 327);
            openLusrmgr.Name = "openLusrmgr";
            openLusrmgr.Size = new Size(122, 23);
            openLusrmgr.TabIndex = 64;
            openLusrmgr.Text = "Local User Manager";
            openLusrmgr.UseVisualStyleBackColor = true;
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
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1, 4);
            label18.Name = "label18";
            label18.Size = new Size(114, 15);
            label18.TabIndex = 53;
            label18.Text = "Power Management";
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
            // usrCollect
            // 
            usrCollect.FormattingEnabled = true;
            usrCollect.ItemHeight = 15;
            usrCollect.Location = new Point(199, 47);
            usrCollect.Name = "usrCollect";
            usrCollect.Size = new Size(194, 94);
            usrCollect.TabIndex = 51;
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
            // rdpSetQuery
            // 
            rdpSetQuery.AutoSize = true;
            rdpSetQuery.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdpSetQuery.Location = new Point(7, 301);
            rdpSetQuery.Name = "rdpSetQuery";
            rdpSetQuery.Size = new Size(76, 15);
            rdpSetQuery.TabIndex = 48;
            rdpSetQuery.Text = "Query Failed";
            // 
            // disableRDP
            // 
            disableRDP.Location = new Point(7, 255);
            disableRDP.Name = "disableRDP";
            disableRDP.Size = new Size(179, 23);
            disableRDP.TabIndex = 46;
            disableRDP.Text = "Disable";
            disableRDP.UseVisualStyleBackColor = true;
            disableRDP.Click += disableRDP_Click;
            // 
            // enableRDP
            // 
            enableRDP.Location = new Point(7, 226);
            enableRDP.Name = "enableRDP";
            enableRDP.Size = new Size(179, 23);
            enableRDP.TabIndex = 45;
            enableRDP.Text = "Enable";
            enableRDP.UseVisualStyleBackColor = true;
            enableRDP.Click += enableRDP_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 281);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 43;
            label12.Text = "RDP Status:";
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
            // setToHp
            // 
            setToHp.Location = new Point(5, 147);
            setToHp.Name = "setToHp";
            setToHp.Size = new Size(183, 23);
            setToHp.TabIndex = 41;
            setToHp.Text = "Set to High Performance ";
            setToHp.UseVisualStyleBackColor = true;
            setToHp.Click += setToHp_Click;
            // 
            // setZeroTimeout
            // 
            setZeroTimeout.Location = new Point(5, 176);
            setZeroTimeout.Name = "setZeroTimeout";
            setZeroTimeout.Size = new Size(183, 23);
            setZeroTimeout.TabIndex = 40;
            setZeroTimeout.Text = "Set Timeouts to 0";
            setZeroTimeout.UseVisualStyleBackColor = true;
            setZeroTimeout.Click += setZeroTimeout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(0, 205);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 1);
            panel2.TabIndex = 32;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 21);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 34;
            label6.Text = "Screen Off Interval:";
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem shellToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem lusrmgrLaunch;
        private ToolStripMenuItem controlUpdateLaunch;
        private ToolStripMenuItem gpeditLaunch;
        private ToolStripMenuItem diskmgmtLaunch;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem eventvwrLaunch;
        private ToolStripMenuItem saveReport;
        private ToolStripMenuItem psLaunch;
        private ToolStripMenuItem cmdLaunch;
        private ToolStripMenuItem perfmonLaunch;
        private ToolStripMenuItem devmgmtLaunch;
        private ToolStripMenuItem msconfigLaunch;
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
        private Button setToHp;
        private Button setZeroTimeout;
        private Panel panel2;
        private Label rdpSetQuery;
        private Button disableRDP;
        private Button enableRDP;
        private Label label12;
        private Label label11;
        private Label label16;
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
        private Button button1;
    }
}
