namespace Library;

public class NameVisitor : IVisitor
{
    public Person LongestName { get; private set; }
    public int MaxLength { get; private set; } = 0;

    public void Visit(Node node)
    {
        if (node.Data is Person person && person.Name.Length > MaxLength)
        {
            MaxLength = person.Name.Length;
            LongestName = person;
        }
    }
}