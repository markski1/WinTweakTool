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
            ApplyBtn = new Button();
            WinMan = new CheckBox();
            WinDef = new CheckBox();
            Cortana = new CheckBox();
            SearchNet = new CheckBox();
            StartupDelay = new CheckBox();
            AppTracking = new CheckBox();
            ErrorReporting = new CheckBox();
            StartSuggestions = new CheckBox();
            HelpBtn = new Button();
            UpdateDrivers = new CheckBox();
            ModernStandby = new CheckBox();
            VerboseMode = new CheckBox();
            SuspendLayout();
            // 
            // ApplyBtn
            // 
            ApplyBtn.Location = new Point(389, 176);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(75, 23);
            ApplyBtn.TabIndex = 12;
            ApplyBtn.Text = "Apply";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // WinMan
            // 
            WinMan.AutoSize = true;
            WinMan.Location = new Point(12, 12);
            WinMan.Name = "WinMan";
            WinMan.Size = new Size(188, 19);
            WinMan.TabIndex = 2;
            WinMan.Text = "Disable Windows maintenance";
            WinMan.UseVisualStyleBackColor = true;
            // 
            // WinDef
            // 
            WinDef.AutoSize = true;
            WinDef.Location = new Point(12, 37);
            WinDef.Name = "WinDef";
            WinDef.Size = new Size(166, 19);
            WinDef.TabIndex = 3;
            WinDef.Text = "Disable Windows defender";
            WinDef.UseVisualStyleBackColor = true;
            WinDef.CheckedChanged += WinDef_CheckedChanged;
            // 
            // Cortana
            // 
            Cortana.AutoSize = true;
            Cortana.Location = new Point(12, 62);
            Cortana.Name = "Cortana";
            Cortana.Size = new Size(109, 19);
            Cortana.TabIndex = 4;
            Cortana.Text = "Disable Cortana";
            Cortana.UseVisualStyleBackColor = true;
            // 
            // SearchNet
            // 
            SearchNet.AutoSize = true;
            SearchNet.Location = new Point(12, 87);
            SearchNet.Name = "SearchNet";
            SearchNet.Size = new Size(212, 19);
            SearchNet.TabIndex = 5;
            SearchNet.Text = "Disable Search internet suggestions";
            SearchNet.UseVisualStyleBackColor = true;
            // 
            // StartupDelay
            // 
            StartupDelay.AutoSize = true;
            StartupDelay.Location = new Point(12, 112);
            StartupDelay.Name = "StartupDelay";
            StartupDelay.Size = new Size(135, 19);
            StartupDelay.TabIndex = 6;
            StartupDelay.Text = "Disable startup delay";
            StartupDelay.UseVisualStyleBackColor = true;
            // 
            // AppTracking
            // 
            AppTracking.AutoSize = true;
            AppTracking.Location = new Point(12, 137);
            AppTracking.Name = "AppTracking";
            AppTracking.Size = new Size(133, 19);
            AppTracking.TabIndex = 7;
            AppTracking.Text = "Disable app tracking";
            AppTracking.UseVisualStyleBackColor = true;
            // 
            // ErrorReporting
            // 
            ErrorReporting.AutoSize = true;
            ErrorReporting.Location = new Point(234, 12);
            ErrorReporting.Name = "ErrorReporting";
            ErrorReporting.Size = new Size(144, 19);
            ErrorReporting.TabIndex = 9;
            ErrorReporting.Text = "Disable error reporting";
            ErrorReporting.UseVisualStyleBackColor = true;
            // 
            // StartSuggestions
            // 
            StartSuggestions.AutoSize = true;
            StartSuggestions.Location = new Point(234, 37);
            StartSuggestions.Name = "StartSuggestions";
            StartSuggestions.Size = new Size(230, 19);
            StartSuggestions.TabIndex = 10;
            StartSuggestions.Text = "Disable app suggestions on start menu";
            StartSuggestions.UseVisualStyleBackColor = true;
            // 
            // HelpBtn
            // 
            HelpBtn.Location = new Point(12, 176);
            HelpBtn.Name = "HelpBtn";
            HelpBtn.Size = new Size(75, 23);
            HelpBtn.TabIndex = 0;
            HelpBtn.Text = "Help";
            HelpBtn.UseVisualStyleBackColor = true;
            HelpBtn.Click += HelpBtn_Click;
            // 
            // UpdateDrivers
            // 
            UpdateDrivers.AutoSize = true;
            UpdateDrivers.Location = new Point(234, 62);
            UpdateDrivers.Name = "UpdateDrivers";
            UpdateDrivers.Size = new Size(199, 19);
            UpdateDrivers.TabIndex = 11;
            UpdateDrivers.Text = "Disable automatic driver updates";
            UpdateDrivers.UseVisualStyleBackColor = true;
            // 
            // ModernStandby
            // 
            ModernStandby.AutoSize = true;
            ModernStandby.Location = new Point(234, 87);
            ModernStandby.Name = "ModernStandby";
            ModernStandby.Size = new Size(207, 19);
            ModernStandby.TabIndex = 13;
            ModernStandby.Text = "Disable Windows Modern Standby";
            ModernStandby.UseVisualStyleBackColor = true;
            // 
            // VerboseMode
            // 
            VerboseMode.AutoSize = true;
            VerboseMode.Location = new Point(234, 112);
            VerboseMode.Name = "VerboseMode";
            VerboseMode.Size = new Size(139, 19);
            VerboseMode.TabIndex = 14;
            VerboseMode.Text = "Enable verbose mode";
            VerboseMode.UseVisualStyleBackColor = true;
            // 
            // SystemTweaks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 211);
            Controls.Add(VerboseMode);
            Controls.Add(ModernStandby);
            Controls.Add(UpdateDrivers);
            Controls.Add(HelpBtn);
            Controls.Add(StartSuggestions);
            Controls.Add(ErrorReporting);
            Controls.Add(AppTracking);
            Controls.Add(StartupDelay);
            Controls.Add(SearchNet);
            Controls.Add(Cortana);
            Controls.Add(WinDef);
            Controls.Add(WinMan);
            Controls.Add(ApplyBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SystemTweaks";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "System Tweaks";
            ResumeLayout(false);
            PerformLayout();
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
    }
}