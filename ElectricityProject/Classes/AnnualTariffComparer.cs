using ElectricityProject.Interfaces;
using System.Collections.Generic;
using ElectricityProject.Units;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityProject.Classes
{
    public class AnnualTariffComparer : IAnnualElectricityTariffComparer
    {
        private IEnumerable<IAnnualElectricityTariff> tariffes;

        public IEnumerable<IAnnualElectricityTariff> Tariffes
        {
            get
            {
                return this.tariffes;
            }
            protected set
            {
                this.tariffes = value;
            }
        }

        public AnnualTariffComparer(IEnumerable<IAnnualElectricityTariff> tariffes)
        {
            this.tariffes = tariffes;
        }

        public IEnumerable<IAnnualElectricityTariff> Compare(double consumtion)
        {
            foreach (var item in this.tariffes)
            {
                item.CalculateAnnualCost(consumtion);
            }

            return this.tariffes.OrderBy(d => d.AnnualCost);
        }
    }
}
