namespace Library;

public class SumVisitor: IVisitor
{
   public int Sum { get; private set; }

    public void Visit(Node node)
    {
        if (node.Data is int number)
        {
            Sum += number;
        }
        
    }
}
