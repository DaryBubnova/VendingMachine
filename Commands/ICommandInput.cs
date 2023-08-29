using System;

namespace Machine.Commands
{
    internal interface ICommandInput
    {
        ICommand GetCommand();
    }
}
