using System;

namespace _01._The_Hunting_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double totalEnergy = double.Parse(Console.ReadLine());
            double waterPerPerson = double.Parse(Console.ReadLine());
            double foodPerPerson = double.Parse(Console.ReadLine());
            double totalWater = players * waterPerPerson * days;
            double totalFood = players * foodPerPerson * days;
            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                totalEnergy -= energyLoss;
                if (totalEnergy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                    {
                        totalEnergy *= 1.05;
                        totalWater *= 0.7;
                    }
                    if (i % 3 == 0)
                    {
                       totalFood -= totalFood / players;
                        totalEnergy *= 1.1;
                    }

                if (totalEnergy <= 0)
                {
                    break;
                }

            }
            if (totalEnergy>0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {totalEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }
            {

            }
        }
    }
}
