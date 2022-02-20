using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = "";
            int count = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                int target = int.Parse(command);
                if (target>=0 && target < targets.Length)
                {
                    int temp = targets[target];
                    for (int i = 0; i < targets.Length; i++)
                    {
                        
                        if (targets[i]>temp && targets[i] != -1)
                        {
                            targets[i] -= temp;
                        }
                        else if (targets[i] <= temp && targets[i] != -1)
                        {
                            targets[i] += temp;
                        }
                    }
                    targets[target] = -1;
                    count++;
                }
            }
            Console.WriteLine($"Shot targets: {count} -> {string.Join(' ',targets)}");
        }
    }
}
