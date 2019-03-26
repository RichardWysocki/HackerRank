using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day3
{
    [TestFixture]
    class Test
    {
        [TestCase(1, "Weird")]
        [TestCase(3, "Weird")]
        [TestCase(5, "Weird")]
        [TestCase(7, "Weird")]
        [TestCase(21, "Weird")]
        [TestCase(99, "Weird")]
        [TestCase(2, "Not Weird")]
        [TestCase(6, "Weird")]
        [TestCase(20, "Weird")]
        [TestCase(22, "Not Weird")]
        [TestCase(100, "Not Weird")]
        public void TestConditional(int value, string expectedResult)
        {
            //Arrange
            var Contidtional = new Program.ConditionalLogic(value);
            //Act
            var result = Contidtional.resultValue();
            //Assert
            Assert.AreEqual(result, expectedResult);

        }
    }
}
