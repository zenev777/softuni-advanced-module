using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                Person person = new Person();
                string[] na = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();  
                person.Name = na[0];
                person.Age = int.Parse(na[1]);
                
                family.AddMember(person);
                //person.AddMember(person);
                
            }
            
            

            Person oldestGuy = family.GetOldestMember();

            Console.WriteLine($"{oldestGuy.Name} {oldestGuy.Age}");

        }
    }
}
