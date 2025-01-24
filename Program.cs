using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Multiple Digits");
            String multidigit = Console.ReadLine();
            int sum = 0;
            foreach (char i in multidigit)
            {
                sum += Convert.ToInt32(i.ToString());

            }
            Console.WriteLine(" Sum of all digits" + sum);
        }
    }
}
