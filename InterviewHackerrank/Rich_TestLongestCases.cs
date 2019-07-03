using NUnit.Framework;
using System.Linq;

namespace InterviewHackerrank
{
    class Rich_TestLongestCases
    {

        [Test]
        [TestCase("It is a pleasant day today", "pleasant")]
        [TestCase("You can do it the way you like", "like")]
        [TestCase("You can do Rich the way you like", "Rich")]
        [TestCase("You can do like the way you Rich", "like")]
        [TestCase("His Bed grows Green", "00")]
        public void Test_LongestEvenLengthWord(string s, string result)
        {
            //Arrange
            var checkSentence = new RichCheckString();

            //Act
            var response = checkSentence.Check(s);

            //Assert
            Assert.That(result == response);
        }
    }

    internal class RichCheckString
    {
        public RichCheckString()
        {
        }

        public string Check(string s)
        {
            var words = s.Split(' ');

            var evenwords = words.Where(x => x.Length % 2 == 0).OrderByDescending(x => x.Length).ToList();

            if (evenwords.Count > 0)
                return evenwords.First().ToString();
            else
            {
                return "00";
            }


        }
    }
}
