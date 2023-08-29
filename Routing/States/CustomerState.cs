using Machine.Orders;
using System;

namespace Machine.Routing.States
{
    internal class CustomerState : RouterState
    {
        public CustomerState(Router router) : base(router) { }

        public override IOrder MakeOrder(Request request)
        {
            Products products = Router.Machine.GetProductsById(request.Parameters[0]);

            return new PaidOrder(products, amount: request.Parameters[1]);
        }
    }
}
