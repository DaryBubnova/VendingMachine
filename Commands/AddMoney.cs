using Machine.Commands;
using System;

namespace Machine.Commands
{
    internal class AddMoney : ICommand
    {
        private readonly VendingMachine _machine;
        private readonly int _moneyToAdd;

        public AddMoney(VendingMachine machine, int moneyToAdd)
        {
            _machine = machine;
            _moneyToAdd = moneyToAdd;
        }

        public void Execute() => _machine.AddBalance(_moneyToAdd);
    }
}
