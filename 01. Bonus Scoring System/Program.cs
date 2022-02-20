using System;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int extraBonus = int.Parse(Console.ReadLine());
            double bonus = 0;
            double maxBonus = 0;
            double maxattendances = 0;
            for (int i = 1; i <= students; i++)
            {
                double attendances = double.Parse(Console.ReadLine());
                bonus = attendances / lectures * (5 + extraBonus);
            if (maxBonus<bonus)
            {
                maxBonus = bonus;
                maxattendances = attendances;
            }
            }

            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxattendances} lectures.");
        }
    }
}
