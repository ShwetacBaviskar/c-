using System;

namespace prime
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 2)
            {
                Console.WriteLine("This is not Prime no");
                return 0;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("This is not prime no" + num);
                    return 0;
                    
                }

            }
            Console.WriteLine("This is Prime Number" + num);
            return 0;



        }
    }
}
        
    

