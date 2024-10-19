using AuthenticationAndOrgHierarchy.Components;

namespace AuthenticationAndOrgHierarchy.Components
{
    // Composite component representing a department that can contain users or other departments
    public class Department : IOrganizationComponent
    {
        private readonly string _name;
        private readonly List<IOrganizationComponent> _components = new List<IOrganizationComponent>();

        // Constructor to initialize department with a name
        public Department(string name)
        {
            _name = name;
        }

        // Method to add a component (user or department) to the department
        public void AddComponent(IOrganizationComponent component)
        {
            _components.Add(component);
        }

        // Method to remove a component from the department
        public void RemoveComponent(IOrganizationComponent component)
        {
            _components.Remove(component);
        }

        // Display department and its components with indentation for hierarchy
        public void DisplayDetails(int indentLevel)
        {
            string indent = new string('-', indentLevel);
            System.Console.WriteLine($"{indent}Department: {_name}");

            foreach (var component in _components)
            {
                component.DisplayDetails(indentLevel + 2); // Increase indent level for subcomponents
            }
        }
    }
}