using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace dAY5
{

    [TestFixture]
    class TestCase
    {
        [Test]
        [TestCase(2)]
        public void runTest(int RunValue)
        {
            //Arrange
            var runValues = new Program.CalculationSystem(RunValue);
            //Act
            var result = runValues.run();
            //Assert
            Assert.AreEqual(10, result.Count);
            
            

        }
    }

}
