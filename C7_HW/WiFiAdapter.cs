using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{    
    class WiFiAdapter
    {
        private readonly WiFi wiFi;
        protected WiFi2 wiFi2;
        protected string net, password;
        protected bool isCurrentlyOn;
        public virtual bool IsCurrentlyOn
        {
            get { return isCurrentlyOn; }
            set
            {
                if (value == true) { Console.WriteLine("WiFi turned on."); }
                else { Console.WriteLine("WiFi turned off."); }
                isCurrentlyOn = value;
            }
        }
        public WiFiAdapter(WiFi2 wiFi2, string net)
        {
            this.wiFi2 = wiFi2;
            this.net = net;
            this.password = wiFi2.PasswordGettter();
            this.wiFi = new WiFi(this.net, this.password);
        }
        public void Login(string password)
        {
            wiFi.Login(password);
        }
    }
}
