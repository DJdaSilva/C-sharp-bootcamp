using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLab
{
    class Program
    {
        static List<BankAccount> accounts = new List<BankAccount>();

        static void Main(string[] args)
        {
            while (true)
            {
                int selection;
                bool success = int.TryParse(getUserSelection(), out selection);

                while (!success || selection < 0 || selection > 2)
                {
                    Console.WriteLine("Please select a number 0-2:");
                    success = int.TryParse(getUserSelection(), out selection);
                }

                switch (selection)
                {
                    case 0:
                        {
                            doStartAccount();
                            break;
                        }

                    case 1:
                        {
                            doAccountDeposit();
                            break;
                        }
                    case 2:
                        {
                            doAccountWithdrawal();
                            break;
                        }
                }
            }
        }

        private static string getUserSelection()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("0) Start an account");
            Console.WriteLine("1) Deposit into account");
            Console.WriteLine("2) Withdraw from account");

            return Console.ReadLine();
        }

        private static void doStartAccount()
        {
            Console.WriteLine("Please enter initial deposit amount:");

            float amount;
            bool success = float.TryParse(Console.ReadLine(), out amount);

            while (!success)
            {
                Console.WriteLine("Please enter a valid number");
                success = float.TryParse(Console.ReadLine(), out amount);
            }

            accounts.Add(new BankAccount(amount));
        }

        private static void doAccountWithdrawal()
        {
            int accountNumber = getAccountNumber();

            Console.WriteLine("Please enter withdraw amount:");

            float amount;
            bool success = float.TryParse(Console.ReadLine(), out amount);

            while (!success)
            {
                Console.WriteLine("Please enter a valid number");
                success = float.TryParse(Console.ReadLine(), out amount);
            }

            Console.WriteLine(accounts.ElementAt(accountNumber).withdraw(amount));
        }

        private static void doAccountDeposit()
        {
            int accountNumber = getAccountNumber();

            Console.WriteLine("Please enter deposit amount:");

            float amount;
            bool success = float.TryParse(Console.ReadLine(), out amount);

            while (!success)
            {
                Console.WriteLine("Please enter a valid number");
                success = float.TryParse(Console.ReadLine(), out amount);
            }

            Console.WriteLine(accounts.ElementAt(accountNumber).deposit(amount));
        }

        private static int getAccountNumber()
        {
            Console.WriteLine("Please enter account number:");

            int accountNumber;
            bool success = int.TryParse(Console.ReadLine(), out accountNumber);

            while (!success || accountNumber < 0 || accountNumber > accounts.Count - 1)
            {
                Console.WriteLine("Please enter a valid account number");
                success = int.TryParse(Console.ReadLine(), out accountNumber);
            }

            return accountNumber;
        }
    }

    public class BankAccount
    {
        float balance;

        public BankAccount(float initialCash)
        {
            this.balance = initialCash;
        }

        public string deposit(float depositAmount)
        {
            if (depositAmount <= 0)
            {
                return "Please enter a positive amount to deposit";
            }

            this.balance += depositAmount;

            return $"Deposit successful, new account balance: R {this.balance}";
        }

        public string withdraw(float withdrawAmount)
        {
            if (withdrawAmount <= 0)
            {
                return "Please enter a positive amount to withdraw";
            }

            this.balance -= withdrawAmount;

            return $"Withdrawal successful, new account balance: R {this.balance}";
        }
    }
}
