using UserHierarchyComposite.Client;

namespace UserHierarchyComposite
{
    internal class Program
    {
        private static void Main()
        {
            var organizationClient = new OrganizationClient();
            organizationClient.DisplayOrganizationStructure();
        }
    }
}