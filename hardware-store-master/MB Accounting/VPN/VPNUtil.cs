using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace VPN
{
    public static class VPNUtil
    {
        /// <summary> Grants full access to the VPN client log file. </summary>
        public static void GrantAccessToLogFile()
        {
            DirectoryInfo dInfo = new DirectoryInfo(VPNController.Instance.VPNLogPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }

        /// <summary> Appends message to VPN client log file. </summary>
        /// <param name="message"> Message to be appended to the log file </param>
        internal static void AppendToLogFile(string message)
        {
            using (FileStream fs = new FileStream(VPNController.Instance.VPNLogPath, FileMode.Append, FileAccess.Write))
            using (StreamWriter fssw = new StreamWriter(fs))
            {
                fssw.WriteLine(message);
            }
        }

        /// <summary> Reads and parses the config file which contains the address, username and password </summary>
        /// <returns> Returns the vpn address and vpn login credentials(username and password) </returns>
        internal static string[] ReadConfigFile(string vpnConfigPath)
        {
            string[] configSettings = new string[3];
            using (StreamReader file = new StreamReader(vpnConfigPath))
            {
                string line;
                for (int row = 0; row <= 2; row++)
                {
                    line = file.ReadLine();
                    configSettings[row] = line.Split('=')[1];
                }
            }
            return configSettings;
        }
    }
}
