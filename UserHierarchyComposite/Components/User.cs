namespace UserHierarchyComposite.Components
{
    // Represents an individual user (leaf node in Composite pattern)
    public class User : IComponent
    {
        private string _name;
        private string _position;

        public User(string name, string position)
        {
            _name = name;
            _position = position;
        }

        // Displays user details with indentation reflecting the hierarchy level
        public void DisplayDetails(int indentLevel)
        {
            string indent = new string('-', indentLevel);  // Visual representation of hierarchy
            Console.WriteLine($"{indent} User: {_name}, Position: {_position}");
        }
    }
}