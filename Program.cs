﻿using System;

namespace try_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name your band?");
            String name = Console.ReadLine();
            Console.WriteLine("How many people are in your band?");
            int numberOfMembers = 0;
            if(!int.TryParse(Console.ReadLine(),out numberOfMembers))
            {
                Console.WriteLine("input was not valid");
                Environment.Exit(0);
            }

            if (numberOfMembers < 1)
                Console.WriteLine("You must have at least 1 member");
            else if (numberOfMembers == 1)
                Console.WriteLine(name + " is a solo");
            else if (numberOfMembers == 2)
                Console.WriteLine(name + " is a duo");
            else
                Console.WriteLine(name + " has "+ numberOfMembers + " members");
        }
    }
}
