using Bocami.Practices.Authorization;

namespace Bocami.Practices.Command.Authorization
{
    public class NullCommandAuthorizer<TCommand> : NullAuthorizer<TCommand>, ICommandAuthorizer<TCommand> 
        where TCommand : ICommand
    {
    }
}
