namespace Clicker
{
    partial class Form1
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
            this.checkBoxLC = new System.Windows.Forms.CheckBox();
            this.checkBoxRC = new System.Windows.Forms.CheckBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.freqValue = new System.Windows.Forms.NumericUpDown();
            this.debugLog = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.freqValue)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxLC
            // 
            this.checkBoxLC.AutoSize = true;
            this.checkBoxLC.Location = new System.Drawing.Point(24, 49);
            this.checkBoxLC.Name = "checkBoxLC";
            this.checkBoxLC.Size = new System.Drawing.Size(69, 17);
            this.checkBoxLC.TabIndex = 0;
            this.checkBoxLC.Text = "Left click";
            this.checkBoxLC.UseVisualStyleBackColor = true;
            this.checkBoxLC.CheckedChanged += new System.EventHandler(this.checkBoxLC_CheckedChanged);
            // 
            // checkBoxRC
            // 
            this.checkBoxRC.AutoSize = true;
            this.checkBoxRC.Location = new System.Drawing.Point(24, 81);
            this.checkBoxRC.Name = "checkBoxRC";
            this.checkBoxRC.Size = new System.Drawing.Size(76, 17);
            this.checkBoxRC.TabIndex = 1;
            this.checkBoxRC.Text = "Right click";
            this.checkBoxRC.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(24, 126);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(130, 126);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Frequency(seconds)";
            // 
            // freqValue
            // 
            this.freqValue.DecimalPlaces = 1;
            this.freqValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.freqValue.Location = new System.Drawing.Point(130, 105);
            this.freqValue.Name = "freqValue";
            this.freqValue.Size = new System.Drawing.Size(120, 20);
            this.freqValue.TabIndex = 5;
            this.freqValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // debugLog
            // 
            this.debugLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.debugLog.Location = new System.Drawing.Point(0, 155);
            this.debugLog.Multiline = true;
            this.debugLog.Name = "debugLog";
            this.debugLog.ReadOnly = true;
            this.debugLog.Size = new System.Drawing.Size(426, 73);
            this.debugLog.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Developed by Anworth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 228);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.debugLog);
            this.Controls.Add(this.freqValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.checkBoxRC);
            this.Controls.Add(this.checkBoxLC);
            this.Name = "Form1";
            this.Text = "Clicker v1";
            ((System.ComponentModel.ISupportInitialize)(this.freqValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxLC;
        private System.Windows.Forms.CheckBox checkBoxRC;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown freqValue;
        private System.Windows.Forms.TextBox debugLog;
        private System.Windows.Forms.TextBox textBox1;
    }
}

