using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Oreo");
            Console.WriteLine(h1.Name);
            Console.WriteLine(h1.Strength);

            Human h2 = new Human("Gandalf", 5, 10, 2, 110);
            Console.WriteLine(h2.Name);
            Console.WriteLine(h2.Strength);

            h1.Attack(h2);
            Console.WriteLine(h2.Health);
        }
    }
}
