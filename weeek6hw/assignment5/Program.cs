using System.Globalization;
using System.Runtime.CompilerServices;

namespace assignment5
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
            int value = 10;
            Console.WriteLine($"Original value?: {value}");

            ModifyByValue( value );
            Console.WriteLine($"Value after ModifyByValue: {value}");
            ModifyByReference( ref value );
            Console.WriteLine($"Value after ModifyByReference: {value}");
        }

        void ModifyByValue(int value)
        {
            value += value;
        }

        void ModifyByReference(ref int value)
        {
            value += value;
        }
    }
}
