using System;
using ToHModels;

namespace ToHUI
{
    class Program
    {
        static void Main(string[] args)

        {
            Hero newHero = new Hero();

            Console.WriteLine("Welcome to ToH please build a Hero!");

            Console.WriteLine("Name your Hero:");
            newHero.Name = Console.ReadLine();

            Console.WriteLine("Select your heroes element type");
            newHero.ElementType = Enum.Parse<Element>(Console.ReadLine().ToLower());

            SuperPower newSuperPower = new SuperPower();
            Console.WriteLine("Enter your heroes super power");
            newSuperPower.Name = Console.ReadLine();

            Console.WriteLine("How much damage does this power do?");
            newSuperPower.Damage = int.Parse(Console.ReadLine());

            newHero.Power = newSuperPower;

            Console.WriteLine("How much HP does your hero Have?");
            newHero.HP = int.Parse(Console.ReadLine());

            Console.WriteLine($"New hero created \n Hero name: {newHero.Name} \n Hero Element: {newHero.ElementType} \n Hero Super Power: {newHero.Power.Name}");

        }
    }
}
