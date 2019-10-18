using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace InterviewHackerrank.Interviews.Car_Refactor
{
    public class CarDataAccess: ICarDataAccess
    {
        private readonly string _fileName;

        public CarDataAccess(string _fileName)
        {
            this._fileName = _fileName;
        }
        public IRootObject LoadJson()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());

            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using (var r = new StreamReader(dir + @"\Interviews\Car_Refactor\" + _fileName + ".json"))
            {
                var json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<RootObject>(json);
            }
        }
    }

    public interface ICarDataAccess
    {
        IRootObject LoadJson();
    }
}
