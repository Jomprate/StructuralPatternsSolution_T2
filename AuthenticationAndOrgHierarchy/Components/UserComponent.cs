using AuthenticationAndOrgHierarchy.Components;
using AuthenticationAndOrgHierarchy.LegacySystem;

namespace AuthenticationAndOrgHierarchy.Components
{
    // Leaf component in the composite pattern representing individual users
    public class UserComponent : IOrganizationComponent
    {
        private readonly User _user;

        // Constructor to initialize UserComponent with an existing User
        public UserComponent(User user)
        {
            _user = user;
        }

        // Display user details with indentation to reflect hierarchy
        public void DisplayDetails(int indentLevel)
        {
            string indent = new string('-', indentLevel);
            System.Console.WriteLine($"{indent}User: {_user.GetFirstname()} {_user.GetLastname()}, Username: {_user.GetUsername()}");
        }
    }
}