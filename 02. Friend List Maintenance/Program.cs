using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (cmd[0])
                {
                    case "Blacklist":
                        string name = cmd[1];
                        if (friends.Contains(name))
                        {
                            int temp = friends.IndexOf(name);
                            friends[temp] = "Blacklisted";
                            Console.WriteLine($"{name} was blacklisted.");
                        }
                        else
                        {
                            Console.WriteLine($"{name} was not found.");
                        }
                        break;
                    case "Error":
                        int index = int.Parse(cmd[1]);
                        if (index>=0 && index< friends.Count)
                        {
                            if (friends[index] != "Blacklisted" && friends[index] != "Lost")
                            {
                                name = friends[index];
                                friends[index] = "Lost";
                                Console.WriteLine($"{name} was lost due to an error.");
                            }
                        }
                        break;
                    case "Change":
                        index = int.Parse(cmd[1]);
                        name = cmd[2];
                        if (index >= 0 && index < friends.Count)
                        {
                            string currentName = friends[index];
                            friends[index] = name;
                            Console.WriteLine($"{currentName} changed his username to {name}.");
                        }
                            break;
                }
            }
            int blackListed = 0;
            int lost = 0;
            foreach (var friend in friends)
            {
                if (friend == "Blacklisted")
                {
                    blackListed++;
                }
                if (friend == "Lost")
                {
                    lost++;
                }
            }
            Console.WriteLine($"Blacklisted names: {blackListed}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine(String.Join(' ',friends));
        }
    }
}
