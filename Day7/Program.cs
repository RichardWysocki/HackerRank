using System;
using System.Linq;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            var myConversion = new ConversionClass();

            Console.WriteLine(myConversion.Reverse(arr.Take(n).ToArray()));


        }


        public class ConversionClass
        {
            public ConversionClass()
            {

            }

            public string Reverse(int[] arr)
            {
                string response = "";

                Array.Reverse(arr);

                response = String.Join(" ", arr.Select(c => c).ToArray());

                return response; // response.Trim();
            }


        }


    }


}
