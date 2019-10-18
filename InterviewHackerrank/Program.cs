using System;
using System.Collections.Generic;
using System.Linq;
using InterviewHackerrank.Interviews.Car_Refactor;

namespace InterviewHackerrank
{
    class Program
    {
        static void Main(String[] args)
        {

            var carDataAccess = new CarDataAccess("SmallListofCars");
            var cars = new Cars(carDataAccess);

            var response = cars.GetCars();

            foreach (var VARIABLE in response)
            {
                Console.WriteLine(VARIABLE.Key);
                foreach (var car in VARIABLE.Value)
                {
                    Console.WriteLine("   " + car);
                }

            }

            //var allCars = new List<Car>()
            //{
            //    new Car() {Name = "A", Color = "red"},
            //    new Car() {Name = "B", Color = "blue"},
            //    new Car() {Name = "C", Color = "red"},
            //    new Car() {Name = "D", Color = "yellow"},
            //    new Car() {Name = "E", Color = "green"},
            //    new Car() {Name = "F", Color = "black"}
            //};


            //var redcars = allCars.Where(x => x.Color.Equals("red")).ToList();

            //foreach (var carsRedcar in redcars)
            //{
            //    Console.WriteLine(carsRedcar.Name);
            //}
            //Console.WriteLine(allCars.Count());
            Console.WriteLine("Press Enter to Close Program");

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




        //public class Car
        //{
        //    public string Name { get; set; }
        //    public string Color { get; set; }
        //}

    }
}
