using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TwitchViewer
{
    public partial class MainForm : Form
    {
        string _liveStreamerFile = Application.StartupPath + "\\LiveStreamer\\livestreamer.exe";

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            lblversion.Text = "Version: " + Program.GetCurrentVersionToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private string GetParameters(string channel)
        {
            return string.Format(" --http-header Client-ID=jzkbprff40iqj646a697cyrvl0zt2m6 twitch.tv/{0} best", channel);
        }

        private void CheckStatus()
        {
            if (Utilities.IsVLCInstalled())
            {
                lblVlcStatus.Text = "VLC is properly installed!";
                lblVlcStatus.ForeColor = Color.Lime;
                btnDownloadVLC.Enabled = false;
            }
            else
            {
                lblVlcStatus.Text = "VLC is not installed!";
                lblVlcStatus.ForeColor = Color.Tomato;
                btnDownloadVLC.Enabled = true;
            }

            if (Utilities.IsLiveStreamerInstalled())
            {
                lblLiveStreamerStatus.Text = "LiveStreamer is properly installed!";
                lblLiveStreamerStatus.ForeColor = Color.Lime;
                btnDownloadLiveStreamer.Enabled = false;
            }
            else
            {
                lblLiveStreamerStatus.Text = "LiveStreamer is not installed!";
                lblLiveStreamerStatus.ForeColor = Color.Tomato;
                btnDownloadLiveStreamer.Enabled = true;
            }
        }

        private void btnDownloadVLC_Click(object sender, EventArgs e)
        {
            Utilities.DownloadVLC();
            CheckStatus();
        }

        private void btnDownloadLiveStreamer_Click(object sender, EventArgs e)
        {
            Utilities.DownloadLiveStreamer();
            CheckStatus();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();

                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.FileName = _liveStreamerFile;
                p.StartInfo.Arguments = GetParameters(txtChannel.Text);
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
