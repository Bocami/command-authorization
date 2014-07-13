using Bocami.Practices.DecoratorPattern;

namespace Bocami.Practices.Command.Authorization
{
    public abstract class AuthorizationCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>, IDecorator<ICommandHandler<TCommand>>
            where TCommand : class, ICommand
    {
        private readonly ICommandHandler<TCommand> commandHandler;
        private readonly ICommandAuthorizer<TCommand> commandAuthorizer;

        protected AuthorizationCommandHandlerDecorator(ICommandHandler<TCommand> commandHandler, ICommandAuthorizer<TCommand> commandAuthorizer)
        {
            this.commandHandler = commandHandler;
            this.commandAuthorizer = commandAuthorizer;
        }

        public void Handle(TCommand command)
        {
            commandAuthorizer.Authorize(command);

            commandHandler.Handle(command);
        }
    }
}
