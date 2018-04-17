using ElectricityProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityProject.Classes
{
    public class AnnualElectricityTariffLogger : IElectricityTariffLogger
    {
        private readonly IEnumerable<IAnnualElectricityTariff> tariffes;

        public AnnualElectricityTariffLogger(IEnumerable<IAnnualElectricityTariff> tariffes)
        {
            this.tariffes = tariffes;
        }

        public void LogTariffes()
        {
            Console.WriteLine(string.Join("\n", this.tariffes.Select(i => new { i.TariffName, i.AnnualCost }).ToList()));
        }
    }
}
