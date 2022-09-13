namespace WinTweakTool
{
    partial class CommonTweaksWindow
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
            this.SuspendLayout();
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(163, 222);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(75, 23);
            this.ApplyBtn.TabIndex = 0;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // WinMan
            // 
            this.WinMan.AutoSize = true;
            this.WinMan.Location = new System.Drawing.Point(12, 12);
            this.WinMan.Name = "WinMan";
            this.WinMan.Size = new System.Drawing.Size(188, 19);
            this.WinMan.TabIndex = 2;
            this.WinMan.Text = "Disable Windows maintenance";
            this.WinMan.UseVisualStyleBackColor = true;
            // 
            // WinDef
            // 
            this.WinDef.AutoSize = true;
            this.WinDef.Location = new System.Drawing.Point(12, 37);
            this.WinDef.Name = "WinDef";
            this.WinDef.Size = new System.Drawing.Size(166, 19);
            this.WinDef.TabIndex = 3;
            this.WinDef.Text = "Disable Windows defender";
            this.WinDef.UseVisualStyleBackColor = true;
            // 
            // Cortana
            // 
            this.Cortana.AutoSize = true;
            this.Cortana.Location = new System.Drawing.Point(12, 62);
            this.Cortana.Name = "Cortana";
            this.Cortana.Size = new System.Drawing.Size(109, 19);
            this.Cortana.TabIndex = 4;
            this.Cortana.Text = "Disable Cortana";
            this.Cortana.UseVisualStyleBackColor = true;
            // 
            // SearchNet
            // 
            this.SearchNet.AutoSize = true;
            this.SearchNet.Location = new System.Drawing.Point(12, 87);
            this.SearchNet.Name = "SearchNet";
            this.SearchNet.Size = new System.Drawing.Size(212, 19);
            this.SearchNet.TabIndex = 5;
            this.SearchNet.Text = "Disable Search internet suggestions";
            this.SearchNet.UseVisualStyleBackColor = true;
            // 
            // StartupDelay
            // 
            this.StartupDelay.AutoSize = true;
            this.StartupDelay.Location = new System.Drawing.Point(12, 112);
            this.StartupDelay.Name = "StartupDelay";
            this.StartupDelay.Size = new System.Drawing.Size(135, 19);
            this.StartupDelay.TabIndex = 6;
            this.StartupDelay.Text = "Disable startup delay";
            this.StartupDelay.UseVisualStyleBackColor = true;
            // 
            // AppTracking
            // 
            this.AppTracking.AutoSize = true;
            this.AppTracking.Location = new System.Drawing.Point(12, 137);
            this.AppTracking.Name = "AppTracking";
            this.AppTracking.Size = new System.Drawing.Size(133, 19);
            this.AppTracking.TabIndex = 7;
            this.AppTracking.Text = "Disable app tracking";
            this.AppTracking.UseVisualStyleBackColor = true;
            // 
            // ErrorReporting
            // 
            this.ErrorReporting.AutoSize = true;
            this.ErrorReporting.Location = new System.Drawing.Point(12, 162);
            this.ErrorReporting.Name = "ErrorReporting";
            this.ErrorReporting.Size = new System.Drawing.Size(144, 19);
            this.ErrorReporting.TabIndex = 9;
            this.ErrorReporting.Text = "Disable error reporting";
            this.ErrorReporting.UseVisualStyleBackColor = true;
            // 
            // StartSuggestions
            // 
            this.StartSuggestions.AutoSize = true;
            this.StartSuggestions.Location = new System.Drawing.Point(12, 187);
            this.StartSuggestions.Name = "StartSuggestions";
            this.StartSuggestions.Size = new System.Drawing.Size(230, 19);
            this.StartSuggestions.TabIndex = 10;
            this.StartSuggestions.Text = "Disable app suggestions on start menu";
            this.StartSuggestions.UseVisualStyleBackColor = true;
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(12, 222);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(75, 23);
            this.HelpBtn.TabIndex = 12;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            // 
            // CommonTweaksWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 257);
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
            this.Name = "CommonTweaksWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Common Tweaks";
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
    }
}