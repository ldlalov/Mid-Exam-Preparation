using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                List<string> cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (cmd[0])
                {
                    case "Shoot":
                        int index = int.Parse(cmd[1]);
                        int power = int.Parse(cmd[2]);
                        if (index >= 0 && index < targets.Count)
                        {
                            targets[index] -= power;

                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        index = int.Parse(cmd[1]);
                        int value = int.Parse(cmd[2]);
                        if (index >= 0 && index < targets.Count)
                        {
                            targets.Insert(index,value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        index = int.Parse(cmd[1]);
                        int radius = int.Parse(cmd[2]);
                        if (index >= 0 && index < targets.Count)
                        {
                            if ((index - radius) >= 0 && (index + radius) < targets.Count)
                            {
                                targets.RemoveRange(index - radius, 2*radius+1);
                            }
                            else
                            {
                                Console.WriteLine("Strike missed!");
                            }
                        }
                        break;

                }
            }
            Console.WriteLine(String.Join("|",targets));
        }
    }
}
