using System;

namespace AutomatedTellerMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Console ATM";

            Console.SetWindowSize(60, 20);
            Console.SetBufferSize(200, 100);

            UserInterface.WelcomeInterface();

            var userPin = new Pin();
            userPin.GetPin();

            var userTransaction = new Transactions();
            userTransaction.GetUserTransaction();
        }
    }

}
