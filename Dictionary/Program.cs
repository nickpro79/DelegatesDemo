namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> countries = new Dictionary<int,string>();
            countries.Add(1, "India");
            countries.Add(2, "China");
            countries.Add(3, "USA");
            countries.Add(4, "Canada");
            countries.Add(5, "Australia");

            if (countries.ContainsKey(5))
            {
                Console.WriteLine(countries[5]);
            }

            if (countries.TryGetValue(3, out string country)) { 
            Console.WriteLine(country);
            }

            foreach (KeyValuePair<int, string> keyValuePair in countries) {
            Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            }


        }
    }
}
