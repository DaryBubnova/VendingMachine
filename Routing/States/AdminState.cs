using System;
using Machine.Orders;

namespace Machine.Routing.States
{
    internal class AdminState : RouterState
    {
        public AdminState(Router router) : base(router) { }

        public override IOrder MakeOrder(Request request)
        {
            Products products = Router.Machine.GetProductsById(request.Parameters[0]);

            return new FreeOrder(products, amount: request.Parameters[1]);
        }
    }
}
