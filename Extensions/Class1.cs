using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal class Class1
    {
        public void Print()
        {
            Person p = new Person();
            Console.WriteLine(p.IsPromotable(10));
        }
    }

    sealed class Person
    {

    }

    static class PersonExtensions
    {
        public static bool IsPromotable(this Person p, int age) => age > 18;
    }
}
