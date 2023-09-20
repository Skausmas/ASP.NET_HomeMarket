namespace MainHomeApplication
{
    public class User
    {
        public string Email;
        public string Password;
        public string PhoneNumber;
        public string Gender;

        public User(string email, string password, string phoneNumber, string gender)
        {
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Gender = gender;
        }

        static public List<User> users = new List<User>
        {
            new User("example@mail.com","qwerty12345","880087164912","man"),
            new User("example1@mail.com","qwerty21312345","88008711254912","woman")

        };


    }
}
