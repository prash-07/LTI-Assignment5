using System;

namespace Assignment5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Second Line");

            Console.WriteLine("Enter Amount to be withdrawn :");
            int amount = Convert.ToInt32(Console.ReadLine());
            SavingsAccount a1 = new SavingsAccount(332964553151, 10000, "Bnte@chr",5000);
            CurrentAccount a2 = new CurrentAccount(251645965415, 50000, "Aryu@125", 10000);
            a1.Withdraw(amount);
            a1.DisplayBankDetails();
            a2.DisplayBankDetails();
        }
    }
}




/*
Stats s1 = new Stats();
s1.generate_runs();
s1.displayStats();
*/

/*
Program a = new Program();
Console.WriteLine("Enter number of Units of Electricity Consumed: ");
int no_ofUnits = Convert.ToInt32(Console.ReadLine());
decimal total_bill = a.CalculateBill(no_ofUnits);
Console.WriteLine("Your Bill Amount is Rupees " + total_bill);
*/



/*
public decimal CalculateBill(int units)
{
    if (units <= 100)
    {
        decimal bill = (decimal)(units * 1.20);
        return bill;
    }
    else if(units > 100 && units <= 300)
    {
        units = units - 100;
        decimal bill = 120 + (decimal)(units * 2);
        return bill;
    }
    else
    {
        units = units - 300;
        decimal bill = 120 + 400 + (decimal)(units * 3);
        return bill;
    }
}
*/
