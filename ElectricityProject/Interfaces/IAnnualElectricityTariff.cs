using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityProject.Interfaces
{
    public interface IAnnualElectricityTariff : IElectricityTariff
    {
        double AnnualCost { get; }
        void CalculateAnnualCost(double consumption);
        //void CalculateAnnualCost(IConsumptionUnit consumptionUnit, ICurrencyUnit); in case of using some other units
    }
}
