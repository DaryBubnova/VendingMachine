using Machine.Commands;
using System;

namespace Machine.Commands
{
    internal class GetChange : ICommand
    {
        private readonly VendingMachine _machine;

        public GetChange(VendingMachine machine) => _machine = machine;

        public void Execute() => _machine.DropBalance(_machine.Balance);
    }
}
