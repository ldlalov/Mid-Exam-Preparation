using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int daylyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double plunder = 0;
            for (int i = 1; i <= days; i++)
            {
                plunder += daylyPlunder;
                if (i % 3 == 0)
                {
                    plunder += daylyPlunder * 0.5;
                }
                if (i % 5 == 0)
                {
                    plunder -= plunder * 0.3;
                }

            }
            double percentage = plunder / expectedPlunder * 100;
            if (plunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {plunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
