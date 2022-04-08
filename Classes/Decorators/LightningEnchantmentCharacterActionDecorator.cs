using System;
using DecoratorPattern2.Interfaces;

namespace DecoratorPattern2.Classes.Decorators
{
    public class LightningEnchantmentCharacterActionDecorator : CharacterActionDecorator
    {
        public LightningEnchantmentCharacterActionDecorator(ICharacterAction action) : base(action)
        {
        }

        public override void Execute()
        {
            Action.Execute();
            Console.WriteLine("You deal 31 damage from the lightning enchantment around your weapon!");
        }

        public override void Description()
        {
            Action.Description();
            Console.WriteLine("Lightning wraps around your weapon, arcing occasionally to some passing mote of dust");
        }
    }
}