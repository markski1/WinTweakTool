namespace WinTweakTool
{
    partial class DesktopTweaksWindow
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
            this.SettingsBox = new System.Windows.Forms.CheckedListBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingsBox
            // 
            this.SettingsBox.FormattingEnabled = true;
            this.SettingsBox.Items.AddRange(new object[] {
            "Hide desktop shortcuts"});
            this.SettingsBox.Location = new System.Drawing.Point(12, 12);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(226, 130);
            this.SettingsBox.TabIndex = 1;
            this.SettingsBox.SelectedIndexChanged += new System.EventHandler(this.SettingsBox_SelectedIndexChanged);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(163, 148);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // DesktopTweaksWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 183);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.SettingsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DesktopTweaksWindow";
            this.Text = "Desktop Settings";
            this.ResumeLayout(false);

        }

        #endregion
        private CheckedListBox SettingsBox;
        private Button ApplyButton;
    }
}