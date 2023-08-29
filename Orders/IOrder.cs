using System;

namespace Machine.Orders
{
    internal interface IOrder
    {
        bool Available { get; }

        int GetCost();

        void Process();
    }
}
