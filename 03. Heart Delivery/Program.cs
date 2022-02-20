using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = "";
            int lastIndex = 0;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] cmd = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                int jumpStep = int.Parse(cmd[1]);
                lastIndex += jumpStep;
                if (lastIndex>=neighborhood.Count)
                {
                    lastIndex = 0;
                }
                    if (neighborhood[lastIndex] == 0)
                    {
                        Console.WriteLine($"Place {lastIndex} already had Valentine's day.");
                    }
                    else
                    {
                        neighborhood[lastIndex] -= 2;
                        if (neighborhood[lastIndex] == 0)
                        {
                            Console.WriteLine($"Place {lastIndex} has Valentine's day.");
                        }
                    }

            }
            Console.WriteLine($"Cupid's last position was {lastIndex}.");
            bool hasValentinesDay = true;
            int failedHouses = 0;
            foreach (var house in neighborhood)
            {
                if (house > 0)
                {
                    hasValentinesDay = false;
                    failedHouses++;
                }
            }
            if (hasValentinesDay)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
        }
    }
}
