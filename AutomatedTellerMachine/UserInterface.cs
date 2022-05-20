using System;
using System.Threading;

namespace AutomatedTellerMachine
{
    class UserInterface
    {

        // Various interface shown to  users as they walk through the
        // application.
        public static void WelcomeInterface()
        {
            Console.WriteLine("\t\t\t  Welcome to our ATM\n\t\t\tPlease insert your card");
            Thread.Sleep(6500);

            Console.Clear();

        }

        public static void TransactionInterface()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tCHOOSE A TRANSACTION\n\t\t\tPRESS CANCEL TO EXIT\n\n");

            Console.WriteLine("1> Withdrawal\t\t\t\t5> Cash transaction\n2> Transfer\t\t\t\t6> Balance\n" +
                "3> Other Services\t\t\t7> Payment\n4> Online Banking\t\t\t8> Cancel");
        }


        public static void AccountTypeInterface()
        {
            Console.WriteLine("\t\tSelect your account type\n\tPress cancel to terminate transaction" +
                "\n\n\t\t\t\t\t1> Savings\n\t\t\t\t\t2> Current \n\t\t\t\t\t3> Cancel");
        }

        public static void TransactionInProgressInterface()
        {
            Console.WriteLine("\t\t  TRANSACTION IN PROGRESS\n\n\t\t\tPLEASE WAIT");
            Thread.Sleep(7000);

            Console.Clear();
        }

        public static void WithdrawalAmountInterface()
        {
            Console.WriteLine("\t\t\t  SELECT AMOUNT\n\t\tPRESS CANCEL TO TERMINATE TRANSACTION\n\n");

            Console.WriteLine("1> N500\t\t\t\t\t5> N10000\n2> N1000\t\t\t\t6> N15000\n3> N2000\t\t\t\t" +
                "7> N20000\n4> N5000\t\t\t\t8> OTHER \n\t\t\t\t\t9> Cancel");
        }


        public static void TransactionCompletedInterface()
        {

            Console.WriteLine("\t\tTRANSACTION COMPLETED\n\n\t     A notification will be sent\n\t\t   to you shortly");
            Console.WriteLine("\t\t\t\t\t\t1> YES\n\n\t\tDo you want to perform\n\t\t another transaction?" +
                "\n\t\t\t\t\t\t2> NO");

            // Exit the application or perform a different transaction.

            ConsoleKeyInfo exitApp;
            exitApp = Console.ReadKey();


            if (exitApp.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();

                Pin userPin = new Pin();
                userPin.GetPin();

                Transactions transactions = new Transactions();
                transactions.GetUserTransaction();
            }

            else if (exitApp.Key == ConsoleKey.NumPad2)
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

        }

        public static void BeneficiaryBankInterface()
        {
            Console.WriteLine("\t\t\tSelect beneficiary bank\n\t\t Press cancel to terminate transaction\n");

            Console.WriteLine("1> Access Bank\n3> Diamond Bank\t\t\t\t\t2> (F-M)\n5> Eco Bank\t\t\t\t\t4> (N-S)\n7>" +
                " Heritage Bank\t\t\t\t6> (T-Z)");
        }

        public static void BeneficiaryAccountNumberInterface()
        {
            Console.WriteLine("\t\tEnter beneficiary account number" +
                "\n\tPlease press cancel to terminate transaction.\n\n\t\t\t\t\t\t> Enter \n\t\t\t\t\t\t");
        }

        public static void TransferAmountInterface()
        {
            Console.WriteLine("\t\tEnter  the amount to transfer.\n\tPlease press cancel to terminate transaction." +
                "\n\n\t\t\t\t\t\t> Enter\n\t\t\t\t\t\t ");
        }
    }
}
