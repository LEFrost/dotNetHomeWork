using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期末作业.Views;

namespace 期末作业
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login loginWindow = new Login();
            loginWindow.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(loginWindow);
        }
    }
}
