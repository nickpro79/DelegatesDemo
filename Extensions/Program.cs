using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Extensions
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    class Company
    {
        List<Employee> Employees;

        public Company()
        {
            Employees = new List<Employee>()
            {
                new Employee{Id=1,Name="Thomas" },
                new Employee{Id=2,Name="Vicky" },
                new Employee{Id=3,Name="Tina" },
            };
        }

        public string this[int id]
        {
            get
            {
                Employee emp = Employees.Find(e => e.Id == id);
                return emp.Name;
            }
            set
            {
                Employee emp = Employees.Find(e => e.Id == id);
                emp.Name = value;
            }

        }
        
    }
        internal class Program
        {
            static void Main(string[] args) {
                Company company = new Company();
            company[2] = "Hi";
            Console.WriteLine(company[2]);

            
            }


        }

        public static class IntExtensions
        {
            public static bool IsGreaterThan(this int value, int comparisonValue)
            {
                return value > comparisonValue;
            }
        }


    
}
