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
        System.Timers.Timer pro = new System.Timers.Timer();
        public TRACUUTKWINSERVICE()
        {
            InitializeComponent();
            Form1 f = new Form1();
            pro.Elapsed += f.pro_Elapsed;
            pro.Interval = 3000;
            pro.Enabled = false;
            pro.Stop();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service
            pro.Enabled = true;
            pro.Start();
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
            pro.Enabled = false;
            pro.Stop();
        }
    }
}
