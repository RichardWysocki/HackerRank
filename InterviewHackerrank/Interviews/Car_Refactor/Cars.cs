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
            var cars = new Cars("https://marketcheck-prod.apigee.net/v1/search?api_key=GPSyUoNIdLcxhQt1MPGA8ALNC2EVY9yX&year=2019&start=0&rows=50");

            //Act
            var response = cars.GetCars("Ford");

            //Assert
            Assert.That(response.Length == 50, response.Count().ToString);


        }

        public class Cars
        {
            private readonly string _url;


            public Cars(string url)
            {
                _url = url;
                LoadJson();


            }

            public RootObject LoadJson()
            {
                Console.WriteLine(Directory.GetCurrentDirectory());

                var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                using (StreamReader r = new StreamReader(dir + @"\Interviews\Car_Refactor\Cars.json"))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<RootObject>(json);
                }
            }

            public string[] GetCars(string searchTitle)
            {
                var titles = new List<string>();
                var httpData = new HttpClient();
                var knt = 1;
                var cars = LoadJson().listings;

                var uniqueList = new List<string>();
                foreach (var VARIABLE in cars)
                {
                    if (!uniqueList.Contains(VARIABLE.build.model))
                    {
                        uniqueList.Add(VARIABLE.build.model);
                    }
                }

                return uniqueList.ToArray();
                //var kntpages = jsonTask.total_pages;
                //while (knt < kntpages)
                //{
                //    knt++;
                //    MovieData(seachTitle, httpData, titles, knt);
                //}
                return cars.Select(x => x.build.model).OrderBy(x => x).ToArray();

            }

            private RootObject CarData(string seachTitle, HttpClient httpData, List<string> titles, int pageNumber)
            {
                var response = httpData.GetAsync(_url).Result;
                var jsonString = response.Content.ReadAsStringAsync().Result;
                var jsonTask = JsonConvert.DeserializeObject<RootObject>(jsonString);
                foreach (var movelist in jsonTask.listings)
                {
                    titles.Add(movelist.build.model);
                }

                return jsonTask;
            }


        }

        


    }
}
