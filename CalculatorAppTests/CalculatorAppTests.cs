using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp;
using NUnit.Framework;

namespace CalculatorAppTests
{
    public class CalculatorAppTests
    {
        readonly Calculator _calc = new Calculator();
        [Test]
        public void Add_AddsTwoPositiveNumbers_Calculated()
        {
            var sum = _calc.Add(2, 2);
            Assert.AreEqual(4, sum);
        }

        [Test]
        public void Add_AddsTwoDifferentNumbers_Calculated()
        {
            var sum = _calc.Add(-4, 8);
            Assert.AreEqual(sum, 4);
        }

        [Test]
        public void Add_AddsTwoNegativeNumbers_Calculated()
        {
            var sum = _calc.Add(-4, -2);
            Assert.AreEqual(sum, -6);
        }
    }
}
