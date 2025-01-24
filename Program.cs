using System;
using System.Collections;

namespace arr2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 3, 5, 5 },{3,6,8,9} };
            Console.WriteLine("Rank"+arr1.Rank);
            ArrayList list = new ArrayList();
            list.Add(2);
            list.Add(5);
            list.Add(6);
            list.Add(8);
            list.Add(9);
            foreach(var i in list)
            {
                Console.WriteLine("" + i);
            }

        }
    }
}
