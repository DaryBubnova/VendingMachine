using System;

namespace Machine.Orders
{
    internal class PaidOrder : Order
    {
        public PaidOrder(Products products, int amount) : base(products, amount) { }

        public override int GetCost() => Amount * Products.Prise;
    }
}
