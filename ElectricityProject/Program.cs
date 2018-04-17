using ElectricityProject.Classes;
using ElectricityProject.Interfaces;
using ElectricityProject.Units;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //In this implementation we assume that the consumption unit will be always kWh/year and currency €/year
            //Change this value for different scenarios

            double consumptionValue = 4500;

            IKernel kernel = new StandardKernel(new TariffManageModule());

            IAnnualElectricityTariffComparer annualComparer = kernel.Get<IAnnualElectricityTariffComparer>();
            var compareResult = annualComparer.Compare(consumptionValue);

            IElectricityTariffLogger logger = new AnnualElectricityTariffLogger(compareResult.OrderBy(d => d.AnnualCost));
            logger.LogTariffes();

            //comment above/uncomment below to test manual compositing 

            /*
            BasicElectricityTariff basicTariff = new BasicElectricityTariff();
            PackagedElectricityTariff packagedTariff = new PackagedElectricityTariff();
            
            List<IAnnualElectricityTariff> consumers = new List<IAnnualElectricityTariff>()
            {
                basicTariff,
                packagedTariff
            };
            
            AnnualTariffComparer annualComparer = new AnnualTariffComparer(consumers);
            
            var compareResult = annualComparer.Compare(4500);
            
            IElectricityTariffLogger logger = new AnnualElectricityTariffLogger(compareResult.OrderBy(d => d.AnnualCost));
            logger.LogTariffes();

            */
        }
    }
}
