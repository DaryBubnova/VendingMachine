using System;

namespace Machine.Orders
{
    abstract class Order : IOrder
    {
        protected readonly Products Products;
        protected readonly int Amount;

        public Order (Products products, int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("Количество не может быть отрицательным");

            Products = products;
            Amount = amount;
        }

        public bool Available => Amount <= Products.Amount;

        abstract public int GetCost();

        public void Process() => Products.Amount -= Amount;
    }
}
