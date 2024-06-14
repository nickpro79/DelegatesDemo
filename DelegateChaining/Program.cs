namespace DelegateChaining
{
    internal class Program
    {
        public delegate bool IsPromotable(Employee e);
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee { name = "John",Salary=5000, Id=1, experience=2 };
            employees[1] = new Employee { name = "Timmy",Salary = 10000, Id = 2, experience = 5 };
            employees[2] = new Employee { name = "Sarah",Salary = 15000, Id = 3, experience = 10 };

            //IsPromotable IsPromotable = new IsPromotable(promoteemployee);
            //Employee.PromoteEmployee(employees, IsPromotable);

            //Func<Employee, bool> IsPromotableFunc = promoteemployee;
            //Employee.PromoteEmployee(employees, IsPromotableFunc);

            //Predicate<Employee> IsPromotablePredicate = promoteemployee;
            //Employee.PromoteEmployee(employees, IsPromotablePredicate);

            Action<Employee> DisplayAction = display;
            Employee.DisplayEmployee(employees, DisplayAction);

        }
        static bool promoteemployee(Employee e)
        {
            if (e.Salary >= 10000)
                return true;
            else return false;
        }

        static void display(Employee e)
        {
            Console.WriteLine(e.name);
        }
    }

}
