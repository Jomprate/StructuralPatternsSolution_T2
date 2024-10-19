namespace AuthenticationAndOrgHierarchy.LegacySystem
{
    // Represents the legacy User class that cannot be modified
    public class User
    {
        // Fields representing user information
        public string Firstname { get; set; }

        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Constructor to initialize User
        public User(string firstname, string lastname, string username, string password)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
        }

        // Marking this method as virtual to allow overrides
        public virtual bool CheckUsernameAndPassword(string username, string password)
        {
            return Username == username && Password == password;
        }

        // Methods to get user details
        public string GetFirstname() => Firstname;

        public string GetLastname() => Lastname;

        public string GetUsername() => Username;

        // Methods to set user details
        public void SetFirstname(string firstname) => Firstname = firstname;

        public void SetLastname(string lastname) => Lastname = lastname;

        public void SetUsername(string username) => Username = username;

        public void SetPassword(string password) => Password = password;
    }
}