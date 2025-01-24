using System;
using System.Collections.Generic;
namespace Palindron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the Number");
            
            String num = Console.ReadLine();
            char[] arr = num.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
            String digit = new string(arr);
            if (num == digit)
            {
                Console.WriteLine("Number is palindron");
            }
            else
            {
                Console.WriteLine("Number is not  palindron");
            }

            
            
        }
    }
}
