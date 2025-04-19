namespace ScreenshotTaker_v0._01
{
    partial class Screenshot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screenshot));
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnFolderPath = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.btnLoadTime = new System.Windows.Forms.Button();
            this.btnScreenshotNow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusLabel = new System.Windows.Forms.Label();
            this.labelLogPath = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.labelTimeCount = new System.Windows.Forms.Label();
            this.labelNextRunTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(5, 16);
            this.numericUpDownHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownHour.TabIndex = 2;
            this.numericUpDownHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownHour.ValueChanged += new System.EventHandler(this.numericUpDownHour_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giờ";
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.btnFolderPath);
            this.panelAdd.Controls.Add(this.BtnAdd);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.numericUpDownMin);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Controls.Add(this.btnLoadTime);
            this.panelAdd.Controls.Add(this.btnScreenshotNow);
            this.panelAdd.Controls.Add(this.numericUpDownHour);
            this.panelAdd.Controls.Add(this.btnDelete);
            this.panelAdd.Location = new System.Drawing.Point(76, 4);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(459, 48);
            this.panelAdd.TabIndex = 4;
            // 
            // btnFolderPath
            // 
            this.btnFolderPath.Location = new System.Drawing.Point(386, 13);
            this.btnFolderPath.Name = "btnFolderPath";
            this.btnFolderPath.Size = new System.Drawing.Size(70, 23);
            this.btnFolderPath.TabIndex = 16;
            this.btnFolderPath.Text = "FolderPath";
            this.btnFolderPath.UseVisualStyleBackColor = true;
            this.btnFolderPath.Click += new System.EventHandler(this.btnFolderPath_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(103, 13);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(44, 23);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phút";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(54, 16);
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownMin.TabIndex = 4;
            this.numericUpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.numericUpDownMin_ValueChanged);
            // 
            // btnLoadTime
            // 
            this.btnLoadTime.Location = new System.Drawing.Point(153, 13);
            this.btnLoadTime.Name = "btnLoadTime";
            this.btnLoadTime.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTime.TabIndex = 12;
            this.btnLoadTime.Text = "LoadTime";
            this.btnLoadTime.UseVisualStyleBackColor = true;
            this.btnLoadTime.Click += new System.EventHandler(this.btnLoadTime_Click);
            // 
            // btnScreenshotNow
            // 
            this.btnScreenshotNow.Location = new System.Drawing.Point(288, 13);
            this.btnScreenshotNow.Name = "btnScreenshotNow";
            this.btnScreenshotNow.Size = new System.Drawing.Size(92, 23);
            this.btnScreenshotNow.TabIndex = 9;
            this.btnScreenshotNow.Text = "Chụp Màn Hình";
            this.btnScreenshotNow.UseVisualStyleBackColor = true;
            this.btnScreenshotNow.Click += new System.EventHandler(this.btnScreenshotNow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(234, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHide
            // 
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(394, 58);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 8;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // listBoxTime
            // 
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.Location = new System.Drawing.Point(5, 4);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(65, 134);
            this.listBoxTime.TabIndex = 10;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(76, 58);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(160, 50);
            this.btnStartStop.TabIndex = 13;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ScreenshotTaker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.SystemColors.Info;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(76, 122);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(71, 16);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "WAITING";
            // 
            // labelLogPath
            // 
            this.labelLogPath.AutoSize = true;
            this.labelLogPath.BackColor = System.Drawing.Color.Cyan;
            this.labelLogPath.Location = new System.Drawing.Point(12, 152);
            this.labelLogPath.Name = "labelLogPath";
            this.labelLogPath.Size = new System.Drawing.Size(36, 13);
            this.labelLogPath.TabIndex = 15;
            this.labelLogPath.Text = "PATH";
            this.labelLogPath.UseMnemonic = false;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(296, 58);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 30);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // labelTimeCount
            // 
            this.labelTimeCount.AutoSize = true;
            this.labelTimeCount.BackColor = System.Drawing.Color.Cyan;
            this.labelTimeCount.Location = new System.Drawing.Point(242, 106);
            this.labelTimeCount.Name = "labelTimeCount";
            this.labelTimeCount.Size = new System.Drawing.Size(37, 13);
            this.labelTimeCount.TabIndex = 17;
            this.labelTimeCount.Text = "00000";
            this.labelTimeCount.UseMnemonic = false;
            // 
            // labelNextRunTime
            // 
            this.labelNextRunTime.AutoSize = true;
            this.labelNextRunTime.BackColor = System.Drawing.Color.Cyan;
            this.labelNextRunTime.Location = new System.Drawing.Point(351, 106);
            this.labelNextRunTime.Name = "labelNextRunTime";
            this.labelNextRunTime.Size = new System.Drawing.Size(37, 13);
            this.labelNextRunTime.TabIndex = 18;
            this.labelNextRunTime.Text = "00000";
            this.labelNextRunTime.UseMnemonic = false;
            // 
            // Screenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 174);
            this.Controls.Add(this.labelNextRunTime);
            this.Controls.Add(this.labelTimeCount);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.labelLogPath);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.listBoxTime);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.panelAdd);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Screenshot";
            this.Text = "ScreenshotTaker V0.03";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyScreenShot);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnScreenshotNow;
        private System.Windows.Forms.ListBox listBoxTime;
        private System.Windows.Forms.Button btnLoadTime;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label labelLogPath;
        private System.Windows.Forms.Button btnFolderPath;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labelTimeCount;
        private System.Windows.Forms.Label labelNextRunTime;
    }
}

