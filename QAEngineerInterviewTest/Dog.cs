using System;
namespace QAEngineerInterviewTest
{
    class Dog
    {
        private string _breed;
        private int _age;

        public Dog(string breed, int age)
        {
            this._breed = breed;
            this._age = age;
        }

        public string GetBreed()
        {
            return this._breed;
        }

        public int GetAge()
        {
            return this._age;
        }
    }
}
