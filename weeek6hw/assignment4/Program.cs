using System.Globalization;

namespace assignment4
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
            Console.Write("Enter a radius:");
            int radius = int.Parse(Console.ReadLine());

            Circle circle = new(radius);

            circle.DisplayInfo();
        }
    }
}
