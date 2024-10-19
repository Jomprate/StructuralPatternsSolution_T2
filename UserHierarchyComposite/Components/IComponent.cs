namespace UserHierarchyComposite.Components
{
    // Interface for both leaf nodes (users) and composite nodes (departments)
    public interface IComponent
    {
        // Method to display details of the component (User or Department)
        void DisplayDetails(int indentLevel);  // We add indentLevel to reflect hierarchy visually
    }
}