using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Helpers
    {
        public static double calculateFine(double overtime, double fineAmout)
        {
            return overtime * fineAmout;
        }
    }
}
