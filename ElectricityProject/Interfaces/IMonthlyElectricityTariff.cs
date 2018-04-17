using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityProject.Interfaces
{
    interface IMonthlyElectricityTariff : IElectricityTariff
    {
        void CalculateMonthlyCost(double consumption);
    }
}
