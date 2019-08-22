using System.Collections.Generic;
using System.Configuration;

namespace QAEngineerInterviewTest
{
    class DataProvider
    {
        public List<Dog> GetDogs()
        {
            return new List<Dog>
            {
                new Dog("Golden Retriever", 5),
                new Dog("Golden Retriever", 5),
                new Dog("Golden Retriever", 5),
                new Dog("Golden Retriever", 5),
                new Dog("Golden Retriever", 5)
            };
        }

        public List<Cat> GetCats()
        {
            var configCatBreed = ConfigurationManager.AppSettings["Cat Breed"].ToString();
            var configCatAge = int.Parse(ConfigurationManager.AppSettings["Cow Age"]);

            return new List<Cat>
            {
                new Cat("Siamese", 6),
                new Cat("Siamese", 6),
                new Cat("Siamese", 6),
                new Cat("Siamese", 6),
                new Cat("Siamese", 6),
                new Cat(configCatBreed, configCatAge)
            };
        }

        public List<Cow> GetCows()
        {
            return null;

            var configCowBreed = ConfigurationManager.AppSettings["Cow Breed"].ToString();
            var configCowAge = int.Parse(ConfigurationManager.AppSettings["Cow Age"]);

            return new List<Cow>()
            {
                new Cow("Brown", 4),
                new Cow("Brown", 4),
                new Cow("Brown", 4),
                new Cow("Brown", 4),
                new Cow("Brown", 4),
                new Cow(configCowBreed, configCowAge)
            };
        }
    }
}
