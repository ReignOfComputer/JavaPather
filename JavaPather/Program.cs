using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace JavaPather
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Environment.OSVersion.Version.Major >= 6)
            {
                if (!IsRunAsAdmin())
                {
                    Application.Run(new Form1(false));
                }
                else
                {
                    Application.Run(new Form1(true));
                }
            }
            else
            {
                Application.Run(new Form1(true));
            }
        }

        static bool IsRunAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
