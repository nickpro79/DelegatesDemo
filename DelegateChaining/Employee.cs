using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static DelegateChaining.Program;

namespace DelegateChaining
{
    internal class Employee
    {
        public string name {  get; set; }
        public int Salary { get; set; }
        public int Id { get; set; }
        public int experience { get; set; }
        public static void PromoteEmployee(Employee[] employees, IsPromotable IsPromotable)
        {
            foreach (Employee e in employees)
            {
                if (IsPromotable(e))
                {
                    Console.WriteLine(e.Id);
                }
            }
        }
        
        public static void PromoteEmployee(Employee[] employees, Func<Employee, bool> IsPromotable)
        {
            foreach (Employee e in employees)
            {
                if (IsPromotable(e))
                {
                    Console.WriteLine(e.Id);
                }
            }
        }

        public static void PromoteEmployee(Employee[] employees, Predicate<Employee> IsPromotable)
        {
            foreach (Employee e in employees)
            {
                if (IsPromotable(e))
                {
                    Console.WriteLine(e.Id);
                }
            }
        }

        public static void DisplayEmployee(Employee[] employees,Action<Employee> action)
        {
            foreach(Employee e in employees)
            action(e);
        }
    }
}
