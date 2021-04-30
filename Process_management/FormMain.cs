using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Process_management
{
    public partial class FormMain : Form
    {
        Process[] dfProcess;
        PerformanceCounter pfCUP, pfRam;
        int CountProcess = 0;

        public FormMain()
        {
            InitializeComponent();
            dfProcess = Process.GetProcesses();
            // Load to class
            // CUP
            pfCUP = new PerformanceCounter();
            pfCUP.CategoryName = "Processor";
            pfCUP.CounterName = "% Processor Time";
            pfCUP.InstanceName = "_Total";
            // Memoray
            pfRam = new PerformanceCounter();
            pfRam.CategoryName = "Memory";
            pfRam.CounterName = "Available MBytes";
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerProcess.Start();
            TimerDir.Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerProcess.Stop();
            TimerDir.Stop();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimerMain_Tick(object sender, EventArgs e)
        {
            //Process
            dfProcess = Process.GetProcesses();
            if (dfProcess.Length != CountProcess)
            {
                ListProcess.Items.Clear();
                foreach (var item in dfProcess)
                {
                    ListProcess.Items.Add(item.ProcessName);
                }
                CountProcess = dfProcess.Length;
            }
            ResultPanel.Text = "Time : " + DateTime.Now.ToShortTimeString() + " | Date : " + DateTime.Now.ToShortDateString() + " | Count Process : " + dfProcess.Length;
        }

        private void TimerDir_Tick(object sender, EventArgs e)
        {
            // infomation Driver
            listBoxDir.Items.Clear();
            DriveInfo[] dirve = DriveInfo.GetDrives();
            foreach (DriveInfo item in dirve)
            {
                if (item.IsReady)
                {
                    listBoxDir.Items.Add(("Name : " + item.Name + "  Free Space : " + ((item.TotalFreeSpace / 1024) / 1024) +
                        " MB  " + "  Total Size : " + ((item.TotalSize / 1024) / 1024) / 1024) + " GB".ToString());
                }
            }
            ListBoxInfoSys.Items.Clear();
            // Infomation system
            List<string> list = new List<string>();
            list.Add("Machine Name : " + System.Environment.MachineName);
            list.Add("User Name : " + System.Environment.UserName);
            list.Add("OS Version : " + System.Environment.OSVersion);
            list.Add("Processor Count : " + System.Environment.ProcessorCount);
            list.Add("Total Memory : " + (new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024) + " MB");
            list.Add("Tick Count : " + (System.Environment.TickCount / 1000));
            list.Add("Bit Process : " + (System.Environment.Is64BitOperatingSystem == true ? "64 bit" : "32 bit"));
            list.Add("Screen : " + Screen.PrimaryScreen.Bounds.Size);
            list.Add("Battary Labtop : " + SystemInformation.PowerStatus.BatteryLifePercent * 100 + " %");
            list.Add("Monitor Count : " + SystemInformation.MonitorCount);
            list.Add("Count Process : " + CountProcess);

            foreach (string item in list)
            {
                ListBoxInfoSys.Items.Add(item);
            }
            //CUP
            LabelCPUPerformace.Text = "CPU using : " + pfCUP.NextValue() + " %";
            //Ram
            LabelRamPerformace.Text = "Ram Empty : " + pfRam.NextValue() + " MB";
        }

        private void ListProcess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.End)
            {
                foreach (var item in dfProcess)
                {
                    if (ListProcess.SelectedItem.ToString().ToLower() == item.ProcessName.ToLower())
                    {
                        DialogResult dialog = MessageBox.Show("آیا فرآنید انتخاب شده را پاک میکنید ؟", "حذف فرآنید", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.Yes)
                        {
                            item.Kill();
                        }
                    }
                }
            }
        }

        private void shutDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-s-t 00");
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("shutdonw", "-r -t 00");
        }

        private void sleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Sleep");
        }

        private void ListProcess_Click(object sender, EventArgs e)
        {
            ToolTip toolTipLST = new ToolTip();
            toolTipLST.ToolTipTitle = "Information Of Selecet Process";
            toolTipLST.ToolTipIcon = ToolTipIcon.Info;
            toolTipLST.AutomaticDelay = 100;
            toolTipLST.AutoPopDelay = 10000;
            toolTipLST.UseAnimation = true;
            Process[] GetPro = Process.GetProcesses();

            foreach (Process Pmlist in GetPro)
            {
                if (Pmlist.ProcessName.ToLower() == ListProcess.SelectedItem.ToString().ToLower())
                {
                    try
                    {
                        FileInfo A = new FileInfo(Pmlist.MainModule.FileName);
                        long InfoA = A.Length;
                        long Byte = InfoA / 1024;
                        long KB = Byte / 1024;
                        long MB = KB / 1024;
                        long GB = MB / 1024;
                        string NatResult = "";
                        if (Byte > 0 && Byte < 1024)
                        {
                            NatResult = Byte + " Byte";
                        }
                        else if (KB > 0 && KB < 1024)
                        {
                            NatResult = KB + " KB";

                        }
                        else if (MB > 0 && MB < 1024)
                        {
                            NatResult = MB + " MB";

                        }
                        else if (GB > 0 && GB < 1024)
                        {
                            NatResult = GB + " GB";

                        }
                        toolTipLST.SetToolTip(ListProcess, "Process Name : " + Pmlist.ProcessName + '\r' + "Id Address : " + Pmlist.Id +
                            '\r' + "Address : " + Pmlist.MainModule.FileName + '\r' + "File Name : " + Pmlist.MainModule.FileVersionInfo.OriginalFilename +
                            '\r' + "File Version : " + Pmlist.MainModule.FileVersionInfo.FileVersion + '\r' + "File Size : " + NatResult + '\r' + "Craation Time : " +
                            A.CreationTime + '\r' + "Uear Name : " + Environment.UserName + '\r' + "Computer Name : " + Environment.MachineName);
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application ' Process management '\nDeveloper : Mahdi Khayamdar ", "About me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
