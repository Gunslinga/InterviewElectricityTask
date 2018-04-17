using ElectricityProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityProject.Classes
{
    public class BasicElectricityTariff : IAnnualElectricityTariff
    {
        private const double baseCostPerMonth = 5;
        private const double kWhConsumptionCost = 0.22;
        protected IConsumptionUnit consumptionUnit { get; set; }

        private string tariffName = "Basic electricity tariff";
        private double annualCost;

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

        public void CalculateAnnualCost(double consumption)
        {
            if (consumption < 0)
            {
                throw new ArgumentOutOfRangeException("Consumption cannot be less than 0 kWh");
            }

            double result = (baseCostPerMonth * 12) + (kWhConsumptionCost * consumption);

            this.annualCost = result;
        }
    }
}
