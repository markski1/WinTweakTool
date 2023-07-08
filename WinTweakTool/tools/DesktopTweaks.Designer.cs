using System.Drawing;
using System.Windows.Forms;

namespace WinTweakTool
{
    partial class DesktopTweaks
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
			this.ApplyButton = new System.Windows.Forms.Button();
			this.DesktopIndicator = new System.Windows.Forms.CheckBox();
			this.TaskbarTrans = new System.Windows.Forms.CheckBox();
			this.ClockSeconds = new System.Windows.Forms.CheckBox();
			this.MenuDelay = new System.Windows.Forms.CheckBox();
			this.ShakeMin = new System.Windows.Forms.CheckBox();
			this.ActionCenter = new System.Windows.Forms.CheckBox();
			this.BalloonNotis = new System.Windows.Forms.CheckBox();
			this.HelpBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ApplyButton
			// 
			this.ApplyButton.Location = new System.Drawing.Point(140, 169);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new System.Drawing.Size(64, 24);
			this.ApplyButton.TabIndex = 4;
			this.ApplyButton.Text = "Apply";
			this.ApplyButton.UseVisualStyleBackColor = true;
			this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
			// 
			// DesktopIndicator
			// 
			this.DesktopIndicator.AutoSize = true;
			this.DesktopIndicator.Location = new System.Drawing.Point(10, 10);
			this.DesktopIndicator.Name = "DesktopIndicator";
			this.DesktopIndicator.Size = new System.Drawing.Size(160, 17);
			this.DesktopIndicator.TabIndex = 1;
			this.DesktopIndicator.Text = "Hide shortcut indicator icons";
			this.DesktopIndicator.UseVisualStyleBackColor = true;
			// 
			// TaskbarTrans
			// 
			this.TaskbarTrans.AutoSize = true;
			this.TaskbarTrans.Location = new System.Drawing.Point(10, 32);
			this.TaskbarTrans.Name = "TaskbarTrans";
			this.TaskbarTrans.Size = new System.Drawing.Size(169, 17);
			this.TaskbarTrans.TabIndex = 2;
			this.TaskbarTrans.Text = "Increase taskbar transparency";
			this.TaskbarTrans.UseVisualStyleBackColor = true;
			// 
			// ClockSeconds
			// 
			this.ClockSeconds.AutoSize = true;
			this.ClockSeconds.Location = new System.Drawing.Point(10, 54);
			this.ClockSeconds.Name = "ClockSeconds";
			this.ClockSeconds.Size = new System.Drawing.Size(174, 17);
			this.ClockSeconds.TabIndex = 3;
			this.ClockSeconds.Text = "Show seconds in taskbar clock";
			this.ClockSeconds.UseVisualStyleBackColor = true;
			// 
			// MenuDelay
			// 
			this.MenuDelay.AutoSize = true;
			this.MenuDelay.Location = new System.Drawing.Point(10, 75);
			this.MenuDelay.Name = "MenuDelay";
			this.MenuDelay.Size = new System.Drawing.Size(167, 17);
			this.MenuDelay.TabIndex = 5;
			this.MenuDelay.Text = "Decrease context menu delay";
			this.MenuDelay.UseVisualStyleBackColor = true;
			// 
			// ShakeMin
			// 
			this.ShakeMin.AutoSize = true;
			this.ShakeMin.Location = new System.Drawing.Point(10, 97);
			this.ShakeMin.Name = "ShakeMin";
			this.ShakeMin.Size = new System.Drawing.Size(147, 17);
			this.ShakeMin.TabIndex = 6;
			this.ShakeMin.Text = "Disable shake-to-minimize";
			this.ShakeMin.UseVisualStyleBackColor = true;
			// 
			// ActionCenter
			// 
			this.ActionCenter.AutoSize = true;
			this.ActionCenter.Location = new System.Drawing.Point(10, 119);
			this.ActionCenter.Name = "ActionCenter";
			this.ActionCenter.Size = new System.Drawing.Size(193, 17);
			this.ActionCenter.TabIndex = 7;
			this.ActionCenter.Text = "Disable action center / notifications";
			this.ActionCenter.UseVisualStyleBackColor = true;
			// 
			// BalloonNotis
			// 
			this.BalloonNotis.AutoSize = true;
			this.BalloonNotis.Location = new System.Drawing.Point(10, 140);
			this.BalloonNotis.Name = "BalloonNotis";
			this.BalloonNotis.Size = new System.Drawing.Size(182, 17);
			this.BalloonNotis.TabIndex = 8;
			this.BalloonNotis.Text = "Enable old \"balloon\" notifications";
			this.BalloonNotis.UseVisualStyleBackColor = true;
			// 
			// HelpBtn
			// 
			this.HelpBtn.Location = new System.Drawing.Point(10, 169);
			this.HelpBtn.Name = "HelpBtn";
			this.HelpBtn.Size = new System.Drawing.Size(64, 24);
			this.HelpBtn.TabIndex = 9;
			this.HelpBtn.Text = "Help";
			this.HelpBtn.UseVisualStyleBackColor = true;
			// 
			// DesktopTweaks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 200);
			this.Controls.Add(this.HelpBtn);
			this.Controls.Add(this.BalloonNotis);
			this.Controls.Add(this.ActionCenter);
			this.Controls.Add(this.ShakeMin);
			this.Controls.Add(this.MenuDelay);
			this.Controls.Add(this.ClockSeconds);
			this.Controls.Add(this.TaskbarTrans);
			this.Controls.Add(this.DesktopIndicator);
			this.Controls.Add(this.ApplyButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DesktopTweaks";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Desktop Tweaks";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Button ApplyButton;
        private CheckBox DesktopIndicator;
        private CheckBox TaskbarTrans;
        private CheckBox ClockSeconds;
        private CheckBox MenuDelay;
        private CheckBox ShakeMin;
        private CheckBox ActionCenter;
        private CheckBox BalloonNotis;
        private Button HelpBtn;
    }
}