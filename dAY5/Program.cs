using System;
using System.Collections.Generic;

namespace dAY5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var runprogram = new CalculationSystem(n);

            foreach (var variable in runprogram.run())
            {
                Console.WriteLine(variable);
            }

            Console.ReadLine();
        }

        public class CalculationSystem
        {
            private int runValue;

            public CalculationSystem(int runValue)
            {
                this.runValue = runValue;
            }

            public List<string> run()
            {
                var responselist = new List<string>();
                for (int i = 1; i < 11; i++)
                {
                    responselist.Add(runValue + " x " + i + " = " + i * runValue);
                }

                return responselist;

            }
        }
    }
}
