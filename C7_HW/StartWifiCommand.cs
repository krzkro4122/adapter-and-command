using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class StartWiFiCommand : ISmartHomeExecutable
    {
        protected WiFi wiFi;
        protected string pwd;
        public StartWiFiCommand(WiFi wiFi, string pwd)
        {
            this.wiFi = wiFi;
            this.pwd = pwd;
        }
        public void Execute()
        {
            this.wiFi.IsCurrentlyOn = true;
            this.wiFi.Login(pwd);         
        }
    }
}
