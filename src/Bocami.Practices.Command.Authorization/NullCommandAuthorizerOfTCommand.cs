using Bocami.Practices.Authorization;

namespace Bocami.Practices.Command.Authorization
{
    public sealed class NullCommandAuthorizer<TCommand> : NullAuthorizer<TCommand>, ICommandAuthorizer<TCommand> 
        where TCommand : class, ICommand
    {
    }
}
