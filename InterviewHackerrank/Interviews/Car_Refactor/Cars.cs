using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using InterviewHackerrank.Interviews.Car_Refactor;
using Newtonsoft.Json;
using NUnit.Framework;

namespace InterviewHackerrank.Car_Refactor
{

    class Rich_TestMovieTitles
    {

        [Test]
        public void TestMovies()
        {
            //Arrange
            var movies =
                new Cars("https://marketcheck-prod.apigee.net/v1/search?api_key=GPSyUoNIdLcxhQt1MPGA8ALNC2EVY9yX&year=2019&start=0&rows=50");

            //Act
            var response = movies.getCars("Ford");

            //Assert
            Assert.That(response.Length == 13, response.Count().ToString);


        }

        public class Cars
        {
            private readonly string _url;
                

            public Cars(string url)
            {
                _url = url;
                LoadJson();


            }

            public void LoadJson()
            {
                Console.WriteLine(Directory.GetCurrentDirectory());

                var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                using (StreamReader r = new StreamReader(dir+ @"\Car_Refactor\Cars.json"))
                {
                    string json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<RootObject>(json);
                }

            }

            public string[] getCars(string seachTitle)
            {
                var titles = new List<string>();
                var httpData = new HttpClient();
                var knt = 1;
                var jsonTask = CarData(seachTitle, httpData, titles, knt);
                //var kntpages = jsonTask.total_pages;
                //while (knt < kntpages)
                //{
                //    knt++;
                //    MovieData(seachTitle, httpData, titles, knt);
                //}
                return titles.OrderBy(x => x).ToArray();

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
