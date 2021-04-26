using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class SetAlarmCommand : ISmartHomeExecutable
    {
        protected SecurityAlarm securityAlarm;
        protected string pwd;
        public SetAlarmCommand(SecurityAlarm securityAlarm, string pwd)
        {
            this.securityAlarm = securityAlarm;
            this.pwd = pwd;
        }
        public void Execute()
        {
            this.securityAlarm.Lock(this.pwd);
        }
    }
}
