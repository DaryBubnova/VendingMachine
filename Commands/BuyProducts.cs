using Machine.Commands;
using System;
using Machine.Orders;

namespace Machine.Commands
{
    internal class BuyProducts : ICommand
    {
        private readonly VendingMachine _machine;
        private readonly IOrder _order;

        public BuyProducts(VendingMachine machine, IOrder order)
        {
            _machine = machine;
            _order = order;
        }

        public void Execute() => _machine.ProcessOrder(_order);
    }
}
