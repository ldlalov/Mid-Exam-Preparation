using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int emp1Students = int.Parse(Console.ReadLine());
            int emp2Students = int.Parse(Console.ReadLine());
            int emp3Students = int.Parse(Console.ReadLine());
            double students = int.Parse(Console.ReadLine());
            double studentsPerHour = emp1Students + emp2Students + emp3Students;
            double time = 0;
            double studentsLeft = students;
            for (double i = 1; i <= students; i += studentsPerHour)
            {
                time++;
                studentsLeft -= studentsPerHour;
                if (time%4==0)
                {
                    time++;
                }
                if (studentsLeft <= 0)
                {
                    break;
                }
            }

            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
