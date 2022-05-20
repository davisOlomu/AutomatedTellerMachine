using System;
using System.Threading;


namespace AutomatedTellerMachine
{
    class Pin
    {
        private string _pinInput;


        public void GetPin()
        {
            Console.WriteLine("\t\t  Enter four digit PIN-code.\n\t\tPress <CANCEL> " +
                "for cancellation\n\n\n\n\t\t\t\t\t\t> Enter");

            Console.Write("\tPIN ****");


            _pinInput = Console.ReadLine();
            Console.Clear();


            // Validate that pin entered is a number and it's not less than or greater
            // than four digits. In the future a database would store user pin.

            if (!double.TryParse(_pinInput, out _) || _pinInput.Length > 4 || _pinInput.Length < 4)
            {
                Console.WriteLine("\n\t\t   Incorrect Pin format!\n\t\t\tRe-Enter Pin");
                Thread.Sleep(2000);

                Console.Clear();
                GetPin();
            }

            else
                UserInterface.TransactionInterface();

        }
    }
}
