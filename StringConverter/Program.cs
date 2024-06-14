using System.Text;

namespace StringConverter
{
    internal class Program
    {
        public class Product
        {
            public int Quantity { get; set; }
            public double Price { get; set; }
            public char Tag { get; set; }
            public bool IsFinished { get; set; }

            
            public Product(int quantity, double price, char tag, bool isFinished)
            {
                this.Quantity = quantity;
                this.Price = price;
                this.Tag = tag;
                this.IsFinished = isFinished;
            }

            public override string ToString()
            {
                return $"Product Details:\n" +
                       $"Quantity: {this.Quantity}\n" +
                       $"Price: {this.Price}\n" +
                       $"Tag: {this.Tag}\n" +
                       $"Is Finished: {this.IsFinished}";
            }
        }
    
        static void Main(string[] args)
        {
            
            int quantity = 20;
            double price = 50.00;
            char tag = 'T';
            bool isFinished = false;

            //StringBuilder sb = new StringBuilder("Hello World");
            
            string a = quantity.ToString();
            string b = price.ToString();
            string c = tag.ToString();
            string d = isFinished.ToString();
            //string e = sb.ToString();
            
            /*System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);
            System.Console.WriteLine(e);
            */

            Product product = new Product(10, 99.99, 'A', true);
          
            Console.WriteLine(product);
        }
    }
}
