namespace Library;

public class OldestChildVisitor : IVisitor
{
    public Person OldestChild { get; private set; }
    public int MaxAge { get; private set; }

    public void Visit(Node node)
    {
        if (node.IsLeaf && node.Data is Person person && person.Age > MaxAge)
        {
            MaxAge = person.Age;
            OldestChild = person;
        }
    }
}