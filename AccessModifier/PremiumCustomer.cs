using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class PremiumCustomer : Customer
    {
        public PremiumCustomer(string id, string name) : base(id, name)
        {

        }

        public void DisplayCustomerName()
        {
            // Accessing the protected Name property from the base class
            //Console.WriteLine(this.Id);
            Console.WriteLine($"Customer Name: {this.Name}");

            Customer c = new Customer("1", "A");
        }
    }

    public class ShowProtected
    {
        public void Print()
        {
            Customer c = new Customer("C1", "Tina");
            c.Salary = 5000;
        }
    }
}
