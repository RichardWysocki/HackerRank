using System;
<<<<<<< HEAD
using System.Linq;
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> master

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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
                foreach (var intvalue in arr)
                {
                    response += intvalue.ToString() + ' ';
                }

                return response.Trim();
            }


        }


    }


=======
        }
    }
>>>>>>> master
}
