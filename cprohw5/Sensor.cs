using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw5
{
    public delegate void MeasurementUpdatedEventHandler(double Average);
    public class Sensor
    {
        public MeasurementUpdatedEventHandler MeasurementUpdated;
        
        public Sensor() {
            MeasurementUpdated = new(OnAdded);
        }

        private void OnAdded(double avg)
        {

        }

        private List<double> list = new List<double>();

        public void AddMeasurement(double value)
        {
            var positiveFilter = (double x) => x > 0;

            if (positiveFilter(value))
            {
                list.Add(value);
                MeasurementUpdated(Tools.Average(list.ToArray()));
            }
            
        }
    }
}
