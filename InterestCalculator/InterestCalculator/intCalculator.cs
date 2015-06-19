using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class intCalculator
    {

        double amount = 0;

        public double calculate(double rate, double principal, double time)
        {
            amount = principal * (1 + rate * time);
            return amount;
        }



    }
}
