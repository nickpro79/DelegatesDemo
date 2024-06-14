namespace DelegatesDemo
{
    internal class Program
    {
        public delegate void MyDelegate();

        public static void Main(string[] args)
        {
            MyDelegate del1 = new MyDelegate(Method1);
            MyDelegate del2 = new MyDelegate(Method2);
            MyDelegate del3 = new MyDelegate(Method3);

            MyDelegate chain = del1 + del2 + del3;

            chain();

            chain -= del2;

            chain();
        }

        public static void Method1()
        {
            Console.WriteLine("Method1 called.");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2 called.");
        }

        public static void Method3()
        {
            Console.WriteLine("Method3 called.");
        }


    }
}
