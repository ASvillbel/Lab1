using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Калькулятор;

namespace Калькулятор.Test
{
    public class Tests
    {
        [TestCase(5, 7, 12)]
        [TestCase(1, 2, 3)]
        [TestCase(100, -1, 99)]
        [TestCase(10, -100, -90)]
        public void ReturnSum(double x, double y, double expected)
        {
            var calc = new Calc();

            var actual = x+calc.Sum(y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 5, 3)]
        [TestCase(9, 12, -3)]
        [TestCase(25, 20, 5)]
        [TestCase(10, 2, 8)]
        public void ReturnMin(double x, double y, double expected)
        {
            var calc = new Calc();

            var actual = x-calc.Min(y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, 10)]
        [TestCase(5, 3, 15)]
        [TestCase(12, 10, 120)]
        [TestCase(10, 3, 30)]
        public void ReturnMult(double x, int y, double expected)
        {
            var calc = new Calc();

            var actual = x*calc.Mult(y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 2, 3)]
        [TestCase(133, 1, 133)]
        [TestCase(35, 5, 7)]
        [TestCase(220, 2, 110)]
        public void ReturnDivision(double x, double y, double expected)
        {
            var calc = new Calc();

            var actual = x/calc.Division(y);

            Assert.AreEqual(expected, actual);
        }
    }
}