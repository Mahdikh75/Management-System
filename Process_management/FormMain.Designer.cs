namespace Process_management
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabPageInfoHardware = new System.Windows.Forms.TabPage();
            this.GroupBoxDir = new System.Windows.Forms.GroupBox();
            this.listBoxDir = new System.Windows.Forms.ListBox();
            this.GroupBoxRam = new System.Windows.Forms.GroupBox();
            this.LabelRamPerformace = new System.Windows.Forms.Label();
            this.GroupBoxCpu = new System.Windows.Forms.GroupBox();
            this.LabelCPUPerformace = new System.Windows.Forms.Label();
            this.TabPageInfomation_System = new System.Windows.Forms.TabPage();
            this.ListBoxInfoSys = new System.Windows.Forms.ListBox();
            this.TabPageProecss = new System.Windows.Forms.TabPage();
            this.ListProcess = new System.Windows.Forms.ListBox();
            this.TimerProcess = new System.Windows.Forms.Timer(this.components);
            this.ToolTipPM = new System.Windows.Forms.ToolTip(this.components);
            this.SSPanel = new System.Windows.Forms.StatusStrip();
            this.ResultPanel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerDir = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.TabControlMain.SuspendLayout();
            this.TabPageInfoHardware.SuspendLayout();
            this.GroupBoxDir.SuspendLayout();
            this.GroupBoxRam.SuspendLayout();
            this.GroupBoxCpu.SuspendLayout();
            this.TabPageInfomation_System.SuspendLayout();
            this.TabPageProecss.SuspendLayout();
            this.SSPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.managerToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(497, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutDownToolStripMenuItem,
            this.sleepToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem1.Text = "Tools";
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.shutDownToolStripMenuItem.Text = "Shut down";
            this.shutDownToolStripMenuItem.Click += new System.EventHandler(this.shutDownToolStripMenuItem_Click);
            // 
            // sleepToolStripMenuItem
            // 
            this.sleepToolStripMenuItem.Name = "sleepToolStripMenuItem";
            this.sleepToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sleepToolStripMenuItem.Text = "Sleep";
            this.sleepToolStripMenuItem.Click += new System.EventHandler(this.sleepToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.managerToolStripMenuItem.Text = "Manager";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutMeToolStripMenuItem.Text = "About me";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabPageInfoHardware);
            this.TabControlMain.Controls.Add(this.TabPageInfomation_System);
            this.TabControlMain.Controls.Add(this.TabPageProecss);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlMain.Location = new System.Drawing.Point(0, 24);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(497, 340);
            this.TabControlMain.TabIndex = 1;
            // 
            // TabPageInfoHardware
            // 
            this.TabPageInfoHardware.Controls.Add(this.GroupBoxDir);
            this.TabPageInfoHardware.Controls.Add(this.GroupBoxRam);
            this.TabPageInfoHardware.Controls.Add(this.GroupBoxCpu);
            this.TabPageInfoHardware.Location = new System.Drawing.Point(4, 25);
            this.TabPageInfoHardware.Name = "TabPageInfoHardware";
            this.TabPageInfoHardware.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageInfoHardware.Size = new System.Drawing.Size(489, 311);
            this.TabPageInfoHardware.TabIndex = 0;
            this.TabPageInfoHardware.Text = "Infomation Hardware";
            this.TabPageInfoHardware.UseVisualStyleBackColor = true;
            // 
            // GroupBoxDir
            // 
            this.GroupBoxDir.Controls.Add(this.listBoxDir);
            this.GroupBoxDir.Location = new System.Drawing.Point(12, 143);
            this.GroupBoxDir.Name = "GroupBoxDir";
            this.GroupBoxDir.Size = new System.Drawing.Size(466, 146);
            this.GroupBoxDir.TabIndex = 0;
            this.GroupBoxDir.TabStop = false;
            this.GroupBoxDir.Text = "Driver";
            // 
            // listBoxDir
            // 
            this.listBoxDir.FormattingEnabled = true;
            this.listBoxDir.ItemHeight = 16;
            this.listBoxDir.Location = new System.Drawing.Point(9, 31);
            this.listBoxDir.Name = "listBoxDir";
            this.listBoxDir.Size = new System.Drawing.Size(451, 100);
            this.listBoxDir.TabIndex = 1;
            // 
            // GroupBoxRam
            // 
            this.GroupBoxRam.Controls.Add(this.LabelRamPerformace);
            this.GroupBoxRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxRam.Location = new System.Drawing.Point(248, 6);
            this.GroupBoxRam.Name = "GroupBoxRam";
            this.GroupBoxRam.Size = new System.Drawing.Size(230, 131);
            this.GroupBoxRam.TabIndex = 2;
            this.GroupBoxRam.TabStop = false;
            this.GroupBoxRam.Text = "RAM";
            // 
            // LabelRamPerformace
            // 
            this.LabelRamPerformace.AutoSize = true;
            this.LabelRamPerformace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRamPerformace.Location = new System.Drawing.Point(18, 52);
            this.LabelRamPerformace.Name = "LabelRamPerformace";
            this.LabelRamPerformace.Size = new System.Drawing.Size(86, 18);
            this.LabelRamPerformace.TabIndex = 2;
            this.LabelRamPerformace.Text = "Performace";
            // 
            // GroupBoxCpu
            // 
            this.GroupBoxCpu.Controls.Add(this.LabelCPUPerformace);
            this.GroupBoxCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCpu.Location = new System.Drawing.Point(12, 6);
            this.GroupBoxCpu.Name = "GroupBoxCpu";
            this.GroupBoxCpu.Size = new System.Drawing.Size(230, 131);
            this.GroupBoxCpu.TabIndex = 2;
            this.GroupBoxCpu.TabStop = false;
            this.GroupBoxCpu.Text = "CPU";
            // 
            // LabelCPUPerformace
            // 
            this.LabelCPUPerformace.AutoSize = true;
            this.LabelCPUPerformace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCPUPerformace.Location = new System.Drawing.Point(15, 52);
            this.LabelCPUPerformace.Name = "LabelCPUPerformace";
            this.LabelCPUPerformace.Size = new System.Drawing.Size(94, 18);
            this.LabelCPUPerformace.TabIndex = 3;
            this.LabelCPUPerformace.Text = "Performance";
            // 
            // TabPageInfomation_System
            // 
            this.TabPageInfomation_System.Controls.Add(this.ListBoxInfoSys);
            this.TabPageInfomation_System.Location = new System.Drawing.Point(4, 25);
            this.TabPageInfomation_System.Name = "TabPageInfomation_System";
            this.TabPageInfomation_System.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageInfomation_System.Size = new System.Drawing.Size(489, 311);
            this.TabPageInfomation_System.TabIndex = 2;
            this.TabPageInfomation_System.Text = "Infomation System";
            this.TabPageInfomation_System.UseVisualStyleBackColor = true;
            // 
            // ListBoxInfoSys
            // 
            this.ListBoxInfoSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxInfoSys.FormattingEnabled = true;
            this.ListBoxInfoSys.ItemHeight = 18;
            this.ListBoxInfoSys.Location = new System.Drawing.Point(8, 6);
            this.ListBoxInfoSys.Name = "ListBoxInfoSys";
            this.ListBoxInfoSys.Size = new System.Drawing.Size(475, 274);
            this.ListBoxInfoSys.TabIndex = 0;
            // 
            // TabPageProecss
            // 
            this.TabPageProecss.Controls.Add(this.ListProcess);
            this.TabPageProecss.Location = new System.Drawing.Point(4, 25);
            this.TabPageProecss.Name = "TabPageProecss";
            this.TabPageProecss.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageProecss.Size = new System.Drawing.Size(489, 311);
            this.TabPageProecss.TabIndex = 1;
            this.TabPageProecss.Text = "Process";
            this.TabPageProecss.UseVisualStyleBackColor = true;
            // 
            // ListProcess
            // 
            this.ListProcess.Font = new System.Drawing.Font("IRAN Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProcess.FormattingEnabled = true;
            this.ListProcess.ItemHeight = 23;
            this.ListProcess.Location = new System.Drawing.Point(8, 6);
            this.ListProcess.Name = "ListProcess";
            this.ListProcess.Size = new System.Drawing.Size(473, 280);
            this.ListProcess.TabIndex = 0;
            this.ListProcess.Click += new System.EventHandler(this.ListProcess_Click);
            this.ListProcess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListProcess_KeyDown);
            // 
            // TimerProcess
            // 
            this.TimerProcess.Enabled = true;
            this.TimerProcess.Interval = 500;
            this.TimerProcess.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // SSPanel
            // 
            this.SSPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.SSPanel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SSPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResultPanel});
            this.SSPanel.Location = new System.Drawing.Point(0, 342);
            this.SSPanel.Name = "SSPanel";
            this.SSPanel.Size = new System.Drawing.Size(497, 22);
            this.SSPanel.TabIndex = 2;
            this.SSPanel.Text = "Panel";
            // 
            // ResultPanel
            // 
            this.ResultPanel.ForeColor = System.Drawing.Color.Snow;
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(0, 17);
            // 
            // TimerDir
            // 
            this.TimerDir.Enabled = true;
            this.TimerDir.Interval = 1000;
            this.TimerDir.Tick += new System.EventHandler(this.TimerDir_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 364);
            this.Controls.Add(this.SSPanel);
            this.Controls.Add(this.TabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System management";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.TabControlMain.ResumeLayout(false);
            this.TabPageInfoHardware.ResumeLayout(false);
            this.GroupBoxDir.ResumeLayout(false);
            this.GroupBoxRam.ResumeLayout(false);
            this.GroupBoxRam.PerformLayout();
            this.GroupBoxCpu.ResumeLayout(false);
            this.GroupBoxCpu.PerformLayout();
            this.TabPageInfomation_System.ResumeLayout(false);
            this.TabPageProecss.ResumeLayout(false);
            this.SSPanel.ResumeLayout(false);
            this.SSPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabPageInfoHardware;
        private System.Windows.Forms.TabPage TabPageProecss;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer TimerProcess;
        private System.Windows.Forms.ToolTip ToolTipPM;
        private System.Windows.Forms.GroupBox GroupBoxCpu;
        private System.Windows.Forms.GroupBox GroupBoxRam;
        private System.Windows.Forms.GroupBox GroupBoxDir;
        private System.Windows.Forms.Label LabelRamPerformace;
        private System.Windows.Forms.Label LabelCPUPerformace;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip SSPanel;
        private System.Windows.Forms.ToolStripStatusLabel ResultPanel;
        private System.Windows.Forms.ListBox listBoxDir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sleepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage TabPageInfomation_System;
        private System.Windows.Forms.ListBox ListBoxInfoSys;
        private System.Windows.Forms.ListBox ListProcess;
        private System.Windows.Forms.Timer TimerDir;
    }
}

