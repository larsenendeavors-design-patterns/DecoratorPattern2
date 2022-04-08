using System.Diagnostics;
using DecoratorPattern2.Classes.Decorators;
using DecoratorPattern2.Interfaces;

namespace DecoratorPattern2.Classes.Factories
{
    public class AttackActionFactory
    {
        public ICharacterAction Construct(string attackPattern)
        {
            ICharacterAction characterAction = new AttackAction();
            if (string.IsNullOrWhiteSpace(attackPattern))
            {
                return characterAction;
            }

            foreach (var character in attackPattern)
            {
                characterAction = character switch
                {
                    '1' => new FireEnchantmentCharacterActionDecorator(characterAction),
                    '2' => new LightningEnchantmentCharacterActionDecorator(characterAction),
                    _ => characterAction
                };
            }

            return characterAction;
        } 
    }
}