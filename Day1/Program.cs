using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double d;
            string s;
            i = int.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            s = Console.ReadLine();

            Console.WriteLine(i + d);
            Console.WriteLine((d+d).ToString("N1")); 
            Console.WriteLine("HackerRank "+ s);

            Console.ReadLine();
        
        }
    }
}
