using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> result = new List<int>();
            double average = 0;
            for (int i = 0; i < a1.Count; i++)
            {
                average += a1[i];
            }
            average /= a1.Count;
            a1.Sort();
            a1.Reverse();
            for (int i = 0; i < 5; i++)
            {
                if (i < a1.Count-1)
                {
                    if (a1[i] > average)
                    {
                        result.Add(a1[i]);
                    }
                }
            }
            if (result.Count>0)
            {
            Console.WriteLine(String.Join(' ',result));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
