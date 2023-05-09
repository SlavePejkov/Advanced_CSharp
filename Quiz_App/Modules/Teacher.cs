namespace Modules
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Teacher(string firstName, string lastName, string userName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
