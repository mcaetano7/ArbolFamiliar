namespace Library;

public class AgesSumVisitor : IVisitor
{
    public int Sum { get; private set; }

    public void Visit(Node node)
    {
        if (node.Data is Person person)
        { 
            Sum += person.Age;
        }
    }
    
}