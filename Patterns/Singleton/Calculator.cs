using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public class Calculator
    {
        private static Calculator _calc;
        private double res;

        // Lock synchronization object
        private static object syncLock = new object();

        protected Calculator()
        {
        }

        public static Calculator GetCalculator()
        {
            if (_calc == null)
            {
                lock (syncLock)
                {
                    if (_calc == null)
                    {
                        _calc = new Calculator();
                    }
                }
            }
            return _calc;
        }

        public double Operation (char op, double a, double b)
        {
            switch (op)
            {
                case '+': res = a + b;
                    break;
                case '-': res = a - b;
                    break;
                case '*': res = a * b;
                    break;
                case '/': res = a / b;
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}
