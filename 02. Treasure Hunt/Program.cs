using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                List<string> cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                switch(cmd[0])
                {
                    case "Loot":
                        for (int i = 1; i < cmd.Count; i++)
                        {
                            if (!loot.Contains(cmd[i]))
                            {
                                loot.Insert(0, cmd[i]);
                            }
                        }
                        break;
                    case "Drop":
                        int index = int.Parse(cmd[1]);
                        if (0<= index && index < loot.Count)
                        {
                            loot.Add(loot[index]);
                            loot.Remove(loot[index]);
                        }
                        break;
                    case "Steal":
                        int count = int.Parse(cmd[1]);
                        List<string> stoledItems = new List<string>();
                        for (int i = count-1; i >= 0; i--)
                        {
                            if (i < loot.Count)
                            {
                            stoledItems.Add(loot.Last());
                            loot.Remove(loot.Last());
                            }
                        }
                        stoledItems.Reverse();
                        Console.WriteLine(string.Join(", ", stoledItems));
                        break;
                }
            }
            if (loot.Count == 0)
            {
                Console.WriteLine($"Failed treasure hunt.");
            }
            else
            {
                double averageGain = 0;
                for (int i = 0; i < loot.Count; i++)
                {
                    averageGain += loot[i].Length;
                }
                averageGain /= loot.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
        }
    }
}
