using NUnit.Framework;

namespace InterviewHackerrank
{
    class TestClass
    {

        [TestCase("aabaa")]
        public void testPalindrome(string s)
        {
            //Arrange
            //var Palidrome = new palindrome(stng s);

            //Act
            var response = palindrome.palindromeConvert(s);

            //Assert
            Assert.That(response == 5);

        }

    }
}
