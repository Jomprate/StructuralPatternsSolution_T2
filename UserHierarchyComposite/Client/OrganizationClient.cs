using UserHierarchyComposite.Components;

namespace UserHierarchyComposite.Client
{
    public class OrganizationClient
    {
        public void DisplayOrganizationStructure()
        {
            // Creating users (leaf nodes)
            var user1 = new User("Alice", "Developer");
            var user2 = new User("Bob", "Manager");
            var user3 = new User("Charlie", "HR");
            var user4 = new User("Diana", "Recruiter");

            // Creating departments (composite nodes)
            var devDepartment = new Department("Development Department");
            devDepartment.Add(user1); // Adding Alice
            devDepartment.Add(user2); // Adding Bob

            var hrDepartment = new Department("HR Department");
            hrDepartment.Add(user3); // Adding Charlie
            hrDepartment.Add(user4); // Adding Diana

            // Creating a larger department that contains other departments
            var company = new Department("Tech Corp");
            company.Add(devDepartment); // Adding Development Department
            company.Add(hrDepartment);  // Adding HR Department

            // Display the entire hierarchy
            company.DisplayDetails(0);  // Start at indent level 0
        }
    }
}