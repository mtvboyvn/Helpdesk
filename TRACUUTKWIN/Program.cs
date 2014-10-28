using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Text;
using System.Globalization;

namespace TRACUUTKWIN
{
#if DEBUG
    static class Program
    {
     public static CultureInfo CulUS = new CultureInfo("en-US");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
      CulUS.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";
            Application.CurrentCulture = CulUS;
            Application.Run(new Form1());
        }

    }
#else
    static class Program
    {
        public static CultureInfo CulUS = new CultureInfo("en-US");
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
            CulUS.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";
            Application.CurrentCulture = CulUS;
            ServiceBase.Run(ServicesToRun);
        }
    }
#endif
}
