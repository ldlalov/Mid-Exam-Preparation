using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            int room = 0;
            string[] commands = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < commands.Length; i++)
            {
                room++;
                string[] cmd = commands[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch(cmd[0])
                {
                    case "potion":
                        int amount = int.Parse(cmd[1]);
                        health += amount;
                        if (health>100)
                        {
                            amount = Math.Abs(health - 100 - amount);
                            health = 100;
                        }
                        Console.WriteLine($"You healed for {amount} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        amount = int.Parse(cmd[1]);
                        bitcoins += amount;
                        Console.WriteLine($"You found {amount} bitcoins.");
                        break;
                    default:
                        string monster = cmd[0];
                        health -= int.Parse(cmd[1]);
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {monster}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {room}");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}"   );
        }
    }
}
