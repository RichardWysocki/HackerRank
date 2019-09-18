using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace InterviewHackerrank
{
    internal class Rich_TestPalindrome
    {
        [Test]
        [TestCase("mokkori", 7)]
        [TestCase("aabaa", 5)]
        [TestCase("abaab", 5)]

        public void TestPalindrome(string s, int expectedResult)
        {
            //Arrange
            //Act
            var result = Result.Palindrome(s);
            //Assert
            Assert.That(result == expectedResult, $"response was {result}");
        }

        [Test]
        [TestCase("mo", false)]
        [TestCase("m", true)]
        [TestCase("kk", true)]
        [TestCase("gh", false)]

        public void TestPalindrome(string s, bool expectedResult)
        {
            //Arrange
            //Act
            var result = Result.isPalindrome(s);
            //Assert
            Assert.That(result == expectedResult);
        }

    }

    public class Result
    {
        public static int Palindrome(string s)
        {
            var set = splitstring(s);
            var count = 0;
            foreach (var uniqueString in set)
            {
                count = count + (isPalindrome(uniqueString) ? 1 : 0);
            }
            return count;

        }

        public static string[] splitstring(string s)
        {
            var uniqueSet = new HashSet<string>();
            uniqueSet.Add(s);
            for (int i = 0; i < s.Length; i++) //i is starting position
            {
                uniqueSet.Add(s.Substring(i, 1));
                for (int j = 2; j + i < s.Length+1; j++) //j is number of characters to get
                {
                    uniqueSet.Add(s.Substring(i, j));
                }
            }
            return uniqueSet.ToArray();
        }

        public static bool isPalindrome(string s)
        {
            var ReverseStr = string.Join("", s.ToCharArray().Reverse());
            return s == ReverseStr;          
        }



    }
}