using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int A, int B)
        {
            throw new NotImplementedException();
        }

        public float Divide(int dividend, int divisor)
        {
            if (divisor == 0) throw new DivideByZeroException();

            float result = (float)dividend / divisor;
            OnCalculated();
            return result;
        }

        public event EventHandler CalculatedEvent;

        protected virtual void OnCalculated()
        {
            var handler = CalculatedEvent;
            if (handler != null)
                handler(this, EventArgs.Empty); // to samo co: "handler?.Invoke(this,EventArgs.Empty);"! :D
        }

    }
}

