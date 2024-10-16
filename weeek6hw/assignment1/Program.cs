using System.Globalization;

namespace assignment1
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
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            
            Person alice = new(name, age);

            Console.WriteLine();
            alice.DisplayInfo();
        }
    }
}
