using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            var checkValue = new ConditionalLogic(N);
            Console.WriteLine(checkValue.resultValue());

            Console.ReadLine();
        }
        public class ConditionalLogic
        {
            private int value;

            public ConditionalLogic(int value)
            {
                this.value = value;
            }

            public string resultValue()
            {
                
                if (value % 2 == 1) return "Weird";
                if (value >= 2 && value <= 5) return "Not Weird";
                if (value >= 6 && value <= 20) return "Weird";
                if (value > 20 && value <= 100) return "Not Weird";
                return "";
            }
        }

    }
}
