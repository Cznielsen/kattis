using System;
using System.Collections;

namespace bookingaroom
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cargs = Console.ReadLine().Split(" ");
            int r = Int32.Parse(cargs[0]);
            int n = Int32.Parse(cargs[1]);
            if (n == 0)
            {
                Console.WriteLine(1);
                Environment.Exit(0);
            }
            ArrayList bookedRooms = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                int room = Int32.Parse(Console.ReadLine());
                bookedRooms.Add(room);
            }
            if (r == n)
            {
                Console.WriteLine("too late");
                Environment.Exit(0);
            }
            else
            {
                int it = 1;
                foreach (int bookedRoom in bookedRooms)
                {
                    if (bookedRooms.Contains(it))
                    {
                        it++;
                        continue;
                    }
                }
                Console.WriteLine(it);
                Environment.Exit(0);
            }
        }
    }
}