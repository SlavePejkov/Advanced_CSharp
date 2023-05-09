namespace Modules
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsLoggedIn { get; set; }
        public int Grades { get; set; }

        public Students(string firstName, string lastName, string userName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;

            IsLoggedIn = false;
            Grades = 0;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
