using System;
using InterviewHackerrank.Interviews.Car_Refactor;

namespace InterviewHackerrank
{
    class Program
    {
        static void Main(String[] args)
        {
            //In this Problem, we have a Cars class which gets a list of Cars from different JSON files.
            //    Write the "GetCars" method to return a dictionary with the key being the First Letter of the model of the car and the value being the list of cars in the JSON file with that result.
            //    See Example Answer
            //    A
            //Altima
            //    Audi
            //E
            //    Escape
            //F
            //F-250 Super Duty
            //P
            //    Pilot
            //T
            //    Tracker

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
