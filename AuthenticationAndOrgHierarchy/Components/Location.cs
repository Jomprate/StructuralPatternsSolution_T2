using AuthenticationAndOrgHierarchy.Components;

namespace AuthenticationAndOrgHierarchy.Components
{
    // Composite component representing a location that can contain departments or other components
    public class Location : IOrganizationComponent
    {
        private readonly string _name;
        private readonly List<IOrganizationComponent> _components = new List<IOrganizationComponent>();

        // Constructor to initialize location with a name
        public Location(string name)
        {
            _name = name;
        }

        // Method to add a component (department or user) to the location
        public void AddComponent(IOrganizationComponent component)
        {
            _components.Add(component);
        }

        // Method to remove a component from the location
        public void RemoveComponent(IOrganizationComponent component)
        {
            _components.Remove(component);
        }

        // Display location and its components with indentation for hierarchy
        public void DisplayDetails(int indentLevel)
        {
            string indent = new string('-', indentLevel);
            System.Console.WriteLine($"{indent}Location: {_name}");

            foreach (var component in _components)
            {
                component.DisplayDetails(indentLevel + 2); // Increase indent level for subcomponents
            }
        }
    }
}