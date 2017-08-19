using System;

namespace try_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name your band?");
            String name = Console.ReadLine();
            Console.WriteLine("How many people are in your band?");
            int numberOfMembers = int.Parse(Console.ReadLine());
            Console.WriteLine(name + " has "+ numberOfMembers + " members");
        }
    }
}
