using System;
using System.Linq;
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

            foreach (var Cargroup in response)
            {
                Console.WriteLine(Cargroup.Key);
                foreach (var car in Cargroup.Value)
                {
                    Console.WriteLine("   " + car);
                }
            }
            //Assert
            Assert.That(response.Count == 5, response.Count().ToString);


        }

        [Test]
        public void TestAllCars()
        {
            //Arrange
            var carDataAccess = new CarDataAccess("Cars");
            var cars = new Cars(carDataAccess);

            //Act
            var response = cars.GetCars();

            foreach (var Cargroup in response)
            {
                Console.WriteLine(Cargroup.Key);
                foreach (var car in Cargroup.Value)
                {
                    Console.WriteLine("   " + car);
                }
            }
            //Assert
            Assert.That(response.Count == 14, response.Count().ToString);


        }
    }
}
