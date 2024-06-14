using System.Reflection;
namespace Reflextion
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Customer)) return false;

            return (this.FirstName == ((Customer)obj).LastName & this.LastName == ((Customer)obj).FirstName);
        }


        public void Print()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer { FirstName = "Tina", LastName = "John" };
            Customer c2 = new Customer { FirstName = "John", LastName = "Tina" };
            Console.WriteLine(c1.Equals(c2));
        }
    }
}
