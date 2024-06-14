using System;

namespace AccessModifier
{
    public class Customer
    {
        private string Id { get; set; }
        protected string Name { get; set; }

        internal float Salary { get; set; }

        //protected internal string PhoneNumber { get; set; }
        //private protected string Address { get; set; }

        public Customer(string id,string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void DisplayId()
        {
            Display();
        }

        private void Display()
        {
            Console.WriteLine(this.Id);
           // Console.WriteLine(this.Name);
            //Console.WriteLine(this.Salary);
        }


    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer("C123","John");
            // Console.WriteLine(customer.Id); // This line would cause a compilation error because Id is private
            customer.Salary = 5000;
            customer.DisplayId();
            //customer.PhoneNumber = "92222222";
            
            //Console.WriteLine(customer.name);This line would cause a compilation error because Name is protocted
        }
    }
}

