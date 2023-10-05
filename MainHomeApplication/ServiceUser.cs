namespace MainHomeApplication
{
    public class ServiceUser
    {
        public string Email;
        public string Password;
        public string PhoneNumber;
        public string Gender;
        public string AccessLevel;
        public static List<ServiceUser> users = new List<ServiceUser>();

        public ServiceUser(string email, string password, string phoneNumber, string gender, string accessLevel)
        {
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Gender = gender;
            AccessLevel = accessLevel;
        }
    }
}
