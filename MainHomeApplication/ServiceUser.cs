namespace MainHomeApplication
{
    public class ServiceUser
    {
        public string Email;
        public string Password;
        public string PhoneNumber;
        public string Gender;

        public ServiceUser(string email, string password, string phoneNumber, string gender)
        {
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Gender = gender;
        }

        static public List<ServiceUser> users = new List<ServiceUser>
        {
            new ServiceUser("example@mail.com","qwerty12345","880087164912","man"),
            new ServiceUser("example1@mail.com","qwerty21312345","88008711254912","woman"),
            new ServiceUser("1","1","123","Mi-6 Attack Helicopter")

        };


    }
}
