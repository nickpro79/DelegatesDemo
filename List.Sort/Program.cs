namespace List.Sort
{
    internal class Program
    {
        public class Customer : IComparable<Customer>
        {
            public string name { get; set; }

            public int salary { get; set; }

            public int CompareTo(Customer? other)
            {
                if (this.salary > other.salary)
                    return 1;
                else if (this.salary < other.salary) return -1;

                else return 0;
            }
        }

            static void Main(string[] args)
            {
                List<Customer> list = new List<Customer>();
                list[0] = new Customer() { name = "John", salary = 7000 };
                list[1] = new Customer() { name = "Jerry", salary = 17000 };
                list[2] = new Customer() { name = "Tina", salary = 10000 };

            list.Sort();
            foreach (var item in list) { 
            Console.WriteLine(item.name);
            }
            }
        }
    }

