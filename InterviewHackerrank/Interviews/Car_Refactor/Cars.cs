using System.Collections.Generic;
using System.Linq;

namespace InterviewHackerrank.Interviews.Car_Refactor
{
    public class Cars
    {
        private readonly ICarDataAccess _carDataAccess;

        public Cars(ICarDataAccess carDataAccess)
        {
            _carDataAccess = carDataAccess;
        }


        public Dictionary<string, List<string>> GetCars()
        {
            var cars = _carDataAccess.LoadJson().listings;

            var uniqueCarList =
                cars.Select(c => c.build.model)
                    .Distinct()
                    .OrderBy(o => o);
            var collection = uniqueCarList.GroupBy(c => c.Substring(0, 1))
                .ToDictionary(g => g.Key, g => g.ToList());
            return collection;
        }


        //public Dictionary<string, List<string>> GetCars()
        //{
        //    var cars = _carDataAccess.LoadJson(fileName).listings;
        //    var collection = new Dictionary<string, List<string>>();
        //    var uniqueCarList = new List<string>();
        //    foreach (var car in cars)
        //        if (!uniqueCarList.Contains(car.build.model))
        //            uniqueCarList.Add(car.build.model);
        //    var orderedList = uniqueCarList.OrderBy(o => o);
        //    foreach (var uniqueCar in orderedList)
        //        if (collection.ContainsKey(uniqueCar.Substring(0, 1)))
        //        {
        //            var value = collection[uniqueCar.Substring(0, 1)];
        //            value.Add(uniqueCar);
        //            collection[uniqueCar.Substring(0, 1)] = value;
        //        }
        //        else
        //        {
        //            collection.Add(uniqueCar.Substring(0, 1), new List<string> { uniqueCar });
        //        }
        //    return collection;
        //}

    }
}