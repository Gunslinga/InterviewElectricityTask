using ElectricityProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityProject.Classes
{
    public class PackagedElectricityTariff : IAnnualElectricityTariff
    {
        private const double costPerYear = 800;
        private const double additionalcost = 0.30;
        private const double AdditionallyUnchargedMaxConsumption = 4000.0;

        private IConsumptionUnit consumptionUnit { get; set; }

        private double annualCost;
        private string tariffName = "Packaged tariff";

        public string TariffName
        {
            get
            {
                return this.tariffName;
            }
            protected set
            {
                this.tariffName = value;
            }
        }

        public double AnnualCost
        {
            get
            {
                return this.annualCost;
            }
            protected set

            {
                this.annualCost = value;
            }
        }

        public void CalculateAnnualCost(double consumption)
        {
            if (consumption < 0)
            {
                throw new ArgumentOutOfRangeException("Consumption cannot be less than 0 kWh");
            }

            double additionalResult = 0;

            if (consumption > AdditionallyUnchargedMaxConsumption)
            {
                additionalResult = (consumption - 4000) * additionalcost;
            }

            this.annualCost = costPerYear + additionalResult;
        }
    }
}
