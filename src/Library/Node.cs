namespace Library;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Node
{
    public object Data { get; set; }
    public List<Node> Children { get; set; }

    public Node(object data)
    {
        Data = data;
        Children = new List<Node>();
    }

    public void AddChildren(Node child)
    {
        Children.Add(child);
    }
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        foreach (var child in Children)
        {
            child.Accept(visitor);
        }
    }
}
