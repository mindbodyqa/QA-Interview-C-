namespace QAEngineerInterviewTest
{
    class Cow
    {
        private string _breed;
        private int _age;

        public Cow(string breed, int age)
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
