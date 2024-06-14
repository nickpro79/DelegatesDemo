using System.ComponentModel;

namespace Generics
{
    class Utility<T>
    {

        public static void Add(T first, T second)
        {
            Console.WriteLine(first + second);
        }
        public static bool AreEqual(T first, T second)
        {
            return first.Equals(second);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Utility<int>.AreEqual(1, '1'));
            Console.WriteLine(Utility<string>.AreEqual("1", "1"));
            Utility<int>.Add(1, 1);
        }
    }

}
