using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // acá visita el {arbol
            AgesSumVisitor visitor = new AgesSumVisitor();
            n1.Accept(visitor);
            Console.WriteLine("La suma de las edades es: " + visitor.Sum);
            
            
            //hijo más grande (persona más grande? todas las peronas son hijos)
            OldestChildVisitor visitor2 = new OldestChildVisitor();
            n1.Accept(visitor2);
            Console.WriteLine("Hijo más grande: " + visitor2.OldestChild);
            
            //nombre más largo
            NameVisitor visitor3 = new NameVisitor();
            n1.Accept(visitor3);
            Console.WriteLine("Nombre más largo: " + visitor3.LongestName);
        }
        
    }
}
