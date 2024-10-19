namespace AuthenticationAndOrgHierarchy.Components
{
    // Interface to represent a component in the organization hierarchy
    public interface IOrganizationComponent
    {
        // Method to display details about the component
        void DisplayDetails(int indentLevel);
    }
}