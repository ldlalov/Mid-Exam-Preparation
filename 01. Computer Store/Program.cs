using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalPrice = 0;
            double taxes = 0;
            double total = 0;
            while (input != "regular")
            {
                if (input != "special")
                {
                    double price = double.Parse(input);
                    if (price <= 0)
                    {
                        Console.WriteLine("Invalid price!");
                        input = Console.ReadLine();
                        continue;
                    }
                    totalPrice += price;
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                total = totalPrice * 1.2;
                taxes = total - totalPrice;
                if (input == "special")
                {
                    total *= 0.9;
                }
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {total:f2}$");
            }
        }
    }
}
