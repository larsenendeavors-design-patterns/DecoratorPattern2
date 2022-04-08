using System;
using DecoratorPattern2.Classes.Factories;

namespace DecoratorPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new AttackActionFactory();
            Console.WriteLine("This is a small app demonstrating the decorator pattern, in this app you can choose from two enchantments, which will decorate your weapon.");
            Console.WriteLine("Choose your enchantments: (1) Fire, (2) Lightning");
            var attack = factory.Construct(Console.ReadLine());
            attack.Description();
            attack.Execute();
        }
    }
}