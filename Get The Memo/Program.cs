using System;

namespace Get_The_Memo
{
    class Program
    {
        int[] valueArray;
        public static int[] memo(int[] array, int x)
        {
            if (array[x] == 1 || array[x] == 2)
            {
                return 1;
            }
            else
            {
                return memo(array[], x + 1) + memo(array[], x + 1);
            }
            return array;
        }

        public static void Main(string[] args)
        {
            Console.Write("Please enter the value of n: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int[] valueArray = new int[userInput];
            Console.Write("The {0}th Fibonacci number is {1}", userInput, memo(valueArray, 0));
        }
    }
}
