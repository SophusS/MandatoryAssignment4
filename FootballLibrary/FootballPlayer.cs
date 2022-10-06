namespace FootballLibrary
{
    public class FootballPlayer
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public int _age { get; set; }
        public int _shirtNumber { get; set; }

        public FootballPlayer(int id, string name, int age, int shirtNumber) { 
            _id = id;
            _name = name;
            _age = age;
            _shirtNumber = shirtNumber;
        }
        public FootballPlayer() { }

        public void Validator()
        {
            if(_age < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (1 >= _shirtNumber || _shirtNumber >= 99)
            {
                throw new ArgumentOutOfRangeException();

            }
            if (_name.Length < 2)
            {
                throw new ArgumentException();

            }
        }
    }
}