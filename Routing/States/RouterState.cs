using System;
using Machine.Orders;

namespace Machine.Routing.States
{
    abstract class RouterState
    {
        protected readonly Router Router;

        protected RouterState(Router router) => Router = router;

        public abstract IOrder MakeOrder(Request request);

    }
}
