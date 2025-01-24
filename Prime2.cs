using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find all prime numbers up to that number:");
            int Num = Convert.ToInt32(Console.ReadLine());
            
            if (Num < 2)
            {
                Console.WriteLine("This is not prime number");
            }
            else
            {
                int sum = 0;
                Console.WriteLine("Prime numbers between 2 and " + Num + ":");
                for (int i = 2; i < Num; i++)
                {
                    if (isprime(i))
                    {
                        Console.WriteLine(i);
                        sum += i;
                        
                    }
                    
                }
                Console.WriteLine(sum);
            }

        }
        static bool isprime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

