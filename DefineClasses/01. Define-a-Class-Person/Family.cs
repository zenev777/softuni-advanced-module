using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> families;

         public Family()
         {
             families = new List<Person>();
         }

         public void AddMember(Person member)
         {
                 families.Add(member);
         }
         public Person GetOldestMember()
         {
                 return this.families.OrderByDescending(p => p.Age).FirstOrDefault();
         }
    }
}
