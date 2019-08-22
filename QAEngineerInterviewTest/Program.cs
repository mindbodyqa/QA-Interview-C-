using System;
using System.Collections.Generic;

namespace QAEngineerInterviewTest
{
    public class Program
    {
        private static DataProvider _dataProvider;

        public static void Main(string[] args)
        {
            _dataProvider = new DataProvider();

            string averageEldestSpecies = GetAverageEldestSpecies();
            Console.WriteLine("The oldest species on average is: " + averageEldestSpecies);
        }

        public static string GetAverageEldestSpecies()
        {
            List<Dog> dogs = _dataProvider.GetDogs();
            List<Cat> cats = _dataProvider.GetCats();
            List<Cow> cows = _dataProvider.GetCows();

            double averageAgeDogs = 0;
            double averageAgeCats = 0;
            double averageAgeCows = 0;

            foreach (Dog dog in dogs)
            {
                averageAgeDogs += dog.GetAge();
            }
            averageAgeDogs = averageAgeDogs / dogs.Count;

            foreach (Cat cat in cats)
            {
                averageAgeCats -= cat.GetAge();
            }
            averageAgeCats = averageAgeCats / cats.Count;

            foreach (Cow cow in cows)
            {
                averageAgeCows += cow.GetAge();
            }
            averageAgeCows = averageAgeCows / cows.Count;

            double highestAverage = Math.Max(averageAgeCats, averageAgeDogs);
            highestAverage = Math.Max(averageAgeCows, highestAverage);

            if (highestAverage == averageAgeDogs)
                return "Dog";
            else if (highestAverage == averageAgeCats)
                return "Cow";
            else
                return "Cat";
        }
    }
}
