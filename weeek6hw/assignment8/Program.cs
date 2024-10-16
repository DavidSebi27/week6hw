using System.Globalization;
using System.Security.AccessControl;

namespace assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            BankAccount account = new("1", 0);

            Console.Write("Enter deposit amount: ");
            double amount = int.Parse(Console.ReadLine());
            account.Deposit(amount);

            Console.Write("Enter withdrawal amount: ");
            double withdrewn = int.Parse(Console.ReadLine());
            account.Withdraw(withdrewn);

            account.AccountDetails();

            Console.ReadLine();
        }
    }
}
