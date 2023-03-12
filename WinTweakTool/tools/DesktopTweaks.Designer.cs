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
            ApplyButton = new Button();
            DesktopIndicator = new CheckBox();
            TaskbarTrans = new CheckBox();
            ClockSeconds = new CheckBox();
            MenuDelay = new CheckBox();
            SuspendLayout();
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(163, 127);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(75, 23);
            ApplyButton.TabIndex = 4;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // DesktopIndicator
            // 
            DesktopIndicator.AutoSize = true;
            DesktopIndicator.Location = new Point(12, 12);
            DesktopIndicator.Name = "DesktopIndicator";
            DesktopIndicator.Size = new Size(179, 19);
            DesktopIndicator.TabIndex = 1;
            DesktopIndicator.Text = "Hide shortcut indicator icons";
            DesktopIndicator.UseVisualStyleBackColor = true;
            DesktopIndicator.CheckedChanged += DesktopIndicator_CheckedChanged;
            // 
            // TaskbarTrans
            // 
            TaskbarTrans.AutoSize = true;
            TaskbarTrans.Location = new Point(12, 37);
            TaskbarTrans.Name = "TaskbarTrans";
            TaskbarTrans.Size = new Size(181, 19);
            TaskbarTrans.TabIndex = 2;
            TaskbarTrans.Text = "Increase taskbar transparency";
            TaskbarTrans.UseVisualStyleBackColor = true;
            // 
            // ClockSeconds
            // 
            ClockSeconds.AutoSize = true;
            ClockSeconds.Location = new Point(12, 62);
            ClockSeconds.Name = "ClockSeconds";
            ClockSeconds.Size = new Size(186, 19);
            ClockSeconds.TabIndex = 3;
            ClockSeconds.Text = "Show seconds in taskbar clock";
            ClockSeconds.UseVisualStyleBackColor = true;
            // 
            // MenuDelay
            // 
            MenuDelay.AutoSize = true;
            MenuDelay.Location = new Point(12, 87);
            MenuDelay.Name = "MenuDelay";
            MenuDelay.Size = new Size(218, 34);
            MenuDelay.TabIndex = 5;
            MenuDelay.Text = "Decrease delay for context menus to\r\nopen on hover";
            MenuDelay.UseVisualStyleBackColor = true;
            // 
            // DesktopTweaks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 164);
            Controls.Add(MenuDelay);
            Controls.Add(ClockSeconds);
            Controls.Add(TaskbarTrans);
            Controls.Add(DesktopIndicator);
            Controls.Add(ApplyButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DesktopTweaks";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Desktop Tweaks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ApplyButton;
        private CheckBox DesktopIndicator;
        private CheckBox TaskbarTrans;
        private CheckBox ClockSeconds;
        private CheckBox MenuDelay;
    }
}