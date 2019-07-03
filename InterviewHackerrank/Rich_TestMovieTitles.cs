using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using NUnit.Framework;

namespace InterviewHackerrank
{
    class Rich_TestMovieTitles
    {

        [Test]
        public void TestMovies()
        {
            //Arrange
            var movies = new Movies("https://jsonmock.hackerrank.com/api/movies/search");

            //Act
            var response = movies.getmovies("spiderman");

            //Assert
            Assert.That(response.Length == 13, response.Count().ToString);


        }


}

    internal class Movies
    {
        private readonly string _url;

        public Movies(string URL)
        {
            _url = URL;
        }

        public string[] getmovies(string seachTitle) 
        {
            var titles = new List<string>();
            var httpData = new HttpClient();
            var knt = 1;
            var jsonTask = MovieData(seachTitle, httpData, titles, knt);
            var kntpages = jsonTask.total_pages;
            while (knt < kntpages)
            {
                knt++;
                MovieData(seachTitle, httpData, titles, knt);
            }
            return titles.OrderBy(x => x).ToArray();

        }

        private MovieData MovieData(string seachTitle, HttpClient httpData, List<string> titles, int pageNumber)
        {
            var response = httpData.GetAsync(_url + "/?Title=" + seachTitle + "&page=" + pageNumber ).Result;
            var jsonString = response.Content.ReadAsStringAsync().Result;
            var jsonTask = JsonConvert.DeserializeObject<MovieData>(jsonString);
            foreach (var movelist in jsonTask.data)
            {
                titles.Add(movelist.Title);
            }

            return jsonTask;
        }
    }

    internal class MovieData
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }

        public List<movie> data { get; set; }

    }

    internal class movie
    {
        public string Title { get; set; }
    }
}
