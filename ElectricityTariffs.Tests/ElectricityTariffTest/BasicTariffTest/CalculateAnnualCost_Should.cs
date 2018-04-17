using ElectricityTariffs.Tests.ElectricityTariff.BasicTariff.Fakes;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ElectricityProject.Interfaces;
using ElectricityProject.Classes;

namespace AnnualElectricityTariffs.Tests.Tests.ElectricityTariffTest.BasicTariffTest
{
    [TestFixture]
    public class CalculateAnnualCost_Should
    {
        [Test]
        public void CalculateAnnualCost_ValidData()
        {
            var comparerStub = new Mock<List<ElectricityTariff>>();

            var comparer = new AnnualTariffComparer(comparerStub.Object);
        }
    }
}
