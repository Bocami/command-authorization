using System;
using Bocami.Practices.Decorator;

namespace Bocami.Practices.Command.Authorization
{
    public class AuthorizationCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>, IDecorator<ICommandHandler<TCommand>>
            where TCommand : class, ICommand
    {
        private readonly ICommandHandler<TCommand> commandHandler;
        private readonly ICommandAuthorizer<TCommand> commandAuthorizer;

        public AuthorizationCommandHandlerDecorator(ICommandHandler<TCommand> commandHandler, ICommandAuthorizer<TCommand> commandAuthorizer)
        {
            if (commandHandler == null)
                throw new ArgumentNullException("commandHandler");

            if (commandAuthorizer == null)
                throw new ArgumentNullException("commandAuthorizer");

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
