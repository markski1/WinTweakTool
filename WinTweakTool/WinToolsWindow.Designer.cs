namespace WinTweakTool
{
    partial class WinToolsWindow
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
            this.RegeditBtn = new System.Windows.Forms.Button();
            this.MmcBtn = new System.Windows.Forms.Button();
            this.DskMgrBtn = new System.Windows.Forms.Button();
            this.DevMgrBtn = new System.Windows.Forms.Button();
            this.EventVwrBtn = new System.Windows.Forms.Button();
            this.DxDiagBtn = new System.Windows.Forms.Button();
            this.ResMonBtn = new System.Windows.Forms.Button();
            this.SysInfoBtn = new System.Windows.Forms.Button();
            this.NTConfigBtn = new System.Windows.Forms.Button();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegeditBtn
            // 
            this.RegeditBtn.Location = new System.Drawing.Point(10, 8);
            this.RegeditBtn.Name = "RegeditBtn";
            this.RegeditBtn.Size = new System.Drawing.Size(116, 34);
            this.RegeditBtn.TabIndex = 0;
            this.RegeditBtn.Text = "Registry Editor";
            this.RegeditBtn.UseVisualStyleBackColor = true;
            this.RegeditBtn.Click += new System.EventHandler(this.RegeditBtn_Click);
            // 
            // MmcBtn
            // 
            this.MmcBtn.Location = new System.Drawing.Point(132, 8);
            this.MmcBtn.Name = "MmcBtn";
            this.MmcBtn.Size = new System.Drawing.Size(118, 43);
            this.MmcBtn.TabIndex = 1;
            this.MmcBtn.Text = "MS Management Console";
            this.MmcBtn.UseVisualStyleBackColor = true;
            this.MmcBtn.Click += new System.EventHandler(this.MmcBtn_Click);
            // 
            // DskMgrBtn
            // 
            this.DskMgrBtn.Location = new System.Drawing.Point(132, 54);
            this.DskMgrBtn.Name = "DskMgrBtn";
            this.DskMgrBtn.Size = new System.Drawing.Size(118, 28);
            this.DskMgrBtn.TabIndex = 5;
            this.DskMgrBtn.Text = "Disk Management";
            this.DskMgrBtn.UseVisualStyleBackColor = true;
            this.DskMgrBtn.Click += new System.EventHandler(this.DskMgrBtn_Click);
            // 
            // DevMgrBtn
            // 
            this.DevMgrBtn.Location = new System.Drawing.Point(132, 84);
            this.DevMgrBtn.Name = "DevMgrBtn";
            this.DevMgrBtn.Size = new System.Drawing.Size(118, 42);
            this.DevMgrBtn.TabIndex = 7;
            this.DevMgrBtn.Text = "Device Management";
            this.DevMgrBtn.UseVisualStyleBackColor = true;
            this.DevMgrBtn.Click += new System.EventHandler(this.DevMgrBtn_Click);
            // 
            // EventVwrBtn
            // 
            this.EventVwrBtn.Location = new System.Drawing.Point(10, 88);
            this.EventVwrBtn.Name = "EventVwrBtn";
            this.EventVwrBtn.Size = new System.Drawing.Size(116, 34);
            this.EventVwrBtn.TabIndex = 8;
            this.EventVwrBtn.Text = "Event Viewer";
            this.EventVwrBtn.UseVisualStyleBackColor = true;
            this.EventVwrBtn.Click += new System.EventHandler(this.EventVwrBtn_Click);
            // 
            // DxDiagBtn
            // 
            this.DxDiagBtn.Location = new System.Drawing.Point(10, 48);
            this.DxDiagBtn.Name = "DxDiagBtn";
            this.DxDiagBtn.Size = new System.Drawing.Size(116, 34);
            this.DxDiagBtn.TabIndex = 9;
            this.DxDiagBtn.Text = "DX Diagnostics";
            this.DxDiagBtn.UseVisualStyleBackColor = true;
            this.DxDiagBtn.Click += new System.EventHandler(this.DxDiagBtn_Click);
            // 
            // ResMonBtn
            // 
            this.ResMonBtn.Location = new System.Drawing.Point(10, 128);
            this.ResMonBtn.Name = "ResMonBtn";
            this.ResMonBtn.Size = new System.Drawing.Size(116, 34);
            this.ResMonBtn.TabIndex = 10;
            this.ResMonBtn.Text = "Resource Monitor";
            this.ResMonBtn.UseVisualStyleBackColor = true;
            this.ResMonBtn.Click += new System.EventHandler(this.ResMonBtn_Click);
            // 
            // SysInfoBtn
            // 
            this.SysInfoBtn.Location = new System.Drawing.Point(132, 132);
            this.SysInfoBtn.Name = "SysInfoBtn";
            this.SysInfoBtn.Size = new System.Drawing.Size(118, 30);
            this.SysInfoBtn.TabIndex = 11;
            this.SysInfoBtn.Text = "System Info";
            this.SysInfoBtn.UseVisualStyleBackColor = true;
            this.SysInfoBtn.Click += new System.EventHandler(this.SysInfoBtn_Click);
            // 
            // NTConfigBtn
            // 
            this.NTConfigBtn.Location = new System.Drawing.Point(10, 168);
            this.NTConfigBtn.Name = "NTConfigBtn";
            this.NTConfigBtn.Size = new System.Drawing.Size(116, 34);
            this.NTConfigBtn.TabIndex = 12;
            this.NTConfigBtn.Text = "NT Configuration";
            this.NTConfigBtn.UseVisualStyleBackColor = true;
            this.NTConfigBtn.Click += new System.EventHandler(this.NTConfigBtn_Click);
            // 
            // ServicesBtn
            // 
            this.ServicesBtn.Location = new System.Drawing.Point(132, 168);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(118, 34);
            this.ServicesBtn.TabIndex = 13;
            this.ServicesBtn.Text = "Services";
            this.ServicesBtn.UseVisualStyleBackColor = true;
            this.ServicesBtn.Click += new System.EventHandler(this.ServicesBtn_Click);
            // 
            // WinToolsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 209);
            this.Controls.Add(this.ServicesBtn);
            this.Controls.Add(this.NTConfigBtn);
            this.Controls.Add(this.SysInfoBtn);
            this.Controls.Add(this.ResMonBtn);
            this.Controls.Add(this.DxDiagBtn);
            this.Controls.Add(this.EventVwrBtn);
            this.Controls.Add(this.DevMgrBtn);
            this.Controls.Add(this.DskMgrBtn);
            this.Controls.Add(this.MmcBtn);
            this.Controls.Add(this.RegeditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinToolsWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Windows Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private Button RegeditBtn;
        private Button MmcBtn;
        private Button DskMgrBtn;
        private Button DevMgrBtn;
        private Button EventVwrBtn;
        private Button DxDiagBtn;
        private Button ResMonBtn;
        private Button SysInfoBtn;
        private Button NTConfigBtn;
        private Button ServicesBtn;
    }
}