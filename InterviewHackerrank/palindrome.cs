using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace InterviewHackerrank
{
    class palindrome
    {

        public palindrome()
        {
            
        }

        public static int palindromeConvert(string s)
        {
            if (!Regex.IsMatch(s, "[a-z]")) throw new ArgumentException("invalid string.");

            List<string> dromes = new List<string>();
            int length = s.Length;
            for (int idx = 0; idx < length; idx++)
            {

                // handle even length
                int leftbound = idx;
                int rightbound = idx + 1;
                while (leftbound >= 0 && rightbound < length && (s[leftbound] == s[rightbound]))
                {
                    dromes.Add(s.Substring(leftbound, rightbound + 1));
                    leftbound--;
                    rightbound++;
                }

                // handle odd length
                leftbound = rightbound = idx;
                while (leftbound >= 0 && rightbound < length && (s[leftbound] == s[rightbound]))
                {
                    dromes.Add(s.Substring(leftbound, rightbound + 1));
                    leftbound--;
                    rightbound++;
                }
            }

            return dromes.Count();
        }
    }
}
