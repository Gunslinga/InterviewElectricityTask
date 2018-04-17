using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualElectricityTariffs.Tests.Tests.ElectricityTariffTest.BasicTariffTest.Fakes
{
    internal class Fake_Tariff : ElectricityProject.Interfaces.ElectricityTariff
    {
        public override string TariffName
        {
            get
            {
                return "Basic Electricity Tariff";
            }
        }

        public override void CalculateAnnualCost(double consumption)
        {
            throw new NotImplementedException();
        }
    }
}
