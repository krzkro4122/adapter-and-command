using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{    
    class WiFiAdapter : WiFi
    {
        protected WiFi2 wiFi2; 
        public WiFiAdapter(WiFi2 wiFi2, string net)
        {
            this.wiFi2 = wiFi2;
            this.network = net;
            this.password = wiFi2.PasswordGettter();
        }
    }
}
