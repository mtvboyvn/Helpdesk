using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Text;

namespace TRACUUTKWIN
{
#if DEBUG
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
#else 
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new TRACUUTKWINSERVICE() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
#endif
}
