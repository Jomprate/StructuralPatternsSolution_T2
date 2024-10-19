using AuthenticationAndOrgHierarchy.Components;
using AuthenticationAndOrgHierarchy.LegacySystem;
using AuthenticationAndOrgHierarchy.Adapters;
using AuthenticationAndOrgHierarchy.NewSystem;

namespace AuthenticationAndOrgHierarchy.Client
{
    public class OrganizationClient
    {
        public void DisplayOrganizationStructure()
        {
            // Create the new authentication system
            var newAuthSystem = new NewAuthenticationSystem();

            // Create legacy users
            var user1 = new User("Alice", "Johnson", "alicej", "password123");
            var user2 = new User("Bob", "Smith", "bobsmith", "mypassword");
            var user3 = new User("Charlie", "Brown", "charlieb", "charlie123");

            // Create users using the adapter (authenticating through the new system)
            var adapterUser1 = new AuthenticationAdapter("Diana", "Prince", "dianap", "password456", newAuthSystem);
            var adapterUser2 = new AuthenticationAdapter("Eve", "Adams", "evea", "pass789", newAuthSystem);

            // Build the hierarchy of the organization
            var developmentDept = new Department("Development Department");
            var hrDept = new Department("HR Department");

            // Add users to departments
            developmentDept.AddComponent(new UserComponent(user1));
            developmentDept.AddComponent(new UserComponent(adapterUser1)); // Diana uses the new system

            hrDept.AddComponent(new UserComponent(user2));
            hrDept.AddComponent(new UserComponent(adapterUser2)); // Eve uses the new system

            // Create locations
            var headquarters = new Location("Headquarters");
            var regionalOffice = new Location("Regional Office");

            // Add departments to locations
            headquarters.AddComponent(developmentDept);
            regionalOffice.AddComponent(hrDept);
            regionalOffice.AddComponent(new UserComponent(user3)); // Charlie works in the regional office

            // Display the entire organization structure
            System.Console.WriteLine("Organization Structure:");
            headquarters.DisplayDetails(0);
            regionalOffice.DisplayDetails(0);
        }

        public void PerformAuthentication()
        {
            var newAuthSystem = new NewAuthenticationSystem();
            var adapterUser = new AuthenticationAdapter("Diana", "Prince", "dianap", "password456", newAuthSystem);

            System.Console.WriteLine("Authenticating Diana (new system):");
            bool isAuthenticated = adapterUser.CheckUsernameAndPassword("dianap", "password456");
            System.Console.WriteLine(isAuthenticated ? "Authentication successful!" : "Authentication failed!");

            System.Console.WriteLine("\nGetting user details:");
            System.Console.WriteLine(adapterUser.GetUserDetails(1));

            System.Console.WriteLine("\nResetting password:");
            adapterUser.ResetPassword(1);
        }
    }
}