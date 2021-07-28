using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract class Account
    {
        public double AccountNo { get; set; }

        public int AccountBal { get; set; }

        public string AccountPasswaord { get; set; }

        public static string bankName;

        static Account()
        {
            Account.bankName = "ICICI Bank";
        }

        public Account()
        {
            AccountNo = 226965334582;
            AccountBal = 50000;
            AccountPasswaord = "Asdf@jhn";
        }

        public Account(double acc_no, int acc_bal, string acc_pass)
        {
            AccountNo = acc_no;
            AccountBal = acc_bal;
            AccountPasswaord = acc_pass;
        }

        public virtual void DisplayBankDetails()
        {
            Console.WriteLine("Account Number: " +AccountNo);
            Console.WriteLine("Account Balance: " + AccountBal);
            Console.WriteLine("Account Password: " + AccountPasswaord);
            Console.WriteLine("Bank Name: " + Account.bankName);
        }

        public abstract void Withdraw(int amount);
    }

    class SavingsAccount: Account
    {
        double minimumBalance;

        public double MinimumBalance { get => minimumBalance; set => minimumBalance = value; }

        public SavingsAccount(double acc_no, int acc_bal, string acc_pass, double min_bal):base(acc_no, acc_bal,acc_pass)
        {
            this.MinimumBalance = min_bal;
        }

        private void InsufficientFundException(int amount, double acc_no)
        {
            if (amount>acc_no)
            {
                throw new InsufficientFundException("Amount entered is more than your current balance");
            }
        }

        public override void Withdraw(int amount)
        {
            //throw new NotImplementedException();
            try
            {
                //InsufficientBalException(amount, AccountBal);

                InsufficientFundException(amount, AccountBal, MinimumBalance);
                InvalidAmountException(amount, AccountBal);
                AccountBal = AccountBal - amount;
            }
            catch (InvalidAmountException n)
            {
                Console.WriteLine(n.Message);
            }
            catch (InsufficientFundException i)
            {
                Console.WriteLine(i.Message);
            }


        }
        private void InsufficientFundException(int amount, double accountBal, double minimumBalance)
        {
            if (accountBal - amount < minimumBalance)
            {
                throw new InsufficientFundException("Insufficient Balance");
            }
        }
        private void InvalidAmountException(int amount, double accountBal)
        {
            if (accountBal - amount < 0)
            {
                throw new InvalidAmountException("Negative Balance");
            }
        }


        public override void DisplayBankDetails()
        {
            Console.WriteLine("Account Number: " + AccountNo);
            Console.WriteLine("Account Balance: " + AccountBal);
            Console.WriteLine("Minimum Balance: " + MinimumBalance);
            Console.WriteLine("Account Password: " + AccountPasswaord);
            Console.WriteLine("Bank Name: " + Account.bankName);
        }



    }

    class CurrentAccount: Account
    {
        double overdraftLimitAmount;

        public double OverdraftLimitAmount { get => overdraftLimitAmount; set => overdraftLimitAmount = value; }

        public CurrentAccount(double acc_no, int acc_bal, string acc_pass, double overdraft_amt):base(acc_no, acc_bal, acc_pass)
        {
            this.OverdraftLimitAmount = overdraft_amt;
        }

        public override void Withdraw(int amount)
        {
            //throw new NotImplementedException();
            AccountBal = AccountBal - amount;
        }

        public override void DisplayBankDetails()
        {
            Console.WriteLine("Account Number: " + AccountNo);
            Console.WriteLine("Account Balance: " + AccountBal);
            Console.WriteLine("Minimum Balance: " + OverdraftLimitAmount);
            Console.WriteLine("Account Password: " + AccountPasswaord);
            Console.WriteLine("Bank Name: " + Account.bankName);
        }



    }
}
