using System.Text;

namespace String_Vs_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine(str);
            str = string.Concat(str, " World");
            Console.WriteLine(str);

            StringBuilder sb = new StringBuilder();
            sb.Append("String");
            sb.Append("Builder");
            Console.WriteLine(sb);


            string convertedString = sb.ToString();


            StringBuilder convertedStringBuilder = new StringBuilder(str);


            StringBuilder myStringBuilder = new StringBuilder();

            myStringBuilder.AppendFormat("The current temperature is {0} degrees Celsius.\n", 25);


            Console.WriteLine(myStringBuilder);

            myStringBuilder.Insert(0, "Title: ");

            Console.WriteLine("StringBuilder content after append and insert:");
            Console.WriteLine(myStringBuilder);

            myStringBuilder.Remove(7, 7);

            Console.WriteLine("\nStringBuilder content after removing characters:");
            Console.WriteLine(myStringBuilder.ToString());
        }
    }
}
