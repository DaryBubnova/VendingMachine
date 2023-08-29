using Machine.Commands;
using Machine.Routing;
using System;

namespace Machine.Commands
{
    internal class ConsoleCommandInput : ICommandInput
    {
        private readonly Router _router;

        public ConsoleCommandInput(Router router) => _router = router;

        public ICommand GetCommand()
        {
            string commandToParse = Console.ReadLine();
            Request request = Parse(commandToParse);

            return _router.CreateCommand(request);
        }

        private Request Parse(string input)
        {
            string[] terms = input.Trim().Split();
            int[] parametres = new int[0];

            if (terms.Length > 1)
            {
                parametres = new int[terms.Length - 1];
                for (int i = 1; i < terms.Length; i++)
                    parametres[i - 1] = Convert.ToInt32(terms[i]);
            }

            return new Request(terms[0], parametres);
        }
    }
}
