using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day7_Version2
{
    class TestCase
    {
        [Test]
        [TestCase("1 2 3 4 5", "5 4 3 2 1")]
        public void TestReverseOrder(string input, string expected)
        {
            //Arrange
            var arr = Convert.ToInt32(input);
            var Conversion = new Program.ConversionClass();

            //Act

            var reverseString = Conversion.ReverseString(arr);

            //Assert
            Assert.AreEqual(expected, reverseString);

        }
    }
}
