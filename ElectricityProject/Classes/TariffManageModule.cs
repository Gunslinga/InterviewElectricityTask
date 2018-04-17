using ElectricityProject.Classes;
using ElectricityProject.Interfaces;
using System;
using System.Collections.Generic;
using Ninject;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace ElectricityProject
{
    public class TariffManageModule : NinjectModule
    {
        public const string BasicTariffName = "BasicTariff";
        public const string PackagedTariffName = "PackageTariff";
        public const string TariffComparerName = "AnnualTariffComparer";
        public const string AnnualLoggerTariffName = "AnnualElectricityTariffLogger";

        public override void Load()
        {
            var basicTariff = this.Bind<IAnnualElectricityTariff>().To<BasicElectricityTariff>().Named(BasicTariffName);
            var packagedTariff = this.Bind<IAnnualElectricityTariff>().To<PackagedElectricityTariff>().Named(PackagedTariffName);
            var tariffComparer = this.Bind<IAnnualElectricityTariffComparer>().To<AnnualTariffComparer>().Named(TariffComparerName);

            tariffComparer.WithConstructorArgument<IEnumerable<IAnnualElectricityTariff>>(new List<IAnnualElectricityTariff>()
            {
                this.Kernel.Get<IAnnualElectricityTariff>(BasicTariffName),
                this.Kernel.Get<IAnnualElectricityTariff>(PackagedTariffName)
            });
        }
    }
}
