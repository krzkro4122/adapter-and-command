using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{    
    class WiFiAdapter : WiFi2
    {
        private WiFi wiFi;

        public WiFiAdapter(WiFi2 wiFi2, string network) : base(wiFi2, network)
        {

        }

        public void Login(string pwd)
        {
            this.password = pwd;
            wiFi = new WiFi(network, pwd);
            wiFi.IsCurrentlyOn = true;
            wiFi.Login(pwd);            
        }
    }
}
