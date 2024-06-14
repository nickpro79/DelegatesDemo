namespace Anonymous_Function
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /* Func<int, int, int> addDelegate = Add;
             Console.WriteLine(Add(10, 120));

             Func<int, int, int> addAnonymous = delegate (int firstNumber, int secondNumber)
             {
                 return firstNumber + secondNumber;
             };
             Console.WriteLine(addAnonymous(30, 40));

             Func <int,int,int> AddLambda = (firstNumber,secondNumber) => firstNumber + secondNumber;

             Func<int, int, int> Addnew = (firstNumber, secondNumber) =>
             {
                 firstNumber++;
                 secondNumber--;
                 return firstNumber + secondNumber;
             };*/

            //Action<int, int> AddDelegate = Add;
            //AddDelegate(10, 20);



            //Action AddDelegate = Add;
            //AddDelegate();

            //Predicate<int> DisplayDelegate = display;
            //DisplayDelegate(4);

            //Func<bool> predicate = display;

        }

        static void Add() { 
         Console.WriteLine("Hello There");
        }

        static bool display()
        {
            return true;
        }
    }
}
