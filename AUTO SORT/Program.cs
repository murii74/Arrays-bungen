using System;

namespace AUTO_SORT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 696969, 2000, 720800, 80000000 };
            Array.Sort(array);
            Array.Reverse(array);
           
            Console.Write(array[0]);
            Console.Write(" ");
            Console.Write(array[1]);
            Console.Write(" ");
            Console.Write(array[2]);
            Console.Write(" ");
            Console.Write(array[3]);
            foreach (int value in array)
                Console.Write(value + " ");
            



        }

    }
}
