using System;



namespace AutomatedTellerMachine
{
    class Transactions
    {
        private ConsoleKeyInfo _myTransaction;

        public void GetUserTransaction()
        {

            // Select a transaction by entering the
            // appropriate number on the console.

            Console.WriteLine(Environment.NewLine);
            _myTransaction = Console.ReadKey();

            switch (_myTransaction.Key)
            {
                case ConsoleKey.NumPad1:
                    Withdraw.MakeAWithdrawal();
                    break;

                case ConsoleKey.NumPad2:
                    Transfer.MakeATransfer();
                    break;

                case ConsoleKey.NumPad3:
                    Console.Clear();
                    break;

                case ConsoleKey.NumPad4:
                    Console.Clear();
                    break;

                case ConsoleKey.NumPad5:
                    Console.Clear();
                    break;

                case ConsoleKey.NumPad6:
                    Console.Clear();
                    break;

                case ConsoleKey.NumPad7:
                    Console.Clear();
                    break;

                case ConsoleKey.NumPad8:
                    Console.Clear();

                    Console.WriteLine("\n\n\t\t Please take your card");
                    Environment.Exit(0);

                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t Please take your card");

                    Environment.Exit(0);
                    break;

            }

        }

    }

}

