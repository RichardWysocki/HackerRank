using System;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Day7
{
    [TestFixture]
    
    public class TestClass
    {
        [Test]
        [TestCase("1 2 3 4 5", "5 4 3 2 1")]
        public void TestReverseOrder(string input, string expected)
        {
            //Arrange
            var arr = Array.ConvertAll(input.Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            var conversion = new Program.ConversionClass();

            //Act

            var reverseString = conversion.Reverse(arr);

            //Assert
            Assert.AreEqual(expected, reverseString);

        }


    }


}
