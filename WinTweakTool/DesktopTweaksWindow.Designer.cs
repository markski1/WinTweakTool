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
            this.ApplyButton = new System.Windows.Forms.Button();
            this.DesktopIndicatorChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            // DesktopIndicatorChk
            // 
            this.DesktopIndicatorChk.AutoSize = true;
            this.DesktopIndicatorChk.Location = new System.Drawing.Point(12, 12);
            this.DesktopIndicatorChk.Name = "DesktopIndicatorChk";
            this.DesktopIndicatorChk.Size = new System.Drawing.Size(146, 19);
            this.DesktopIndicatorChk.TabIndex = 3;
            this.DesktopIndicatorChk.Text = "Hide desktop indicator";
            this.DesktopIndicatorChk.UseVisualStyleBackColor = true;
            this.DesktopIndicatorChk.CheckedChanged += new System.EventHandler(this.DesktopIndicatorChk_CheckedChanged);
            // 
            // DesktopTweaksWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 181);
            this.Controls.Add(this.DesktopIndicatorChk);
            this.Controls.Add(this.ApplyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DesktopTweaksWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desktop Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button ApplyButton;
        private CheckBox DesktopIndicatorChk;
    }
}