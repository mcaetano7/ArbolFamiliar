namespace Library;

public class OldestPersonExcludingRootVisitor : IVisitor
{
    public Person OldestChild { get; private set; }
    public int MaxAge { get; private set; } = -1;
    private Node root; 
    public OldestPersonExcludingRootVisitor(Node rootNode)
    {
        root = rootNode;  // guardamos la raíz
    }
    
    public void Visit(Node node)
    {
        if (node == root)
            return;
        
        if (node.Data is Person person)
        {
            if (person.Age > MaxAge)
            {
                MaxAge = person.Age;
                OldestChild = person;
            }
            
        }
    }
}