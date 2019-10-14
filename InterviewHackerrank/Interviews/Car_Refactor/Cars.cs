using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace InterviewHackerrank.Interviews.Car_Refactor
{
    public class Cars
    {
        private readonly string _fileName;

        public Cars(string fileName)
        {
            _fileName = fileName;
            LoadJson();
        }

        public RootObject LoadJson()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());

            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using (var r = new StreamReader(dir + @"\Interviews\Car_Refactor\" + _fileName + ".json"))
            {
                var json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<RootObject>(json);
            }
        }

        public Dictionary<string, List<string>> GetCars()
        {
            var cars = LoadJson().listings;

            var uniqueCarList = new List<string>();
            foreach (var car in cars)
                if (!uniqueCarList.Contains(car.build.model))
                    uniqueCarList.Add(car.build.model);
            var collection = new Dictionary<string, List<string>>();
            foreach (var uniqueCar in uniqueCarList)
                if (collection.ContainsKey(uniqueCar.Substring(0, 1)))
                {
                    var value = collection[uniqueCar.Substring(0, 1)];
                    value.Add(uniqueCar);
                    collection[uniqueCar.Substring(0, 1)] = value;
                }
                else
                {
                    collection.Add(uniqueCar.Substring(0, 1), new List<string> { uniqueCar });
                }

            return collection;
        }
    }
}