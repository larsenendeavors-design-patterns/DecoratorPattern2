using DecoratorPattern2.Interfaces;

namespace DecoratorPattern2.Classes.Decorators
{
    public abstract class CharacterActionDecorator : ICharacterAction
    {
        protected ICharacterAction Action { get; set; }

        protected CharacterActionDecorator(ICharacterAction action)
        {
            Action = action;
        }

        public virtual void Execute()
        {
            Action.Execute();
        }

        public virtual void Description()
        {
            Action.Description();
        }
    }
}