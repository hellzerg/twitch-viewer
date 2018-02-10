namespace TwitchViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnDownloadLiveStreamer = new System.Windows.Forms.Button();
            this.btnDownloadVLC = new System.Windows.Forms.Button();
            this.lblVlcStatus = new System.Windows.Forms.Label();
            this.lblLiveStreamerStatus = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblversion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWatch = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownloadLiveStreamer
            // 
            this.btnDownloadLiveStreamer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDownloadLiveStreamer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDownloadLiveStreamer.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDownloadLiveStreamer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownloadLiveStreamer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownloadLiveStreamer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadLiveStreamer.ForeColor = System.Drawing.Color.White;
            this.btnDownloadLiveStreamer.Location = new System.Drawing.Point(13, 203);
            this.btnDownloadLiveStreamer.Name = "btnDownloadLiveStreamer";
            this.btnDownloadLiveStreamer.Size = new System.Drawing.Size(195, 34);
            this.btnDownloadLiveStreamer.TabIndex = 82;
            this.btnDownloadLiveStreamer.Tag = "themeable";
            this.btnDownloadLiveStreamer.Text = "Download LiveStreamer";
            this.btnDownloadLiveStreamer.UseVisualStyleBackColor = false;
            this.btnDownloadLiveStreamer.Click += new System.EventHandler(this.btnDownloadLiveStreamer_Click);
            // 
            // btnDownloadVLC
            // 
            this.btnDownloadVLC.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDownloadVLC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDownloadVLC.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDownloadVLC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownloadVLC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownloadVLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadVLC.ForeColor = System.Drawing.Color.White;
            this.btnDownloadVLC.Location = new System.Drawing.Point(13, 121);
            this.btnDownloadVLC.Name = "btnDownloadVLC";
            this.btnDownloadVLC.Size = new System.Drawing.Size(195, 34);
            this.btnDownloadVLC.TabIndex = 83;
            this.btnDownloadVLC.Tag = "themeable";
            this.btnDownloadVLC.Text = "Download VLC";
            this.btnDownloadVLC.UseVisualStyleBackColor = false;
            this.btnDownloadVLC.Click += new System.EventHandler(this.btnDownloadVLC_Click);
            // 
            // lblVlcStatus
            // 
            this.lblVlcStatus.AutoSize = true;
            this.lblVlcStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlcStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVlcStatus.Location = new System.Drawing.Point(8, 90);
            this.lblVlcStatus.Name = "lblVlcStatus";
            this.lblVlcStatus.Size = new System.Drawing.Size(46, 28);
            this.lblVlcStatus.TabIndex = 84;
            this.lblVlcStatus.Text = "VLC";
            // 
            // lblLiveStreamerStatus
            // 
            this.lblLiveStreamerStatus.AutoSize = true;
            this.lblLiveStreamerStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiveStreamerStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLiveStreamerStatus.Location = new System.Drawing.Point(8, 172);
            this.lblLiveStreamerStatus.Name = "lblLiveStreamerStatus";
            this.lblLiveStreamerStatus.Size = new System.Drawing.Size(129, 28);
            this.lblLiveStreamerStatus.TabIndex = 85;
            this.lblLiveStreamerStatus.Text = "LiveStreamer";
            // 
            // topPanel
            // 
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.lblversion);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(769, 77);
            this.topPanel.TabIndex = 86;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.ForeColor = System.Drawing.Color.Silver;
            this.lblversion.Location = new System.Drawing.Point(86, 46);
            this.lblversion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(64, 20);
            this.lblversion.TabIndex = 4;
            this.lblversion.Text = "Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Twitch Viewer";
            // 
            // txtChannel
            // 
            this.txtChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChannel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChannel.ForeColor = System.Drawing.Color.White;
            this.txtChannel.Location = new System.Drawing.Point(13, 302);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(370, 34);
            this.txtChannel.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 88;
            this.label1.Text = "Twitch channel:";
            // 
            // btnWatch
            // 
            this.btnWatch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnWatch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWatch.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnWatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnWatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatch.ForeColor = System.Drawing.Color.White;
            this.btnWatch.Location = new System.Drawing.Point(389, 302);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(141, 34);
            this.btnWatch.TabIndex = 89;
            this.btnWatch.Tag = "themeable";
            this.btnWatch.Text = "Watch stream";
            this.btnWatch.UseVisualStyleBackColor = false;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(769, 556);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.lblLiveStreamerStatus);
            this.Controls.Add(this.lblVlcStatus);
            this.Controls.Add(this.btnDownloadVLC);
            this.Controls.Add(this.btnDownloadLiveStreamer);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitch Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadLiveStreamer;
        private System.Windows.Forms.Button btnDownloadVLC;
        private System.Windows.Forms.Label lblVlcStatus;
        private System.Windows.Forms.Label lblLiveStreamerStatus;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWatch;
    }
}

