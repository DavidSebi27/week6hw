using System.Globalization;

namespace assignment7
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
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter product price: ");
            double price = double.Parse(Console.ReadLine());

            Product product = new(name, price);

            product.DisplayProduct();

            Console.ReadLine();
        }
    }
}
