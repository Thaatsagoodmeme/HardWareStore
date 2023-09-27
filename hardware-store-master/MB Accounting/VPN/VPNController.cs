using System;
using System.IO;
using System.Diagnostics;
using VPN.Interface;
using System.Windows.Forms;

namespace VPN
{
    /// <summary> Controller for Cisco AnyConnect client. </summary>
    public class VPNController : IVPNController
    {
        private static VPNController _instance = new VPNController();
        private readonly string _VPNAddress;
        private readonly string _VPNUsername;
        private readonly string _VPNPassword;
        private readonly string _VPNCLIPath;
        private readonly string _VPNConfigPath;
        private readonly string _VPNLogPath;

        static VPNController()
        { }

        private VPNController()
        {
            string executingFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _VPNConfigPath = Path.Combine(executingFolder, "..", "..", "..", "VPN", "Config", "config.ini");
            string[] configSettings = VPNUtil.ReadConfigFile(_VPNConfigPath);
            _VPNAddress = configSettings[0];
            _VPNUsername = configSettings[1];
            _VPNPassword = configSettings[2];
            _VPNCLIPath = Path.Combine(executingFolder, "..", "..", "..", "VPN", "Cisco", "AnyConnect", "vpncli");
            _VPNLogPath = Path.Combine(executingFolder, "..", "..", "..", "VPN", "Cisco", "log.log");
        }

        public static VPNController Instance
        {
            get
            {
                return _instance;
            }
        }
        internal string VPNLogPath
        {
            get { return _VPNLogPath; }
        }

        /// <summary> Connects to the VPN via Cisco AnyConnect CLI client. </summary>
        /// <returns> <see langword="true"/> if connection is successful, otherwise <see langword="false"/> </returns>
        public bool Connect()
        {
            bool success = false;
            try
            {
                using (Process process = new Process())
                {
                    VPNUtil.AppendToLogFile($"| Connection start | Date: {DateTime.Now.ToString("dd-MM-yyyy HH-mm:ss")}");

                    ProcessStartInfo psi = new ProcessStartInfo(_VPNCLIPath);
                    psi.RedirectStandardInput = true;
                    psi.RedirectStandardOutput = true;
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    psi.Arguments = $"connect {_VPNAddress} -s";

                    process.StartInfo = psi;
                    process.Start();

                    string output = String.Empty;
                    using (StreamReader sr = process.StandardOutput)
                    using (StreamWriter sw = process.StandardInput)
                    {
                        sw.WriteLine(_VPNUsername);
                        sw.WriteLine(_VPNPassword);

                        output = sr.ReadToEnd();
                    }

                    VPNUtil.AppendToLogFile(output);
                    VPNUtil.AppendToLogFile($"| Connection end | Date: {DateTime.Now.ToString("dd-MM-yyyy HH-mm:ss")}");

                    if (output.Contains("Connected") || output.Contains("connected"))
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connecting issue: {ex.Message}");
            }
            return success;
        }

        /// <summary> Disconnects from the VPN via Cisco AnyConnect CLI client. </summary>
        /// <returns> <see langword="true"/> if disconnection is successful, otherwise <see langword="false"/> </returns>
        public bool Disconnect()
        {
            bool success = false;
            try
            {
                using (Process process = new Process())
                {
                    VPNUtil.AppendToLogFile($"| Disconnection start | Date: {DateTime.Now.ToString("dd-MM-yyyy HH-mm:ss")}");

                    ProcessStartInfo psi = new ProcessStartInfo(_VPNCLIPath);
                    psi.RedirectStandardOutput = true;
                    psi.UseShellExecute = false;
                    psi.CreateNoWindow = true;
                    psi.Arguments = "disconnect -s";

                    process.StartInfo = psi;
                    process.Start();

                    string output = String.Empty;
                    using (StreamReader sr = process.StandardOutput)
                    {
                        output = sr.ReadToEnd();
                    }

                    VPNUtil.AppendToLogFile(output);
                    VPNUtil.AppendToLogFile($"| Connection end | Date: {DateTime.Now.ToString("dd-MM-yyyy HH-mm:ss")}");

                    if (output.Contains("Disconnected") || output.Contains("disconnected"))
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Disconnecting issue: {ex.Message}");
            }
            return success;
        }

        /// <summary> Checks whether the client is connected to the VPN via Cisco AnyConnect CLI client. </summary>
        /// <returns> <see langword="true"/> if connected, otherwise <see langword="false"/> </returns>
        public bool IsConnected()
        {
            bool success = true;
            try
            {
                using (Process process = new Process())
                {
                    VPNUtil.AppendToLogFile($"| Connection check start | Date: {DateTime.Now.ToString("dd-MM-yyyy HH-mm:ss")}");

                    ProcessStartInfo psi = new ProcessStartInfo(_VPNCLIPath);
                    psi.RedirectStandardOutput = true;
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    psi.Arguments = $"state -s";

                    process.StartInfo = psi;
                    process.Start();

                    string output = String.Empty;
                    using (StreamReader sr = process.StandardOutput)
                    {
                        output = sr.ReadToEnd();
                    }

                    VPNUtil.AppendToLogFile(output);
                    VPNUtil.AppendToLogFile($"| Connection check end | Date: {DateTime.Now.ToString("dd-MM-yyyy HH-mm:ss")}");

                    if (output.Contains("Disconnected") || output.Contains("disconnected"))
                    {
                        success = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Checking connection issue: {ex.Message}");
            }
            return success;
        }
    }
}
