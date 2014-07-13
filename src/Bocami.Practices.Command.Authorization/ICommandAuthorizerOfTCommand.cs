using Bocami.Practices.Authorization;

namespace Bocami.Practices.Command.Authorization
{
    public interface ICommandAuthorizer<TCommand> : IAuthorizer<TCommand>
        where TCommand : class, ICommand
    {
    }
}
