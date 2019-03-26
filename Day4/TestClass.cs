using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day4
{
    [TestFixture]
    class TestClass
    {
        public class TestDataProvider : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                var list = new List<int>();
                int i = -5;
                while (i < 30)
                {
                    list.Add(i);
                    i++;
                }

                return list.GetEnumerator();
                //return new List<int> { 2, 4, 6 }.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(TestDataProvider))]
        public void TestProgram(int X)
        {
            //Arrange
            //Act

            //Assert
            Assert.AreEqual(X,X);


        }
    }
}
