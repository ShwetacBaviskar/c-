using System;

namespace factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int Num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            while(Num>0)
            {
                fact = fact * Num;
                Num--;
            }
            Console.WriteLine("Factorial of the given number" + fact);
        }
    }
}
