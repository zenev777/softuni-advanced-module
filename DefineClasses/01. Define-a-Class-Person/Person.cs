using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private int age;
        private string name;


        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age)
            : this()
        {
            Age = age;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Person> over30 = new List<Person>();


        public void AddMember(Person person)
        {
            over30.Add(person);
        }

        public string PersonOver30()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in over30)
            {
                if (item.Age > 30)
                {
                    sb.AppendLine($"{item.Name} - {item.Age}");
                }
            }
            Console.WriteLine(sb);
            return null;
        }

    }
}
