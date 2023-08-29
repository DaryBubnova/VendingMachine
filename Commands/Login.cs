using Machine.Commands;
using Machine.Routing;
using System;

namespace Machine.Commands
{
    internal class Login : ICommand
    {
        private readonly Router _router;

        public Login(Router router) => _router = router;

        public void Execute() => _router.Login();
    }
}
