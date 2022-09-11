﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTweakTool
{
    public partial class WinToolsWindow : Form
    {
        public WinToolsWindow()
        {
            InitializeComponent();
        }

        private void DskMgrBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new();
            cmd.StartInfo.UseShellExecute = true;
            cmd.StartInfo.FileName = "diskmgmt.msc";
            cmd.Start();
        }

        private void RegeditBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new();
            cmd.StartInfo.FileName = "regedit";
            cmd.Start();
        }

        private void DxDiagBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new();
            cmd.StartInfo.FileName = "dxdiag";
            cmd.Start();
        }

        private void EventVwrBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new();
            cmd.StartInfo.UseShellExecute = true;
            cmd.StartInfo.FileName = "eventvwr.msc";
            cmd.Start();
        }

        private void MmcBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new();
            cmd.StartInfo.FileName = "mmc";
            cmd.Start();
        }

        private void DevMgrBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new();
            cmd.StartInfo.UseShellExecute = true;
            cmd.StartInfo.FileName = "devmgmt.msc";
            cmd.Start();
        }

        private void ResMonBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new();
            cmd.StartInfo.FileName = "resmon";
            cmd.Start();
        }

        private void SysInfoBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new();
            cmd.StartInfo.FileName = "msinfo32";
            cmd.Start();
        }

        private void NTConfigBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new();
            cmd.StartInfo.FileName = "msconfig";
            cmd.Start();
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new();
            cmd.StartInfo.UseShellExecute = true;
            cmd.StartInfo.FileName = "services.msc";
            cmd.Start();
        }
    }
}
