using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Program
{
    public class Program
    {
        public Double DivideNumbers(double a, double b)
        {
            if (b == 0.00)
                return a;
            return a / b;
        }
        static void Main(string[] args)
        {

        }
    }
}
