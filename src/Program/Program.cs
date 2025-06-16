using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos personas
            Node n1 = new Node(new Person("Marcela", 64));
            Node n2 = new Node(new Person("Yunicua", 72));
            Node n3 = new Node(new Person("Rodolfo", 93));
            Node n4 = new Node(new Person("Ramiro", 2));
            Node n5 = new Node(new Person("Paula", 33));
            Node n6 = new Node(new Person("Manuela", 15));
            Node n7 = new Node(new Person("Ezequiel", 26));
            
            //creamos el arbol
            n1.AddChildren(n5);
            n1.AddChildren(n7);

            n2.AddChildren(n1);

            n3.AddChildren(n2);
            
            n5.AddChildren(n6);
            n5.AddChildren((n4));

            // acá visita el arbol
            AgesSumVisitor visitor = new AgesSumVisitor();
            n3.Accept(visitor);
            Console.WriteLine("La suma de las edades es: " + visitor.Sum);
            
            
            //hijo más grande (persona más grande? todas las peronas son hijos)
            OldestPersonExcludingRootVisitor visitor2 = new OldestPersonExcludingRootVisitor(n3);
            n3.Accept(visitor2);
            Console.WriteLine("Hijo más grande: " + visitor2.OldestChild.Name);
            
            //nombre más largo
            NameVisitor visitor3 = new NameVisitor();
            n3.Accept(visitor3);
            Console.WriteLine("Nombre más largo: " + visitor3.LongestName);
        }
        
    }
}
