using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw5
{
    public delegate void TemperatureChangedEventHandler(double newTemperature);
    public class Thermostat
    {
        public TemperatureChangedEventHandler TemperatureChanged;

        private void OnTempChanged(double newTemp) { }
        public Thermostat() {
            TemperatureChanged = new(OnTempChanged);
        }

        private double temp = 0;
        public double Temperature { get { return temp; } set {
                temp = value;
                TemperatureChanged(value);
            } 
        }
    }
}
