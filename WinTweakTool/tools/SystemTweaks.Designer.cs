﻿using System.Drawing;
using System.Windows.Forms;

namespace WinTweakTool
{
    partial class SystemTweaks
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
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.WinMan = new System.Windows.Forms.CheckBox();
            this.WinDef = new System.Windows.Forms.CheckBox();
            this.Cortana = new System.Windows.Forms.CheckBox();
            this.SearchNet = new System.Windows.Forms.CheckBox();
            this.StartupDelay = new System.Windows.Forms.CheckBox();
            this.AppTracking = new System.Windows.Forms.CheckBox();
            this.ErrorReporting = new System.Windows.Forms.CheckBox();
            this.StartSuggestions = new System.Windows.Forms.CheckBox();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.UpdateDrivers = new System.Windows.Forms.CheckBox();
            this.ModernStandby = new System.Windows.Forms.CheckBox();
            this.VerboseMode = new System.Windows.Forms.CheckBox();
            this.DisableGameBar = new System.Windows.Forms.CheckBox();
            this.DisableCopilot = new System.Windows.Forms.CheckBox();
            this.DisableLockscreenTips = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(345, 175);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(64, 24);
            this.ApplyBtn.TabIndex = 12;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // WinMan
            // 
            this.WinMan.AutoSize = true;
            this.WinMan.Location = new System.Drawing.Point(9, 10);
            this.WinMan.Name = "WinMan";
            this.WinMan.Size = new System.Drawing.Size(172, 17);
            this.WinMan.TabIndex = 2;
            this.WinMan.Text = "Disable Windows maintenance";
            this.WinMan.UseVisualStyleBackColor = true;
            // 
            // WinDef
            // 
            this.WinDef.AutoSize = true;
            this.WinDef.Location = new System.Drawing.Point(9, 32);
            this.WinDef.Name = "WinDef";
            this.WinDef.Size = new System.Drawing.Size(153, 17);
            this.WinDef.TabIndex = 3;
            this.WinDef.Text = "Disable Windows defender";
            this.WinDef.UseVisualStyleBackColor = true;
            this.WinDef.CheckedChanged += new System.EventHandler(this.WinDef_CheckedChanged);
            // 
            // Cortana
            // 
            this.Cortana.AutoSize = true;
            this.Cortana.Location = new System.Drawing.Point(9, 54);
            this.Cortana.Name = "Cortana";
            this.Cortana.Size = new System.Drawing.Size(101, 17);
            this.Cortana.TabIndex = 4;
            this.Cortana.Text = "Disable Cortana";
            this.Cortana.UseVisualStyleBackColor = true;
            // 
            // SearchNet
            // 
            this.SearchNet.AutoSize = true;
            this.SearchNet.Location = new System.Drawing.Point(9, 75);
            this.SearchNet.Name = "SearchNet";
            this.SearchNet.Size = new System.Drawing.Size(195, 17);
            this.SearchNet.TabIndex = 5;
            this.SearchNet.Text = "Disable Search internet suggestions";
            this.SearchNet.UseVisualStyleBackColor = true;
            // 
            // StartupDelay
            // 
            this.StartupDelay.AutoSize = true;
            this.StartupDelay.Location = new System.Drawing.Point(9, 96);
            this.StartupDelay.Name = "StartupDelay";
            this.StartupDelay.Size = new System.Drawing.Size(124, 17);
            this.StartupDelay.TabIndex = 6;
            this.StartupDelay.Text = "Disable startup delay";
            this.StartupDelay.UseVisualStyleBackColor = true;
            // 
            // AppTracking
            // 
            this.AppTracking.AutoSize = true;
            this.AppTracking.Location = new System.Drawing.Point(9, 119);
            this.AppTracking.Name = "AppTracking";
            this.AppTracking.Size = new System.Drawing.Size(123, 17);
            this.AppTracking.TabIndex = 7;
            this.AppTracking.Text = "Disable app tracking";
            this.AppTracking.UseVisualStyleBackColor = true;
            // 
            // ErrorReporting
            // 
            this.ErrorReporting.AutoSize = true;
            this.ErrorReporting.Location = new System.Drawing.Point(209, 10);
            this.ErrorReporting.Name = "ErrorReporting";
            this.ErrorReporting.Size = new System.Drawing.Size(129, 17);
            this.ErrorReporting.TabIndex = 9;
            this.ErrorReporting.Text = "Disable error reporting";
            this.ErrorReporting.UseVisualStyleBackColor = true;
            // 
            // StartSuggestions
            // 
            this.StartSuggestions.AutoSize = true;
            this.StartSuggestions.Location = new System.Drawing.Point(209, 33);
            this.StartSuggestions.Name = "StartSuggestions";
            this.StartSuggestions.Size = new System.Drawing.Size(208, 17);
            this.StartSuggestions.TabIndex = 10;
            this.StartSuggestions.Text = "Disable app suggestions on start menu";
            this.StartSuggestions.UseVisualStyleBackColor = true;
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(9, 175);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(64, 24);
            this.HelpBtn.TabIndex = 0;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // UpdateDrivers
            // 
            this.UpdateDrivers.AutoSize = true;
            this.UpdateDrivers.Location = new System.Drawing.Point(209, 54);
            this.UpdateDrivers.Name = "UpdateDrivers";
            this.UpdateDrivers.Size = new System.Drawing.Size(180, 17);
            this.UpdateDrivers.TabIndex = 11;
            this.UpdateDrivers.Text = "Disable automatic driver updates";
            this.UpdateDrivers.UseVisualStyleBackColor = true;
            // 
            // ModernStandby
            // 
            this.ModernStandby.AutoSize = true;
            this.ModernStandby.Location = new System.Drawing.Point(209, 75);
            this.ModernStandby.Name = "ModernStandby";
            this.ModernStandby.Size = new System.Drawing.Size(189, 17);
            this.ModernStandby.TabIndex = 13;
            this.ModernStandby.Text = "Disable Windows Modern Standby";
            this.ModernStandby.UseVisualStyleBackColor = true;
            // 
            // VerboseMode
            // 
            this.VerboseMode.AutoSize = true;
            this.VerboseMode.Location = new System.Drawing.Point(209, 119);
            this.VerboseMode.Name = "VerboseMode";
            this.VerboseMode.Size = new System.Drawing.Size(129, 17);
            this.VerboseMode.TabIndex = 14;
            this.VerboseMode.Text = "Enable verbose mode";
            this.VerboseMode.UseVisualStyleBackColor = true;
            // 
            // DisableGameBar
            // 
            this.DisableGameBar.AutoSize = true;
            this.DisableGameBar.Location = new System.Drawing.Point(209, 96);
            this.DisableGameBar.Name = "DisableGameBar";
            this.DisableGameBar.Size = new System.Drawing.Size(108, 17);
            this.DisableGameBar.TabIndex = 15;
            this.DisableGameBar.Text = "Disable GameBar";
            this.DisableGameBar.UseVisualStyleBackColor = true;
            // 
            // DisableCopilot
            // 
            this.DisableCopilot.AutoSize = true;
            this.DisableCopilot.Location = new System.Drawing.Point(9, 142);
            this.DisableCopilot.Name = "DisableCopilot";
            this.DisableCopilot.Size = new System.Drawing.Size(96, 17);
            this.DisableCopilot.TabIndex = 16;
            this.DisableCopilot.Text = "Disable Copilot";
            this.DisableCopilot.UseVisualStyleBackColor = true;
            // 
            // DisableLockscreenTips
            // 
            this.DisableLockscreenTips.AutoSize = true;
            this.DisableLockscreenTips.Location = new System.Drawing.Point(209, 142);
            this.DisableLockscreenTips.Name = "DisableLockscreenTips";
            this.DisableLockscreenTips.Size = new System.Drawing.Size(135, 17);
            this.DisableLockscreenTips.TabIndex = 17;
            this.DisableLockscreenTips.Text = "Disable lockscreen tips";
            this.DisableLockscreenTips.UseVisualStyleBackColor = true;
            // 
            // SystemTweaks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 207);
            this.Controls.Add(this.DisableLockscreenTips);
            this.Controls.Add(this.DisableCopilot);
            this.Controls.Add(this.DisableGameBar);
            this.Controls.Add(this.VerboseMode);
            this.Controls.Add(this.ModernStandby);
            this.Controls.Add(this.UpdateDrivers);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.StartSuggestions);
            this.Controls.Add(this.ErrorReporting);
            this.Controls.Add(this.AppTracking);
            this.Controls.Add(this.StartupDelay);
            this.Controls.Add(this.SearchNet);
            this.Controls.Add(this.Cortana);
            this.Controls.Add(this.WinDef);
            this.Controls.Add(this.WinMan);
            this.Controls.Add(this.ApplyBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemTweaks";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "System Tweaks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ApplyBtn;
        private CheckBox WinMan;
        private CheckBox WinDef;
        private CheckBox Cortana;
        private CheckBox SearchNet;
        private CheckBox StartupDelay;
        private CheckBox AppTracking;
        private CheckBox ErrorReporting;
        private CheckBox StartSuggestions;
        private Button HelpBtn;
        private CheckBox UpdateDrivers;
        private CheckBox ModernStandby;
        private CheckBox VerboseMode;
        private CheckBox DisableGameBar;
        private CheckBox DisableCopilot;
        private CheckBox DisableLockscreenTips;
    }
}