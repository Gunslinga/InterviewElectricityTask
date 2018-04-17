using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityProject.Interfaces
{
    public interface IAnnualElectricityTariffComparer
    {
        IEnumerable<IAnnualElectricityTariff> Tariffes { get; } 
        IEnumerable<IAnnualElectricityTariff> Compare(double amount);
    }
}
