using System;
using System.Windows.Forms;

namespace WinTweakTool
{
	public partial class WindowsTools : Form
	{
		public WindowsTools()
		{
			InitializeComponent();
		}

		private void DskMgrBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process cmd = new System.Diagnostics.Process();
			cmd.StartInfo.UseShellExecute = true;
			cmd.StartInfo.FileName = "diskmgmt.msc";
			cmd.Start();
		}

		private void RegeditBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process cmd = new System.Diagnostics.Process();
			cmd.StartInfo.FileName = "regedit";
			cmd.Start();
		}

		private void DxDiagBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process cmd = new System.Diagnostics.Process();
			cmd.StartInfo.FileName = "dxdiag";
			cmd.Start();
		}

		private void EventVwrBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process cmd = new System.Diagnostics.Process();
			cmd.StartInfo.UseShellExecute = true;
			cmd.StartInfo.FileName = "eventvwr.msc";
			cmd.Start();
		}

		private void MmcBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process cmd = new System.Diagnostics.Process();
			cmd.StartInfo.FileName = "mmc";
			cmd.Start();
		}

		private void DevMgrBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process cmd = new System.Diagnostics.Process();
			cmd.StartInfo.UseShellExecute = true;
			cmd.StartInfo.FileName = "devmgmt.msc";
			cmd.Start();
		}

		private void ResMonBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process cmd = new System.Diagnostics.Process();
			cmd.StartInfo.FileName = "resmon";
			cmd.Start();
		}

		private void SysInfoBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process cmd = new System.Diagnostics.Process();
			cmd.StartInfo.FileName = "msinfo32";
			cmd.Start();
		}

		private void NTConfigBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process cmd = new System.Diagnostics.Process();
			cmd.StartInfo.FileName = "msconfig";
			cmd.Start();
		}

		private void ServicesBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process cmd = new System.Diagnostics.Process();
			cmd.StartInfo.UseShellExecute = true;
			cmd.StartInfo.FileName = "services.msc";
			cmd.Start();
		}
	}
}
