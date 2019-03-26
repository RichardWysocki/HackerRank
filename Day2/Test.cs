using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day2
{
    [TestFixture]
    class Test
    {

        [TestCase(12, 20, 8, 15)]
        [TestCase(10.25, 17, 5, 13)]
        public void CalculateTax(double mealcost, int taxPercent, int tipPercent, double expectedTotal)
        {
            //Arrange
            var runresult = new CalculateMealTotal(mealcost, tipPercent, taxPercent);
            //Act
            var result = runresult.MealTotal();
            //Assert
            Assert.AreEqual(expectedTotal, result);

        }


    }
}
