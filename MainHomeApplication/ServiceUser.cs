namespace MainHomeApplication
{
    public class ServiceUser
    {
        public string Email;
        public string Password;
        public string PhoneNumber;
        public string Gender;
        public string AccessLevel;

        public ServiceUser(string email, string password, string phoneNumber, string gender, string accessLevel)
        {
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Gender = gender;
            AccessLevel = accessLevel;
        }

        static public List<ServiceUser> users = new List<ServiceUser>
        {
            new ServiceUser("example@mail.com","qwerty12345","880087164912","man","user"),
            new ServiceUser("example1@mail.com","qwerty21312345","88008711254912","woman", "user"),
            new ServiceUser("1","1","123","Mi-6 Attack Helicopter", "user"),
            new ServiceUser("admin","admin","123124512541","man","admin")

        };


    }
}
