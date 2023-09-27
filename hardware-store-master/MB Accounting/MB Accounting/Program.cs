using System;
using System.Windows.Forms;
using VPN;
using Database;

namespace MB_Accounting
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Fonts.InitMontserratMediumFont();
            Fonts.InitMontserratSemiBoldFont();
            VPNUtil.GrantAccessToLogFile();
            Application.Run(new LoginForm());
            DatabaseController.ClearAllPools();
            VPNController.Instance.Disconnect();
        }
    }
}
