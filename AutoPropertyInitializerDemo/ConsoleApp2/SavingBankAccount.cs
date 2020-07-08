using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp2
{
    public class SavingBankAccount
    {
        public Guid CustomerId
        {
            get;
         } = Guid.NewGuid();

        public string AcctType
        {
            get;
            set;
        } = "Saving Account";
        public double MinBalance
        {
            get;
            set;
        }=10000;
        public string pan
        {
            get;
        } = "AKCPD8928";
        
        public string FirstName
        {
            get;
            set;
        } = "Mukesh";
        public string LastName
        {
            get;
            set;
        } = "Kumar";

        public void Deposit(double amount)
        {
            MinBalance += amount;
            WriteLine($"The Actual balance after depositing the amount in the account is {MinBalance}");
        }
        public void Deposit(float amount)
        {
            MinBalance -= amount;
            WriteLine($"The Actual balance after withdrawing the amount in the account is {MinBalance}");
        }
        public double GetBalance()
        {
            WriteLine($"The Actual balance in the account is {MinBalance}");
            return MinBalance;
        }

    }
    class SavingDemo
    {
        public static void Main()
        {
            SavingBankAccount sobj = new SavingBankAccount();
            WriteLine($"The Full Name of Customer who has opened bank account is {sobj.FirstName} {sobj.LastName}");
            WriteLine($"The Pan number is ${sobj.pan}");
            WriteLine($"The CustomerId is ${sobj.CustomerId}");
            sobj.Deposit(2000);
            sobj.Withdraw(300);
            sobj.GetBalance();
            ReadLine();
        }
    }
}
