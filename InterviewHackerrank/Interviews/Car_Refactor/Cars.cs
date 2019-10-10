using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Newtonsoft.Json;
using NUnit.Framework;

namespace InterviewHackerrank.Interviews.Car_Refactor
{

    class Rich_TestCarModels
    {

        [Test]
        public void TestCars()
        {
            //Arrange
            var cars = new Cars("Cars");

            //Act
            var response = cars.GetCars();

            foreach (var VARIABLE in response.Values)
            {
                Console.WriteLine(VARIABLE);
                foreach (var car in VARIABLE)
                {
                    Console.WriteLine("   "+ car);
                }
                
            }
            //Assert
            Assert.That(response.Count == 50, response.Count().ToString);


        }

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
                using (StreamReader r = new StreamReader(dir + @"\Interviews\Car_Refactor\"+ _fileName + ".json"))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<RootObject>(json);
                }
            }

            //public string[] GetCars(string searchTitle)
            public Dictionary<string, List<string>> GetCars()
            {
                var titles = new List<string>();
                var httpData = new HttpClient();
                var knt = 1;
                var cars = LoadJson().listings;

                var uniqueCarList = new List<string>();
                foreach (var VARIABLE in cars)
                {
                    if (!uniqueCarList.Contains(VARIABLE.build.model))
                    {
                        uniqueCarList.Add(VARIABLE.build.model);
                    }
                }
                var collection = new Dictionary<string, List<string>>();
                foreach (var VARIABLE in uniqueCarList)
                {
                    if (collection.ContainsKey(VARIABLE.Substring(0, 1)))
                    {
                        var value = collection[VARIABLE.Substring(0, 1)];
                        value.Add(VARIABLE);
                        collection[VARIABLE.Substring(0, 1)] = value;
                    }
                    else
                    {
                        collection.Add(VARIABLE.Substring(0, 1), new List<string>(){VARIABLE});
                    }
                }

                //var collectionList = collection.OrderBy(x => x.Key).ToList();
                // return titlesSorted.ToArray();
                return collection; 
                //return uniqueCarList .ToArray();
                //var kntpages = jsonTask.total_pages;
                //while (knt < kntpages)
                //{
                //    knt++;
                //    MovieData(seachTitle, httpData, titles, knt);
                //}
                //return cars.Select(x => x.build.model).OrderBy(x => x).ToArray();

            }



        }

        


    }
}
