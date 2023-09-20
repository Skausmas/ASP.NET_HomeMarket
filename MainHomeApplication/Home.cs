
namespace MainHomeApplication
{
    public interface IAddHome
    {
        void AddHome(Home home);
    }
    public interface IRemoveHome { 
        void RemoveHome(Home home);
    }
    public interface IGetHome
    {
        public  Home? GetHome(int id);
    }
    public interface IUpdateHome
    {
        void UpdateHome(Home home);
    }
    public class Home
    {
        public static List<Home> allHomes = new List<Home>();

        public int id { get; }
        public string address { get; }
        public string ownerName { get; }
        public Home(int id, string address, string ownerName)
        {
            this.id = id;
            this.address = address;
            this.ownerName = ownerName;
        }
        
    }
    public class HomeBuilder: IAddHome, IRemoveHome, IGetHome, IUpdateHome
    {
        public  void AddHome(Home home)
        {
            Home.allHomes.Add(home);
        }
        public void RemoveHome(Home home)
        {
            foreach (Home _home in Home.allHomes)
            {
                if (_home.id == home.id)
                {
                    Home.allHomes.Remove(_home);
                    break;
                }
            }
        }
        public  Home? GetHome(int id)
        {
            foreach (Home _home in Home.allHomes)
            {
                if (_home.id == id)
                {
                    return _home;
                }
            }
            return null;
        }
        public  void UpdateHome(Home home)
        {
            foreach (Home _home in Home.allHomes)
            {
                if (_home.id == home.id)
                {
                    Home.allHomes.Remove(_home);
                    Home.allHomes.Add(home);
                }
            }
        }
    }
}
