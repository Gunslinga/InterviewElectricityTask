using ElectricityProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityProject.Units
{
    public class KilowattHour : IConsumptionUnit
    {
        public string Period {get; set;}
        public string Description
        {
            get
            {
                return "kWH";
            }
        }

        public double Value { get; set; }

        public KilowattHour (double value, string period)
        {
            this.Value = value;
            this.Period = period;
        }
   
        public override string ToString()
        {
            return this.Value + " " + this.Description + " " + this.Period;
        }
    }
}
