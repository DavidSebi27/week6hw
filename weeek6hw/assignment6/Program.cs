using System.Globalization;

namespace assignment6
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
            Console.Write("Enter the name of the account holder: ");
            string name = Console.ReadLine();
            Account account = new(name);

            Console.Write("Enter deposit amount: ");
            double amount = int.Parse(Console.ReadLine());
            account.Deposit(amount);

            account.DisplayAccountInfo();
            
            Console.ReadLine();
        }
    }
}
