using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Version2
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public class ConversionClass
        {
            public ConversionClass()
            {

            }

            public string ReverseString(int arr)
            {
                throw new NotImplementedException();
            }
        }
    }
}
