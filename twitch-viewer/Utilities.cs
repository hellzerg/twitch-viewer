using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;

namespace TwitchViewer
{
    internal static class Utilities
    {
        static string _vlc32Path = @"SOFTWARE\Wow6432Node\VideoLAN\VLC";
        static string _vlc64Path = @"SOFTWARE\VideoLAN\VLC";

        static string _liveStreamerZip = Application.StartupPath + "\\livestreamer.zip";
        static string _liveStreamerPath = Application.StartupPath + "\\LiveStreamer\\";
        static string _liveStreamerFile = Application.StartupPath + "\\LiveStreamer\\livestreamer.exe";

        static string _liveStreamerLink = @"https://github.com/chrippa/livestreamer/releases/download/v1.12.2/livestreamer-v1.12.2-win32.zip";
        static string _vcRedist2008Link = @"https://download.microsoft.com/download/1/1/1/1116b75a-9ec3-481a-a3c8-1777b5381140/vcredist_x86.exe";

        internal static bool IsVLCInstalled()
        {
            bool result = false;

            if (Environment.Is64BitOperatingSystem)
            {
                try
                {
                    using (RegistryKey k = Registry.LocalMachine.OpenSubKey(_vlc32Path, false))
                    {
                        result = !string.IsNullOrEmpty((string)k.GetValue("", string.Empty));
                    }
                }
                catch { }

                try
                {
                    using (RegistryKey k = Registry.LocalMachine.OpenSubKey(_vlc64Path, false))
                    {
                        result = !string.IsNullOrEmpty((string)k.GetValue("", string.Empty));
                    }
                }
                catch { }
            }
            else
            {
                try
                {
                    using (RegistryKey k = Registry.LocalMachine.OpenSubKey(_vlc64Path, false))
                    {
                        result = !string.IsNullOrEmpty((string)k.GetValue("", string.Empty));
                    }
                }
                catch { }
            }

            return result;
        }

        internal static bool IsLiveStreamerInstalled()
        {
            return File.Exists(_liveStreamerFile);
        }

        internal static void DownloadLiveStreamer()
        {
            if (!File.Exists(_liveStreamerFile))
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;

                try
                {
                    client.DownloadFile(_liveStreamerLink, _liveStreamerZip);

                    ZipFile.ExtractToDirectory(_liveStreamerZip, Application.StartupPath);
                    Directory.Move(Directory.EnumerateDirectories(Application.StartupPath).FirstOrDefault(), _liveStreamerPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    try
                    {
                        File.Delete(_liveStreamerZip);
                    }
                    catch { }
                }
            }
        }
    }
}
