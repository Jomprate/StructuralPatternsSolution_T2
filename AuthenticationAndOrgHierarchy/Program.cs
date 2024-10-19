using AuthenticationAndOrgHierarchy.Client;

namespace AuthenticationAndOrgHierarchy
{
    internal class Program
    {
        private static void Main()
        {
            // Create the client to interact with the organization system
            var client = new OrganizationClient();

            // Display the organization structure
            client.DisplayOrganizationStructure();

            // Perform authentication with the new system using the adapter
            System.Console.WriteLine("\n\nAuthentication Process:");
            client.PerformAuthentication();

            System.Console.ReadLine(); // Wait for user input before closing
        }
    }
}