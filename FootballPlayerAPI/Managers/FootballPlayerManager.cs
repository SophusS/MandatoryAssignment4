using FootballLibrary;

namespace FootballPlayerAPI.Managers
{
    public class FootballPlayerManager
    {
        private static int _nextId = 1;
        private static readonly List<FootballPlayer> theList = new List<FootballPlayer> {
        new FootballPlayer{_id = _nextId++, _name = "Sophus", _age = 26, _shirtNumber = 1},
        new FootballPlayer{_id = _nextId++, _name = "Kasper", _age = 27, _shirtNumber = 3},
        new FootballPlayer{_id = _nextId++, _name = "Skytt", _age = 30, _shirtNumber = 7},
        new FootballPlayer{_id = _nextId++, _name = "Simon", _age = 5, _shirtNumber = 13},
        new FootballPlayer{_id = _nextId++, _name = "Gustav", _age = 90, _shirtNumber = 97}


        };

        public List<FootballPlayer> getAll()
        {
            return theList;
        }
        public FootballPlayer get(int id)
        {
            FootballPlayer result = theList.FirstOrDefault(x => x._id == id);

            if (result == null) {
                return new FootballPlayer { _name = "fejl"};
            }
            else
            {
                return result;
            }
        }
        public void add(FootballPlayer player)
        {
            theList.Add(player);
        }
        public void update(FootballPlayer player)
        {
            if(theList.FirstOrDefault(x => x._id == player._id) != null) { 
                FootballPlayer oldPlayer = theList.FirstOrDefault(x => x._id == player._id);
                oldPlayer._shirtNumber = player._shirtNumber;
                oldPlayer._name = player._name;
                oldPlayer._age = player._age;
            }
        }
        public void delete(int id)
        {
            theList.RemoveAll(x => x._id == id);
        }
        
    }
}
