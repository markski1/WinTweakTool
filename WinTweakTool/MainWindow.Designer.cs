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
            this.label1 = new System.Windows.Forms.Label();
            this.DesktopTweaksButton = new System.Windows.Forms.Button();
            this.CommonTweaksButton = new System.Windows.Forms.Button();
            this.WindowsToolsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RestartExplorerButton = new System.Windows.Forms.Button();
            this.ShutdownSchedButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "https://markski.ar";
            // 
            // DesktopTweaksButton
            // 
            this.DesktopTweaksButton.Location = new System.Drawing.Point(179, 12);
            this.DesktopTweaksButton.Name = "DesktopTweaksButton";
            this.DesktopTweaksButton.Size = new System.Drawing.Size(246, 39);
            this.DesktopTweaksButton.TabIndex = 2;
            this.DesktopTweaksButton.Text = "Desktop settings";
            this.DesktopTweaksButton.UseVisualStyleBackColor = true;
            // 
            // CommonTweaksButton
            // 
            this.CommonTweaksButton.Location = new System.Drawing.Point(179, 72);
            this.CommonTweaksButton.Name = "CommonTweaksButton";
            this.CommonTweaksButton.Size = new System.Drawing.Size(246, 39);
            this.CommonTweaksButton.TabIndex = 3;
            this.CommonTweaksButton.Text = "Common tweaks";
            this.CommonTweaksButton.UseVisualStyleBackColor = true;
            // 
            // WindowsToolsButton
            // 
            this.WindowsToolsButton.Location = new System.Drawing.Point(12, 223);
            this.WindowsToolsButton.Name = "WindowsToolsButton";
            this.WindowsToolsButton.Size = new System.Drawing.Size(201, 39);
            this.WindowsToolsButton.TabIndex = 5;
            this.WindowsToolsButton.Text = "Windows Tools";
            this.WindowsToolsButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 105);
            this.label2.TabIndex = 6;
            this.label2.Text = "WindowsTweakToolkit v0.1\r\n\r\nSystem Specifications\r\n\r\nWindows 10 21H2\r\n16824 MB RA" +
    "M\r\nIntel i7 7700HQ";
            // 
            // RestartExplorerButton
            // 
            this.RestartExplorerButton.Location = new System.Drawing.Point(224, 223);
            this.RestartExplorerButton.Name = "RestartExplorerButton";
            this.RestartExplorerButton.Size = new System.Drawing.Size(201, 39);
            this.RestartExplorerButton.TabIndex = 7;
            this.RestartExplorerButton.Text = "Restart explorer.exe";
            this.RestartExplorerButton.UseVisualStyleBackColor = true;
            this.RestartExplorerButton.Click += new System.EventHandler(this.RestartExplorer_Click);
            // 
            // ShutdownSchedButton
            // 
            this.ShutdownSchedButton.Location = new System.Drawing.Point(224, 268);
            this.ShutdownSchedButton.Name = "ShutdownSchedButton";
            this.ShutdownSchedButton.Size = new System.Drawing.Size(201, 39);
            this.ShutdownSchedButton.TabIndex = 8;
            this.ShutdownSchedButton.Text = "Shutdown scheduler";
            this.ShutdownSchedButton.UseVisualStyleBackColor = true;
            this.ShutdownSchedButton.Click += new System.EventHandler(this.ShutdownSchedButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(437, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShutdownSchedButton);
            this.Controls.Add(this.RestartExplorerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WindowsToolsButton);
            this.Controls.Add(this.CommonTweaksButton);
            this.Controls.Add(this.DesktopTweaksButton);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "WTTk 0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button DesktopTweaksButton;
        private Button CommonTweaksButton;
        private Button WindowsToolsButton;
        private Label label2;
        private Button RestartExplorerButton;
        private Button ShutdownSchedButton;
        private Label label3;
    }
}