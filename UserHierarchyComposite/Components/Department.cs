using System.Collections.Generic;

namespace UserHierarchyComposite.Components
{
    // Composite node that can contain users and other departments
    public class Department : IComponent
    {
        private string _name;
        private List<IComponent> _components = new List<IComponent>();

        public Department(string name)
        {
            _name = name;
        }

        // Add a user or another department to this department
        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        // Remove a user or department from this department
        public void Remove(IComponent component)
        {
            _components.Remove(component);
        }

        // Displays department details, then iterates over and displays details of its components
        public void DisplayDetails(int indentLevel)
        {
            string indent = new string('-', indentLevel);  // Visual representation of hierarchy
            Console.WriteLine($"{indent} Department: {_name}");

            foreach (var component in _components)
            {
                // Display details of each component (user or department) with increased indentation
                component.DisplayDetails(indentLevel + 2);
            }
        }
    }
}