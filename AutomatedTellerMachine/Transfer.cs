using System;
using System.Collections.Generic;
using System.Threading;



namespace AutomatedTellerMachine
{
    class Transfer : UserInterface
    {

        private static double _amount;

        private static ConsoleKeyInfo _selectBank;

        private static double _beneficiaryAccountNumber;

        private static string _beneficiaryBank;

        private static string[] _listOfBanks;


        public static void MakeATransfer()
        {
            Console.Clear();
            BeneficiaryBankInterface();

            _selectBank = Console.ReadKey();
            Console.Clear();

            if (_selectBank.Key == ConsoleKey.NumPad1 || _selectBank.Key == ConsoleKey.NumPad3 || _selectBank.Key == ConsoleKey.NumPad5 || _selectBank.Key == ConsoleKey.NumPad7)
            {

                _listOfBanks = new[] { "Access Bank", "Diamond Bank", "Eco Bank", "Heritage Bank" };

                if (_selectBank.Key == ConsoleKey.NumPad1)
                    _beneficiaryBank = _listOfBanks[0];

                if (_selectBank.Key == ConsoleKey.NumPad2)
                    _beneficiaryBank = _listOfBanks[1];

                if (_selectBank.Key == ConsoleKey.NumPad3)
                    _beneficiaryBank = _listOfBanks[2];

                if (_selectBank.Key == ConsoleKey.NumPad4)
                    _beneficiaryBank = _listOfBanks[3];

                BeneficiaryAccounNumber();

            }



            if (_selectBank.Key == ConsoleKey.NumPad2)
            {
                List<string> displayBanks = new List<string> { "1> Fidelity Bank", "2> First Bank", "3> GT Bank\n\n" };

                foreach (string bankName in displayBanks)
                    Console.WriteLine(bankName);

                _selectBank = Console.ReadKey();
                Console.Clear();

                if (_selectBank.Key == ConsoleKey.NumPad1 || _selectBank.Key == ConsoleKey.NumPad2 || _selectBank.Key == ConsoleKey.NumPad3)
                {
                    _listOfBanks = new[] { "Fidelity Bank", "First Bank", "GT Bank" };

                    if (_selectBank.Key == ConsoleKey.NumPad1)
                        _beneficiaryBank = _listOfBanks[0];

                    if (_selectBank.Key == ConsoleKey.NumPad2)
                        _beneficiaryBank = _listOfBanks[1];

                    if (_selectBank.Key == ConsoleKey.NumPad3)
                        _beneficiaryBank = _listOfBanks[2];

                    BeneficiaryAccounNumber();
                }

            }



            if (_selectBank.Key == ConsoleKey.NumPad4)
            {
                List<string> displayBanks = new List<string> { "1> Polaris Bank", "2> Stanbic IBTC", "3> Standard Chartered", "4> Sterling Bank\n\n" };

                foreach (string bankName in displayBanks)
                    Console.WriteLine(bankName);

                _selectBank = Console.ReadKey();
                Console.Clear();

                if (_selectBank.Key == ConsoleKey.NumPad1 || _selectBank.Key == ConsoleKey.NumPad2 || _selectBank.Key == ConsoleKey.NumPad3 || _selectBank.Key == ConsoleKey.NumPad4)
                {
                    _listOfBanks = new[] { "Polaris Bank", "Stanbic IBTC", "Standard Chartered", "Sterling Bank" };

                    if (_selectBank.Key == ConsoleKey.NumPad1)
                        _beneficiaryBank = _listOfBanks[0];

                    if (_selectBank.Key == ConsoleKey.NumPad2)
                        _beneficiaryBank = _listOfBanks[1];

                    if (_selectBank.Key == ConsoleKey.NumPad3)
                        _beneficiaryBank = _listOfBanks[2];

                    if (_selectBank.Key == ConsoleKey.NumPad4)
                        _beneficiaryBank = _listOfBanks[3];

                    BeneficiaryAccounNumber();
                }

            }



            if (_selectBank.Key == ConsoleKey.NumPad6)
            {
                List<string> displayBanks = new List<string> { "1> Taj Bank", "2> Unity Bank", "3> Union Bank", "4> Wema Bank", "5> GTB", "6> Zenith Bank\n\n" };

                foreach (string bankName in displayBanks)
                    Console.WriteLine(bankName);

                _selectBank = Console.ReadKey();
                Console.Clear();

                if (_selectBank.Key == ConsoleKey.NumPad1 || _selectBank.Key == ConsoleKey.NumPad2 || _selectBank.Key == ConsoleKey.NumPad3 || _selectBank.Key == ConsoleKey.NumPad4 || _selectBank.Key == ConsoleKey.NumPad5 || _selectBank.Key == ConsoleKey.NumPad6)
                {
                    _listOfBanks = new[] { "Taj Bank", " Unity Bank", "Union Bank", "Wema Bank", "GTB", "Zenith Bank" };

                    if (_selectBank.Key == ConsoleKey.NumPad1)
                        _beneficiaryBank = _listOfBanks[0];

                    if (_selectBank.Key == ConsoleKey.NumPad2)
                        _beneficiaryBank = _listOfBanks[1];

                    if (_selectBank.Key == ConsoleKey.NumPad3)
                        _beneficiaryBank = _listOfBanks[2];

                    if (_selectBank.Key == ConsoleKey.NumPad4)
                        _beneficiaryBank = _listOfBanks[3];

                    if (_selectBank.Key == ConsoleKey.NumPad5)
                        _beneficiaryBank = _listOfBanks[4];

                    if (_selectBank.Key == ConsoleKey.NumPad6)
                        _beneficiaryBank = _listOfBanks[5];


                    BeneficiaryAccounNumber();

                }
            }
        }




        public static void BeneficiaryAccounNumber()
        {
            BeneficiaryAccountNumberInterface();
            string accoutNumberEntered = Console.ReadLine();

            Console.Clear();

            if (!double.TryParse(accoutNumberEntered, out _beneficiaryAccountNumber) || accoutNumberEntered.Length > 10 || accoutNumberEntered.Length > 10)
            {
                Console.WriteLine("\n\n\t\tInvalid account number entered\n\t\tRe-Enter Account Number");
                Thread.Sleep(2500);

                Console.Clear();
                BeneficiaryAccounNumber();
            }

            else
            {
                Console.Clear();
                AccountTypeInterface();
            }


            ConsoleKeyInfo accType = Console.ReadKey();
            Console.Clear();

            if (accType.Key == ConsoleKey.NumPad1)
                TransferAmountInterface();

            else if (accType.Key == ConsoleKey.NumPad2)
                TransferAmountInterface();

            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t Please take your card");

                Environment.Exit(0);
            }

            Console.Write("NGN:");
            _amount = double.Parse(Console.ReadLine());

            ConfirmTransferDetails();

        }

        // Double check that the correct details of transaction
        // has been selected.
        public static void ConfirmTransferDetails()
        {
            Console.Clear();
            Console.WriteLine("\t\tPlease confirm details of Transfer\n");

            Console.WriteLine("Account Number: " + _beneficiaryAccountNumber);
            Console.WriteLine("Amount:NGN " + _amount);

            Console.WriteLine("Bank: " + _beneficiaryBank);
            Console.WriteLine("\n\n\t\t\t\t\t\t1> Proceed \n\t\t\t\t\t\t2> Cancel   ");

            ConsoleKeyInfo confirmInput = Console.ReadKey();
            Console.Clear();

            if (confirmInput.Key == ConsoleKey.NumPad1)
            {
                TransactionInProgressInterface();
                Console.Clear();

                TransactionCompletedInterface();
            }


            else if (confirmInput.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine("\n\n\t\t Please take your card");
                Environment.Exit(0);
            }


        }
    }

}
