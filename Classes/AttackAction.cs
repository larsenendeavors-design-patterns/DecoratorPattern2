using System;
using DecoratorPattern2.Interfaces;

namespace DecoratorPattern2.Classes
{
    public class AttackAction : ICharacterAction
    {
        public void Execute()
        {
            Console.WriteLine("The attack from your blade dealt 17 damage");
        }

        public void Description()
        {
            Console.WriteLine("Description of the base attack");
        }
    }
}