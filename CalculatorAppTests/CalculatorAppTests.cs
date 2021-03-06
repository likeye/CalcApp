﻿using System;
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
        [TestCase(4, 2, 2.0f)]
        [TestCase(-4, 2, -2.0f)]
        [TestCase(4, -2, -2.0f)]
        [TestCase(0, 3, 0.0f)]
        [TestCase(5, 2, 2.5f)]
        [TestCase(1, 3, 0.333333343f)] // 4 bo zaokrąglanie - zapamiętać ~

        public void Divide_ReturnsProperValue(int dividend, int divisor, float expectedQuotient)
        {
            var calc = new Calculator();
            var quotient = calc.Divide(dividend, divisor);
            Assert.AreEqual(expectedQuotient, quotient);
        }

        [Test]
        public void Divide_DivisionByZero_ThrowsException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(delegate { calc.Divide(2, 0); }); // można tak: Assert.Throws<DivideByZeroException>(() => calc.Divide(2, 0));
        }

        [Test]
        public void Divide_OnCalculatedEventIsCalled()
        {
            var calc = new Calculator();

            bool wasEventCalled = false;
            calc.CalculatedEvent += delegate { wasEventCalled = true; };  // lub : calc.CalculatedEvent += (sender, args) => wasEventCalled = true;
            //WYRAZENIA LAMBDA
            calc.Divide(1, 2);

            Assert.IsTrue(wasEventCalled);

        }
    }
}
