using System;

namespace PrintNumbers
{
    class Program
    {
        public static void Print1(int n)
        {
            if (n == 0)
                return;
            Console.Write(n + " ");
            Print1(n - 1);
        }
        public static void Print2(int n)
        {
            if (n == 0)
                return;
            Print2(n - 1);
            Console.Write(n + " ");
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the value of n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numbers in reverse are:");
            Print1(n);          
            Console.Write(n + "\n \n");
            Console.Write("Numbers are:");
            Print2(n);      
            Console.Write(n + " ");

        }
    }
}
