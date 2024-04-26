using System.Windows.Forms;

namespace WinTweakTool
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.DesktopTweaksButton = new System.Windows.Forms.Button();
            this.CommonTweaksButton = new System.Windows.Forms.Button();
            this.WindowsToolsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RestartExplorerButton = new System.Windows.Forms.Button();
            this.ShutdownSchedButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.WinVerText = new System.Windows.Forms.Label();
            this.WebLink = new System.Windows.Forms.LinkLabel();
            this.NotAdminText = new System.Windows.Forms.Label();
            this.TweaksDontApply = new System.Windows.Forms.Label();
            this.DebloaterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DesktopTweaksButton
            // 
            this.DesktopTweaksButton.Location = new System.Drawing.Point(178, 12);
            this.DesktopTweaksButton.Name = "DesktopTweaksButton";
            this.DesktopTweaksButton.Size = new System.Drawing.Size(194, 39);
            this.DesktopTweaksButton.TabIndex = 2;
            this.DesktopTweaksButton.Text = "Desktop tweaks";
            this.DesktopTweaksButton.UseVisualStyleBackColor = true;
            this.DesktopTweaksButton.Click += new System.EventHandler(this.DesktopTweaksButton_Click);
            // 
            // CommonTweaksButton
            // 
            this.CommonTweaksButton.Location = new System.Drawing.Point(178, 63);
            this.CommonTweaksButton.Name = "CommonTweaksButton";
            this.CommonTweaksButton.Size = new System.Drawing.Size(194, 39);
            this.CommonTweaksButton.TabIndex = 3;
            this.CommonTweaksButton.Text = "System tweaks";
            this.CommonTweaksButton.UseVisualStyleBackColor = true;
            this.CommonTweaksButton.Click += new System.EventHandler(this.CommonTweaksButton_Click);
            // 
            // WindowsToolsButton
            // 
            this.WindowsToolsButton.Location = new System.Drawing.Point(178, 233);
            this.WindowsToolsButton.Name = "WindowsToolsButton";
            this.WindowsToolsButton.Size = new System.Drawing.Size(194, 39);
            this.WindowsToolsButton.TabIndex = 5;
            this.WindowsToolsButton.Text = "Windows Tools";
            this.WindowsToolsButton.UseVisualStyleBackColor = true;
            this.WindowsToolsButton.Click += new System.EventHandler(this.WindowsToolsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "WindowsTweakToolkit\r";
            // 
            // RestartExplorerButton
            // 
            this.RestartExplorerButton.Location = new System.Drawing.Point(178, 181);
            this.RestartExplorerButton.Name = "RestartExplorerButton";
            this.RestartExplorerButton.Size = new System.Drawing.Size(194, 39);
            this.RestartExplorerButton.TabIndex = 4;
            this.RestartExplorerButton.Text = "Restart explorer.exe";
            this.RestartExplorerButton.UseVisualStyleBackColor = true;
            this.RestartExplorerButton.Click += new System.EventHandler(this.RestartExplorer_Click);
            // 
            // ShutdownSchedButton
            // 
            this.ShutdownSchedButton.Location = new System.Drawing.Point(178, 283);
            this.ShutdownSchedButton.Name = "ShutdownSchedButton";
            this.ShutdownSchedButton.Size = new System.Drawing.Size(194, 39);
            this.ShutdownSchedButton.TabIndex = 6;
            this.ShutdownSchedButton.Text = "Shutdown scheduler";
            this.ShutdownSchedButton.UseVisualStyleBackColor = true;
            this.ShutdownSchedButton.Click += new System.EventHandler(this.ShutdownSchedButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(4, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "_____________________________________________________________";
            // 
            // WinVerText
            // 
            this.WinVerText.AutoSize = true;
            this.WinVerText.Location = new System.Drawing.Point(10, 86);
            this.WinVerText.Name = "WinVerText";
            this.WinVerText.Size = new System.Drawing.Size(45, 13);
            this.WinVerText.TabIndex = 10;
            this.WinVerText.Text = "WinVer:";
            // 
            // WebLink
            // 
            this.WebLink.AutoSize = true;
            this.WebLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WebLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.WebLink.LinkColor = System.Drawing.Color.Navy;
            this.WebLink.Location = new System.Drawing.Point(10, 307);
            this.WebLink.Name = "WebLink";
            this.WebLink.Size = new System.Drawing.Size(91, 13);
            this.WebLink.TabIndex = 7;
            this.WebLink.TabStop = true;
            this.WebLink.Text = "https://markski.ar";
            this.WebLink.VisitedLinkColor = System.Drawing.Color.Navy;
            this.WebLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebLink_LinkClicked);
            // 
            // NotAdminText
            // 
            this.NotAdminText.AutoSize = true;
            this.NotAdminText.Location = new System.Drawing.Point(10, 49);
            this.NotAdminText.Name = "NotAdminText";
            this.NotAdminText.Size = new System.Drawing.Size(95, 13);
            this.NotAdminText.TabIndex = 12;
            this.NotAdminText.Text = "Running as admin.";
            // 
            // TweaksDontApply
            // 
            this.TweaksDontApply.AutoSize = true;
            this.TweaksDontApply.Location = new System.Drawing.Point(9, 189);
            this.TweaksDontApply.Name = "TweaksDontApply";
            this.TweaksDontApply.Size = new System.Drawing.Size(144, 52);
            this.TweaksDontApply.TabIndex = 13;
            this.TweaksDontApply.Text = "If tweaks don\'t apply, click ->\r\n\r\nIf that doesn\'t work, you may\r\nneed to restart" +
    " your system.";
            // 
            // DebloaterButton
            // 
            this.DebloaterButton.Location = new System.Drawing.Point(178, 114);
            this.DebloaterButton.Name = "DebloaterButton";
            this.DebloaterButton.Size = new System.Drawing.Size(194, 39);
            this.DebloaterButton.TabIndex = 14;
            this.DebloaterButton.Text = "Debloater";
            this.DebloaterButton.UseVisualStyleBackColor = true;
            this.DebloaterButton.Click += new System.EventHandler(this.DebloaterButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(384, 332);
            this.Controls.Add(this.DebloaterButton);
            this.Controls.Add(this.TweaksDontApply);
            this.Controls.Add(this.NotAdminText);
            this.Controls.Add(this.WebLink);
            this.Controls.Add(this.WinVerText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShutdownSchedButton);
            this.Controls.Add(this.RestartExplorerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WindowsToolsButton);
            this.Controls.Add(this.CommonTweaksButton);
            this.Controls.Add(this.DesktopTweaksButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WTTk <vernum>";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button DesktopTweaksButton;
        private Button CommonTweaksButton;
        private Button WindowsToolsButton;
        private Label label2;
        private Button RestartExplorerButton;
        private Button ShutdownSchedButton;
        private Label label3;
        private Label WinVerText;
        private LinkLabel WebLink;
        private Label NotAdminText;
        private Label TweaksDontApply;
        private Button DebloaterButton;
    }
}