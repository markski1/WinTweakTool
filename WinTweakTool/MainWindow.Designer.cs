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
            this.SuspendLayout();
            // 
            // DesktopTweaksButton
            // 
            this.DesktopTweaksButton.Location = new System.Drawing.Point(179, 12);
            this.DesktopTweaksButton.Name = "DesktopTweaksButton";
            this.DesktopTweaksButton.Size = new System.Drawing.Size(194, 39);
            this.DesktopTweaksButton.TabIndex = 2;
            this.DesktopTweaksButton.Text = "Desktop settings";
            this.DesktopTweaksButton.UseVisualStyleBackColor = true;
            this.DesktopTweaksButton.Click += new System.EventHandler(this.DesktopTweaksButton_Click);
            // 
            // CommonTweaksButton
            // 
            this.CommonTweaksButton.Location = new System.Drawing.Point(179, 68);
            this.CommonTweaksButton.Name = "CommonTweaksButton";
            this.CommonTweaksButton.Size = new System.Drawing.Size(194, 39);
            this.CommonTweaksButton.TabIndex = 3;
            this.CommonTweaksButton.Text = "Common tweaks";
            this.CommonTweaksButton.UseVisualStyleBackColor = true;
            this.CommonTweaksButton.Click += new System.EventHandler(this.CommonTweaksButton_Click);
            // 
            // WindowsToolsButton
            // 
            this.WindowsToolsButton.Location = new System.Drawing.Point(179, 122);
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
            this.label2.Size = new System.Drawing.Size(150, 75);
            this.label2.TabIndex = 6;
            this.label2.Text = "WindowsTweakToolkit\r\n\r\nIf changes don\'t apply, try \r\nrestarting explorer.exe with" +
    "\r\nthe button below.";
            // 
            // RestartExplorerButton
            // 
            this.RestartExplorerButton.Location = new System.Drawing.Point(180, 192);
            this.RestartExplorerButton.Name = "RestartExplorerButton";
            this.RestartExplorerButton.Size = new System.Drawing.Size(193, 39);
            this.RestartExplorerButton.TabIndex = 7;
            this.RestartExplorerButton.Text = "Restart explorer.exe";
            this.RestartExplorerButton.UseVisualStyleBackColor = true;
            this.RestartExplorerButton.Click += new System.EventHandler(this.RestartExplorer_Click);
            // 
            // ShutdownSchedButton
            // 
            this.ShutdownSchedButton.Location = new System.Drawing.Point(180, 243);
            this.ShutdownSchedButton.Name = "ShutdownSchedButton";
            this.ShutdownSchedButton.Size = new System.Drawing.Size(193, 39);
            this.ShutdownSchedButton.TabIndex = 8;
            this.ShutdownSchedButton.Text = "Shutdown scheduler";
            this.ShutdownSchedButton.UseVisualStyleBackColor = true;
            this.ShutdownSchedButton.Click += new System.EventHandler(this.ShutdownSchedButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "_______________________________________________________________________";
            // 
            // WinVerText
            // 
            this.WinVerText.AutoSize = true;
            this.WinVerText.Location = new System.Drawing.Point(12, 145);
            this.WinVerText.Name = "WinVerText";
            this.WinVerText.Size = new System.Drawing.Size(47, 15);
            this.WinVerText.TabIndex = 10;
            this.WinVerText.Text = "WinVer:";
            // 
            // WebLink
            // 
            this.WebLink.AutoSize = true;
            this.WebLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.WebLink.LinkColor = System.Drawing.Color.Navy;
            this.WebLink.Location = new System.Drawing.Point(10, 267);
            this.WebLink.Name = "WebLink";
            this.WebLink.Size = new System.Drawing.Size(101, 15);
            this.WebLink.TabIndex = 11;
            this.WebLink.TabStop = true;
            this.WebLink.Text = "https://markski.ar";
            this.WebLink.VisitedLinkColor = System.Drawing.Color.Navy;
            this.WebLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebLink_LinkClicked);
            // 
            // NotAdminText
            // 
            this.NotAdminText.AutoSize = true;
            this.NotAdminText.Location = new System.Drawing.Point(12, 116);
            this.NotAdminText.Name = "NotAdminText";
            this.NotAdminText.Size = new System.Drawing.Size(106, 15);
            this.NotAdminText.TabIndex = 12;
            this.NotAdminText.Text = "Running as admin.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(384, 291);
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
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WTTk 0.3";
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
    }
}