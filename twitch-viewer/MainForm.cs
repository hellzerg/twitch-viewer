using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            Utilities.DownloadLiveStreamer();
            lblversion.Text = "Version: " + Program.GetCurrentVersionToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void CheckStatus()
        {
            if (Utilities.IsVLCInstalled())
            {
                lblVlcStatus.Text = "VLC is properly installed!";
                lblVlcStatus.ForeColor = Color.Lime;
            }
            else
            {
                lblVlcStatus.Text = "VLC is not installed!";
                lblVlcStatus.ForeColor = Color.Tomato;
            }

            if (Utilities.IsLiveStreamerInstalled())
            {
                lblLiveStreamerStatus.Text = "LiveStreamer is properly installed!";
                lblLiveStreamerStatus.ForeColor = Color.Lime;
            }
            else
            {
                lblLiveStreamerStatus.Text = "LiveStreamer is not installed!";
                lblLiveStreamerStatus.ForeColor = Color.Tomato;
            }
        }
    }
}
