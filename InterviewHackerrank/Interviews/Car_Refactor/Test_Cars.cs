using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace InterviewHackerrank.Interviews.Car_Refactor
{
    class Test_Cars
    {
        [Test]
        public void TestCars()
        {
            //Arrange
            var carDataAccess = new CarDataAccess("SmallListofCars");
            var cars = new Cars(carDataAccess);

            //Act
            var response = cars.GetCars();

            foreach (var VARIABLE in response.Values)
            {
                Console.WriteLine(VARIABLE);
                foreach (var car in VARIABLE)
                {
                    Console.WriteLine("   " + car);
                }
            }
            //Assert
            Assert.That(response.Count == 14, response.Count().ToString);


        }
    }
}
