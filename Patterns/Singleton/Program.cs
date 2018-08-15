using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public class Program
    {
        public static void Main()
        {
            Calculator c1 = Calculator.GetCalculator();
            Calculator c2 = Calculator.GetCalculator();

            if (c1 == c2)
            {
                Console.WriteLine("Same instance");
            }

            Calculator calc = Calculator.GetCalculator();
            double result = calc.Operation('+', 5, 8);
            Console.WriteLine("Result is: " + result);
            Console.ReadKey();
        }
    }
}
