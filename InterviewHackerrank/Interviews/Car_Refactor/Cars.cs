using System.Collections.Generic;

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
            var collection = new Dictionary<string, List<string>>();

            var uniqueCarList = new List<string>();
            foreach (var car in cars)
                if (!uniqueCarList.Contains(car.build.model))
                    uniqueCarList.Add(car.build.model);
            
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