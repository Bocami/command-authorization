using Bocami.Practices.Authorization;

namespace Bocami.Practices.Command.Authorization
{
    public interface ICommandAuthorizer<in TCommand> : IAuthorizer<TCommand>
        where TCommand : class, ICommand
    {
    }
}
