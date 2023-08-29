using System;

namespace Machine.Orders
{
    internal class FreeOrder : Order
    {
        public FreeOrder(Products products, int amount) : base(products, amount) { }

        public override int GetCost() => 0;
    }
}
