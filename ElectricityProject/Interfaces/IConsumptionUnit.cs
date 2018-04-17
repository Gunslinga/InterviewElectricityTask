using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityProject.Interfaces
{
    public interface IConsumptionUnit
    {
        double Value { get; set; }
        string Description { get; }
        string Period {get; set;} //Could use enumeration for unit
    }
}
