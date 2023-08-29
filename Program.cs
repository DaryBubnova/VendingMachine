using System;
using System.Net.WebSockets;
using System.Threading;
using Machine.Commands;
using Machine.Routing;

namespace Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine(0, new Products("Crisps", 250, 3), 
                                                           new Products("Ise Cream", 150, 3));

            ICommandInput input = new ConsoleCommandInput(new Router(machine));

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Текущий баланс: {machine.Balance}");
                Console.WriteLine("Введите команду");

                ICommand command = input.GetCommand();
                Console.WriteLine();

                if(command is null)
                {
                    Console.WriteLine("Такой команды не существует");
                    Thread.Sleep(2000);
                    continue;
                }

                try
                {
                    command.Execute ();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Что-то пошло не так" +
                                        $"\nСообщение: {ex.Message}");
                    Thread.Sleep(2000);
                    continue;
                }

                Console.WriteLine("\nКоманда выполнена. Нажмите Enter.");
                Console.ReadKey();
            }
        }
    }
}