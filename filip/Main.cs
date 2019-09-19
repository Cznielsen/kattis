using System;

namespace filip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            char[] arr0 = input[0].ToCharArray();
            char[] arr1 = input[1].ToCharArray();
            Array.Reverse(arr0);
            Array.Reverse(arr1);

            int num0 = Int32.Parse(new string(arr0));
            int num1 = Int32.Parse(new string(arr1));

            Console.WriteLine(num0 > num1 ? num0 : num1);

        }
    }
}
