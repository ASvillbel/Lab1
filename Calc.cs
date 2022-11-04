using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    public class Calc
    {
        public double a = 0;

        public void Put_A(double a)
        {
            this.a = a;
        }

        public double Sum(double b)
        {
            return a + b;
        }

        public double Min(double b)
        {
            return a - b;
        }

        public double Mult(double b)
        {
            return a * b;
        }

        public double Division(double b)
        {
            return a / b;
        }

        public void Clear()
        {
            a = 0;
        }
    }
}
