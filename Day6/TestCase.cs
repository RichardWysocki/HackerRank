using NUnit.Framework;

namespace Day6
{
    [TestFixture]
    class TestCase
    {
        [Test]
        [TestCase("Hacker", "Hce akr")]
        [TestCase("Rank", "Rn ak")]
        [TestCase("Three", "Tre he")]
        public void ValidateConverstion(string input, string answer)
        {
            //Arrange
            var Conversion = new Program.Day6Conversion();
            //Act
            var result = Conversion.Convert(input);

            //Assert
            Assert.That(answer == result);


        }

    }


}
