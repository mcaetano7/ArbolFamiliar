namespace Library;

public class OldestChildVisitor : IVisitor
{
    public Person OldestChild { get; private set; }
    public int MaxAge { get; private set; }
    
    
}