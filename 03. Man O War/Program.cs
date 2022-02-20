using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split('>', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split('>', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = "";
            int healthCapacity = int.Parse(Console.ReadLine());
            while ((command = Console.ReadLine()) != "Retire")
            {
                List<string> cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (cmd[0])
                {
                    case "Fire":
                        int index = int.Parse(cmd[1]);
                        int damage = int.Parse(cmd[2]);
                        if (index >= 0 && index < warShip.Count)
                        {
                            warShip[index] -= damage;

                            if (warShip[index] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                        break;
                    case "Defend":
                        int startIndex = int.Parse(cmd[1]);
                        int endIndex = int.Parse(cmd[2]);
                        int defendDamage = int.Parse(cmd[3]);
                        if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex >= 0 && endIndex < pirateShip.Count && startIndex <= endIndex)
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                pirateShip[i] -= defendDamage;

                                if (pirateShip[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    return;
                                }
                            }
                        }
                        break;
                    case "Repair":
                        index = int.Parse(cmd[1]);
                        int health = int.Parse(cmd[2]);
                        if (index >= 0 && index < pirateShip.Count)
                        {
                            if (healthCapacity >= pirateShip[index] + health)
                            {
                                pirateShip[index] += health;
                            }
                            else
                            {
                                pirateShip[index] = healthCapacity;
                            }
                        }
                        break;
                    case "Status":
                        int needRepair = 0;
                        for (int i = 0; i < pirateShip.Count; i++)
                        {
                            if (pirateShip[i] < healthCapacity * 0.2)
                            {
                                needRepair++;
                            }
                        }
                        Console.WriteLine($"{needRepair} sections need repair.");
                        break;
                }
            }
            int pirateShipStatus = 0;
            foreach (int section in pirateShip)
            {
                pirateShipStatus += section;
            }
            int warShipStatus = 0;
            foreach (int section in warShip)
            {
                warShipStatus += section;
            }
            Console.WriteLine($"Pirate ship status: {pirateShipStatus}");
            Console.WriteLine($"Warship status: {warShipStatus}");
        }
    }
}
