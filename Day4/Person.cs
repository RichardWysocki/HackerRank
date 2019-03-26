using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Person
    {
        public int age;

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
                age = 0;
            }
            else
                age = initialAge;
            // Add some more code to run some checks on initialAge
        }

        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (age < 13)
            {
                Console.WriteLine("You are young.");
                return;
            }
            if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
                return;
            }
            Console.WriteLine("You are old.");
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age++;
        }
    }
}