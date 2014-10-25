using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace TRACUUTKWIN
{
    partial class TRACUUTKWINSERVICE : ServiceBase
    {
        Form1 f = default(Form1);
        public TRACUUTKWINSERVICE()
        {
            InitializeComponent();
            f = new Form1();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service
            f.button1_Click(null, null);
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
            f.StopTimer();
            try
            {
                f = null;
            }
            catch { }
        }
    }
}
