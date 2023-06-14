
using System;
using System.Reflection;

namespace ATM
{
    public class Program

    {

        public static decimal Balance = 100;
        static void Main(string[] args)
        {

            UserInterface();
        }


        public static void UserInterface()
        {
            UserInterface(Balance);
        }



        public static decimal ViewBalance()
        {

            return Balance;
        }

        public static decimal WithDraw(decimal amount)
        {
            if (Balance < Convert.ToInt32(amount))
            {
                Console.WriteLine("Your bank balance is not enough to make this withdrawal.");
            }
            else if (Convert.ToInt32(amount) < 0)
            {
                Console.WriteLine("You are trying to withdraw a cash amount of less than zero.");
            }


            else
            {
                Balance -= Convert.ToInt32(amount);
                Console.WriteLine($"An amount of {amount}$ has been withdrawn from your account, and the remaining amount is {Balance}$.");
            };
            return Balance;
        }


        public static decimal Deposit(decimal amount)
        {
            //decimal value = Convert.ToDecimal(Console.ReadLine());
            if (0 > amount)
            {
                Console.WriteLine("You are trying to deposit a cash amount less than zero");
            }
            else
            {
                Balance += Convert.ToInt32(amount);
                Console.WriteLine($"Your bank account has been credited with {amount}$, your balance is now {Balance}$");

            }
            return Balance;
        }




        public static void UserInterface(decimal Balance)
        {

            string transaction = "";

            while (true)
            {

                Console.WriteLine("Choose a transaction: 1) ViewBalance,  2) WithDraw,  3) Deposit,  4) Exit");
                transaction = Console.ReadLine();


                if (transaction == "1")
                {
                    Console.WriteLine($"Your balance is {ViewBalance()}$");
                }
                else if (transaction == "2")
                {
                    Console.WriteLine("Enter amount to withdraw:");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    WithDraw(amount);

                }
                else if (transaction == "3")
                {
                    Console.WriteLine("Enter amount to deposit:");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    Deposit(amount);
                }
                else if (transaction == "4")
                {
                    Console.WriteLine("Thank you for using our ATM!");
                    break;
                }



            }


        }












    }
}
