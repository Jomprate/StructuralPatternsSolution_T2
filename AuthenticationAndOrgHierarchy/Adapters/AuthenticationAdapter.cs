using AuthenticationAndOrgHierarchy.LegacySystem;
using AuthenticationAndOrgHierarchy.NewSystem;

namespace AuthenticationAndOrgHierarchy.Adapters
{
    public class AuthenticationAdapter : User
    {
        private readonly NewAuthenticationSystem _newAuthSystem;

        public AuthenticationAdapter(string firstname, string lastname, string username, string password, NewAuthenticationSystem newAuthSystem)
            : base(firstname, lastname, username, password)
        {
            _newAuthSystem = newAuthSystem;
        }

        // Override the method to use the new authentication system
        public override bool CheckUsernameAndPassword(string username, string password)
        {
            // Force the use of the "newuser" credentials to authenticate
            return _newAuthSystem.AuthenticateUser("newuser", "newpassword");
        }

        // Get user details from the new system
        public string GetUserDetails(int userId)
        {
            return _newAuthSystem.GetUserDetails(userId);
        }

        // Reset user password using the new system
        public void ResetPassword(int userId)
        {
            _newAuthSystem.ResetPassword(userId);
        }
    }
}