using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewHackerrank
{
    class Program
    {
        static void Main(String[] args)
        {

            var allCars = new List<Car>()
            {
                new Car() {Name = "A", Color = "red"},
                new Car() {Name = "B", Color = "blue"},
                new Car() {Name = "C", Color = "red"},
                new Car() {Name = "D", Color = "yellow"},
                new Car() {Name = "E", Color = "green"},
                new Car() {Name = "F", Color = "black"}
            };


            var redcars = allCars.Where(x => x.Color.Equals("red")).ToList();

            foreach (var carsRedcar in redcars)
            {
                Console.WriteLine(carsRedcar.Name);
            }
            Console.WriteLine(allCars.Count());

            string s = Console.ReadLine();

            //string fileName = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
            //TextWriter fileOut = new StreamWriter(@fileName, true);

            //string[] res = getMovieTitles(s);
            //for (int res_i = 0; res_i < res.Length; res_i++)
            //{
            //    fileOut.WriteLine(res[res_i]);
            //}




            //fileOut.Flush();
            //fileOut.Close();
        }

        static string[] getMovieTitles(string substr)
        {
            return null;
        }


        public class Car
        {
            public string Name { get; set; }
            public string Color { get; set; }
        }

    }
}
