using System;
using DecoratorPattern2.Interfaces;

namespace DecoratorPattern2.Classes.Decorators
{
    public class FireEnchantmentCharacterActionDecorator : CharacterActionDecorator
    {
        public FireEnchantmentCharacterActionDecorator(ICharacterAction action) : base(action)
        {
        }

        public override void Execute()
        {
            Action.Execute();
            Console.WriteLine("You deal 18 damage with the fire from your attack!");
        }

        public override void Description()
        {
            Action.Description();
            Console.WriteLine("Flames blaze around your weapon, reflected in your enemy's eyes");
        }
    }
}