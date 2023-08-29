using Machine.Commands;
using Machine.Routing;
using System;

namespace Machine.Commands
{
    internal class Logout : ICommand
    {
        private readonly Router _router;

        public Logout(Router router) => _router = router;

        public void Execute() => _router.Logout();
    }
}
