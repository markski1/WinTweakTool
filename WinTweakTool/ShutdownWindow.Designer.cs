namespace WinTweakTool
{
    partial class ShutdownWindow
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
            this.ScheduleShutdown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.CancelShutdown = new System.Windows.Forms.Button();
            this.shutdownIn = new System.Windows.Forms.RadioButton();
            this.shutdownAt = new System.Windows.Forms.RadioButton();
            this.monthPicker = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleShutdown
            // 
            this.ScheduleShutdown.Location = new System.Drawing.Point(74, 321);
            this.ScheduleShutdown.Name = "ScheduleShutdown";
            this.ScheduleShutdown.Size = new System.Drawing.Size(129, 23);
            this.ScheduleShutdown.TabIndex = 0;
            this.ScheduleShutdown.Text = "Schedule shutdown";
            this.ScheduleShutdown.UseVisualStyleBackColor = true;
            this.ScheduleShutdown.Click += new System.EventHandler(this.ScheduleShutdown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "minutes";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(63, 253);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 23);
            this.numericUpDown1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(63, 283);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 23);
            this.numericUpDown2.TabIndex = 8;
            // 
            // CancelShutdown
            // 
            this.CancelShutdown.Location = new System.Drawing.Point(77, 350);
            this.CancelShutdown.Name = "CancelShutdown";
            this.CancelShutdown.Size = new System.Drawing.Size(123, 23);
            this.CancelShutdown.TabIndex = 9;
            this.CancelShutdown.Text = "Cancel shutdown";
            this.CancelShutdown.UseVisualStyleBackColor = true;
            this.CancelShutdown.Click += new System.EventHandler(this.CancelShutdown_Click);
            // 
            // shutdownIn
            // 
            this.shutdownIn.AutoSize = true;
            this.shutdownIn.Location = new System.Drawing.Point(12, 219);
            this.shutdownIn.Name = "shutdownIn";
            this.shutdownIn.Size = new System.Drawing.Size(241, 19);
            this.shutdownIn.TabIndex = 10;
            this.shutdownIn.Text = "Alternatively, shutdown my computer in:";
            this.shutdownIn.UseVisualStyleBackColor = true;
            // 
            // shutdownAt
            // 
            this.shutdownAt.AutoSize = true;
            this.shutdownAt.Checked = true;
            this.shutdownAt.Location = new System.Drawing.Point(12, 14);
            this.shutdownAt.Name = "shutdownAt";
            this.shutdownAt.Size = new System.Drawing.Size(170, 19);
            this.shutdownAt.TabIndex = 11;
            this.shutdownAt.TabStop = true;
            this.shutdownAt.Text = "Shutdown my computer at:";
            this.shutdownAt.UseVisualStyleBackColor = true;
            // 
            // monthPicker
            // 
            this.monthPicker.Location = new System.Drawing.Point(15, 41);
            this.monthPicker.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.monthPicker.MaxSelectionCount = 1;
            this.monthPicker.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.ShowToday = false;
            this.monthPicker.ShowTodayCircle = false;
            this.monthPicker.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(5, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "___________________________________________";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "hh:mm tt";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(181, 12);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(82, 23);
            this.timePicker.TabIndex = 15;
            // 
            // ShutdownWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 383);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthPicker);
            this.Controls.Add(this.shutdownAt);
            this.Controls.Add(this.shutdownIn);
            this.Controls.Add(this.CancelShutdown);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScheduleShutdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShutdownWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shutdown Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ScheduleShutdown;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Button CancelShutdown;
        private RadioButton shutdownIn;
        private RadioButton shutdownAt;
        private MonthCalendar monthPicker;
        private Label label1;
        private DateTimePicker timePicker;
    }
}