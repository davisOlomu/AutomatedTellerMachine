using System;
using System.Threading;



namespace AutomatedTellerMachine
{
    class Withdraw : UserInterface
    {

        public static void MakeAWithdrawal()
        {

            Console.Clear();
            AccountTypeInterface();


            ConsoleKeyInfo accType = Console.ReadKey();
            Console.Clear();

            if (accType.Key == ConsoleKey.NumPad1)
                WithdrawalAmountInterface();

            else if (accType.Key == ConsoleKey.NumPad2)
                WithdrawalAmountInterface();

            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t Please take your card");

                Environment.Exit(0);
            }


            WithdrawalAmount();
        }


        public static void WithdrawalAmount()
        {
            string amountEntered;

            ConsoleKeyInfo selectAmount = Console.ReadKey();
            Console.Clear();

            if (selectAmount.Key == ConsoleKey.NumPad1 || selectAmount.Key == ConsoleKey.NumPad2 || selectAmount.Key == ConsoleKey.NumPad3 ||
                selectAmount.Key == ConsoleKey.NumPad4 || selectAmount.Key == ConsoleKey.NumPad5 || selectAmount.Key == ConsoleKey.NumPad6 || selectAmount.Key == ConsoleKey.NumPad7)
            {
                TransactionInProgressInterface();
            }


            // Manually eneter an amount not listed on the console.
            

            else if (selectAmount.Key == ConsoleKey.NumPad8)
            {
                Console.Clear();
                Console.Write("\n\n\t\tEnter in multiples of 1000\n\n\t\t\t  N: ");

                amountEntered = Console.ReadLine();

                if (double.TryParse(amountEntered, out _))
                {
                    Console.Clear();
                    TransactionInProgressInterface();
                }

                else
                {
                    while (!double.TryParse(amountEntered, out _))
                    {
                        Console.Clear();
                        Console.Write("\n\n\t\tEnter in multiples of 1000\n\n\t\t\t  N: ");

                        amountEntered = Console.ReadLine();

                        if (double.TryParse(amountEntered, out _))
                        {
                            Console.Clear();
                            TransactionInProgressInterface();
                        }

                    }
                }

            }


            else if (selectAmount.Key == ConsoleKey.NumPad9)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t Please take your card");

                Environment.Exit(0);
            }


            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t Please take your card");

                Environment.Exit(0);
            }

            Console.WriteLine("\n\n\t\tPlease take your cash");
            Thread.Sleep(6000);

            Console.Clear();
            TransactionCompletedInterface();

        }

    }

}
