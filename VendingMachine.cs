using System;
using Machine.Orders;

namespace Machine
{
    internal class VendingMachine
    {
        public int Balance { get; private set; }

        private Products[] _products;

        public (int balance, params Products[] products)
        {
            Balance = balance;
            _products = products;
        }

        public void AddBalance(int addBalance)
        {
            if (addBalance < 0)
                throw new ArgumentOutOfRangeException("Баланс не может быть меньше 0");

            Balance += addBalance;
        }

        public void DropBalance(int dropBalance)
        {
            if (dropBalance < 0 && Balance >= dropBalance)
                throw new ArgumentOutOfRangeException("Баланс не может быть меньше 0");

            Balance -= dropBalance;
        }

        public bool Contains(int id) => id >= 0 && id < _products.Length;

        public Products GetProductsById( int id)
        {
            if (!Contains(id))
                throw new ArgumentOutOfRangeException("Неправильный ID");

            return _products[id];
        }

        public void ProcessOrder(IOrder order)
        {
            TryProcessOrder(order, out bool success);

            if (!success)
                throw new ArgumentException("Ну удалось создать заказ");
        }

        public void TryProcessOrder(IOrder order, out bool success)
        {
            success = IsOrderPossible(order);

            if (!success)
                return;

            DropBalance(order.GetCost());
            order.Process();
        }

        private bool IsOrderPossible(IOrder order) => order.Available && order.GetCost() <= Balance;


    }
}