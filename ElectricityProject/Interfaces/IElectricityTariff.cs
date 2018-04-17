using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityProject.Interfaces
{
    public interface IElectricityTariff
    {
        string TariffName { get; }

        /*
          Additional logic for using different units could be added
            IConsumptionUnit ConsumptionUnit { get; set; }
            ICurrencyUnit CurrencyUnit { get; set; }
         */

    }
}
