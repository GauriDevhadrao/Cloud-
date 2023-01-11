using System;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI icici_customer = new ICICI(123456, "abc", 5000);
            Console.WriteLine("--------------------------------------------------------------------------------------");

            icici_customer.Deposit(000);
            icici_customer.Withdraw(5000, icici_customer.UnderBalance, icici_customer.ZeroBalance);
            Console.WriteLine("--------------------------------------------------------------------------------------");

            HDFC hdfc_customer = new HDFC(123456, "Gauri Devhadrao", 10000);
            hdfc_customer.Deposit(4000);
            hdfc_customer.Withdraw(5000, hdfc_customer.UnderBalance, hdfc_customer.ZeroBalance);
        }
    }
}