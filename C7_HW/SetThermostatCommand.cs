using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class SetThermostatCommand : ISmartHomeExecutable
    {
        protected Thermostat thermostat;
        protected int temperature;
        public SetThermostatCommand(Thermostat thermostat, int temperature)
        {
            this.thermostat = thermostat;
            this.temperature = temperature;
        }
        public void Execute()
        {
            this.thermostat.TargetTemperature = this.temperature;
        }
    }
}
