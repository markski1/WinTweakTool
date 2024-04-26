namespace WinTweakTool.tools
{
    partial class Debloater
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
            this.RemoveGameBar = new System.Windows.Forms.CheckBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.TweaksDontApply = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveGameBar
            // 
            this.RemoveGameBar.AutoSize = true;
            this.RemoveGameBar.Location = new System.Drawing.Point(12, 114);
            this.RemoveGameBar.Name = "RemoveGameBar";
            this.RemoveGameBar.Size = new System.Drawing.Size(113, 17);
            this.RemoveGameBar.TabIndex = 10;
            this.RemoveGameBar.Text = "Uninstall GameBar";
            this.RemoveGameBar.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(194, 175);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(64, 24);
            this.ApplyButton.TabIndex = 13;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // TweaksDontApply
            // 
            this.TweaksDontApply.AutoSize = true;
            this.TweaksDontApply.Location = new System.Drawing.Point(12, 9);
            this.TweaksDontApply.Name = "TweaksDontApply";
            this.TweaksDontApply.Size = new System.Drawing.Size(239, 91);
            this.TweaksDontApply.TabIndex = 18;
            this.TweaksDontApply.Text = "Be advised:\r\nThis will permanently remove the components \r\nfrom your system.\r\n\r\nT" +
    "hey might be reinstalled by the Windows update\r\ntool during major updates. In th" +
    "at case, just\r\nrun this tool again.";
            // 
            // Debloater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 211);
            this.Controls.Add(this.TweaksDontApply);
            this.Controls.Add(this.RemoveGameBar);
            this.Controls.Add(this.ApplyButton);
            this.Name = "Debloater";
            this.Text = "Debloater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox RemoveGameBar;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label TweaksDontApply;
    }
}