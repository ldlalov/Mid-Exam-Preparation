using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] cmd = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (cmd[0])
                {
                    case "Collect":
                        string item = cmd[1];
                        if (!journal.Contains(item))
                        {
                            journal.Add(item);
                        }
                        break;
                    case "Drop":
                        item = cmd[1];
                        if (journal.Contains(item))
                        {
                            journal.Remove(item);
                        }
                        break;
                    case "Combine Items":
                        string[] items = cmd[1].Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                        string oldItem = items[0];
                        string newItem = items[1];
                        int index = -1;
                        if (journal.Contains(oldItem))
                        {
                            index = journal.IndexOf(oldItem);
                            journal.Insert(index + 1, newItem);
                        }
                        break;
                    case "Renew":
                        item = cmd[1];
                        if (journal.Contains(item))
                        {
                            journal.Remove(item);
                            journal.Add(item);
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(", ",journal));
        }
    }
}
