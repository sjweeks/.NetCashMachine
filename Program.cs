using System;

namespace cSharpCashMachine
{
    class Program
    {
        void checkPin()
        {
        START:
            string pinNumber = "1234";
            string userInput;
            Console.Write("Please enter your pin: ");
            userInput = Console.ReadLine();
            // cashMachine.checkPin(userInput);

            if (userInput == pinNumber)
            {
                Console.WriteLine("Pin Correct");
                optionFunc();
            }
            else
            {
                Console.WriteLine("Please try again");
                goto START;
            }
        }

        void optionFunc()
        {
            string userInput;

            Console.WriteLine("What would you like to do today? 1-Check Balance, 2-Withdraw Cash, 3-Deposit, 4-Change Pin, 5-Quit");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Check Balance");
                Console.ReadKey();
                checkBalance();
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Withdraw Funds");
                // Console.ReadKey();
                withdrawl();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Deposit Funds");
                Console.ReadKey();
                deposit(170, 60);
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Change Pin");
                changePin();
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Please take your card");
                Console.ReadKey();
                quitFunc();
            }
        }

        void changePin()
        {
        HERE:
            string currentPin = "1234";
            string userInput;
            string newPin;

            Console.Write("Please enter your current Pin:");
            userInput = Console.ReadLine();

            if (userInput == currentPin)
            {
                Console.WriteLine("Pin Correct");
                Console.ReadKey();
                Console.Write("Please enter your new Pin:");
                newPin = Console.ReadLine();
                Console.ReadKey();
                Console.WriteLine("Are you sure you'd like to change your pin? Please enter Y or N");
                userInput = Console.ReadLine();

                if (userInput == "Y"){
                    Console.WriteLine("Your Pin has now been changed, you will be taken back to the options");
                    Console.ReadKey();
                    optionFunc();
                }
                else if (userInput == "N"){
                    Console.WriteLine("Your pin has not been changed, you will be taken back to options");
                    Console.ReadKey();
                    optionFunc();
                }
            }
            else
            {
                Console.WriteLine("Please try again");
                goto HERE;
            }
        }
        void checkBalance()
        {
            string userInput;
            string bankBalance = "200";

            Console.WriteLine("Your current balance is {0}", bankBalance);
            // Console.ReadKey();
            Console.WriteLine("Is there anything else you'd like to do? 1-Back to options, 2-Quit");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Back to Options");
                Console.ReadKey();
                optionFunc();
            }
            if (userInput == "2")
            {
                Console.WriteLine("Please take your card");
                Console.ReadKey();
                quitFunc();
            }
        }
        void withdrawl()
        {
            // the reason this is an integer is because we are always going to be storing a numerical value
            int bankBalance = 200;
            // we are keeping this as a string because we may want to use the variable to store other values
            // readLine prefers string values
            string userInput;

            Console.WriteLine("How much would you like to withdraw?");
            userInput = Console.ReadLine();
            
            bankBalance -= Convert.ToInt32(userInput);

            Console.WriteLine("your new balance is: {0}", bankBalance);
            Console.WriteLine("Is there anything else you'd like to do? 1-Back to options, 2-Quit");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Back to options");
                Console.ReadKey();
                optionFunc();
            }
            if (userInput == "2")
            {
                Console.WriteLine("Please take your card");
                Console.ReadKey();
                quitFunc();
            }
        }

        void deposit(int bankBalance, int depositAmount)
        {
            string userInput;

            bankBalance += depositAmount;
            Console.WriteLine("You have deposited {0}, your new balance is {1}", depositAmount, bankBalance);

            Console.WriteLine("Is there anything else you'd like to do? 1-Back to options, 2-Quit");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Back to options");
                Console.ReadKey();
                optionFunc();
            }
            if (userInput == "2")
            {
                Console.WriteLine("Please take your card");
                Console.ReadKey();
                quitFunc();
            }
        }
        void quitFunc()
        {
            Console.WriteLine("Goodbye, have a good day");
        }
        static void Main(string[] args)
        {
            Program cashMachine = new Program();

            cashMachine.checkPin();
        }
    }
}
