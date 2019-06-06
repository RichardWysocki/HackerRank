using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    class Program
    {
        public Program()
        {
        

        }

        static void Main(string[] args)
        {
            List<string> wordList = new List<string>();
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var word = Console.In.ReadLine();
                wordList.Add(word);
            }
            var p = new Day6Conversion();
            foreach (var word in wordList)
            {
                Console.WriteLine(p.Convert(word));
            }


            Console.ReadLine();
        }

        public class Day6Conversion : IDay6Conversion
        {
            public Day6Conversion()
            {
            }

            public string Convert(string input)
            {
                var oddCategories = input.ToList().Where((c, i) => i % 2 != 0);
                var evenCategories = input.ToList().Where((c, i) => i % 2 == 0);
                var answer = evenCategories.Aggregate("", (current, element) => current + element) + " " + oddCategories.Aggregate("", (current, element) => current + element);
                return answer;
            }
        }
    }
}
